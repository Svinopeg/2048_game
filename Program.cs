using System;
using System.Collections.Generic;

namespace test2
{
	class BusStop
	{
		public int number;
		public List<Route> routes = new List<Route>();

		public BusStop(int number)
		{
			this.number = number;
		}
		public void AddRoute(Route route)
		{
			this.routes.Add(route);
		}
		public Tuple<bool, Route> hasAccessTo(BusStop bus_stop)
		{
			Route direct_route = null;
			bool has_access = false;
			foreach (Route route in this.routes)
			{
				foreach (BusStop stop_in_route in route.bus_stops)
				{
					if (bus_stop.number == stop_in_route.number)
					{
						has_access = true;
						direct_route = route;
						break;
					}
				}
			}
			return new Tuple<bool, Route>(has_access, direct_route);
		}

		public List<Tuple<BusStop, Route>> getDirectStops()
		{
			List<Tuple<BusStop, Route>> direct_stops = new List<Tuple<BusStop, Route>>();
			foreach (Route route in this.routes)
			{
				foreach (BusStop stop_in_route in route.bus_stops)
				{
					direct_stops.Add(new Tuple<BusStop, Route>(stop_in_route, route));
				}
			}
			return direct_stops;
		}
	}

	class Route
	{
		public int number;
		public List<BusStop> bus_stops = new List<BusStop>();

		public Route(int number)
		{
			this.number = number;
		}
		public void AddStop(BusStop bus_stop)
		{
			this.bus_stops.Add(bus_stop);
			bus_stop.AddRoute(this);
		}
	}

	class MainClass
	{
		static Dictionary<int, BusStop> bus_stops = new Dictionary<int, BusStop>();
		void ChangeRoute(BusStop bus_stop)
		{

		}
		public static void Main(string[] args)
		{
			Random rnd = new Random();
			int bus_stop_amount = rnd.Next(20, 40);


			for (int i = 0; i < bus_stop_amount; i++)
			{
				bus_stops.Add(i, new BusStop(i));
			}
			List<Route> available_routes = new List<Route>();
			int route_counter = 0;
			int next_stop = 0;
			while (next_stop < bus_stop_amount - 4)
			{
				Route route = new Route(route_counter);

				int current_route_length = rnd.Next(4, 10);
				int starts_from = next_stop;
				int ends_at = Math.Min(next_stop + current_route_length, bus_stop_amount);
				for (int i = starts_from; i < ends_at; i++)
				{
					route.AddStop(bus_stops[i]);
				}
				next_stop = ends_at - rnd.Next(1, 6);
				available_routes.Add(route);
				route_counter++;
			}
			Route last_route = new Route(route_counter);
			for (int i = bus_stop_amount - rnd.Next(2, 6); i < bus_stop_amount; i++)
			{
				last_route.AddStop(bus_stops[i]);
			}
			route_counter++;


			Console.WriteLine("There is " + bus_stop_amount + " bus stops and " + route_counter + " routes:\n");
			foreach (BusStop bus_stop in bus_stops.Values)
			{
				Console.Write("stop #" + (bus_stop.number + 1) + ": ");
				string routes = "";
				foreach (Route route in bus_stop.routes)
				{
					routes += Convert.ToString(route.number + 1) + ",";
				}
				routes = routes.Substring(0, routes.Length - 1);
				Console.WriteLine("Routes: " + routes);
			}

			Console.WriteLine("There is some routes: ");
			foreach (Route rt in available_routes)
			{
				Console.Write("M" + (rt.number + 1) + "={ ");
				string str_stops = "";
				foreach (BusStop bs in rt.bus_stops)
				{
					str_stops += Convert.ToString(bs.number + 1) + ",";
				}
				str_stops = str_stops.Substring(0, str_stops.Length - 1);
				str_stops += "}, \n";
				Console.Write(str_stops);
			}

			while (true)
			{
				Console.Write("\nInput the first bus stop plz: ");

				int first_stop = Convert.ToInt32(Console.ReadLine()) - 1;
				Console.Write("Input the second bus stop plz: ");
				int second_stop = Convert.ToInt32(Console.ReadLine()) - 1;


				List<Tuple<BusStop, Route>> queue = bus_stops[first_stop].getDirectStops();
				List<Route> using_routes = new List<Route>();
				List<BusStop> used_stops = new List<BusStop>();
				used_stops.Add(bus_stops[first_stop]);
				/*List<Tuple<BusStop, Route>> queue = new List<Tuple<BusStop, Route>>();
				foreach (Route rt in bus_stops[first_stop].routes) {
					queue.Add(new Tuple<BusStop, Route>(bus_stops[first_stop], rt));
				}*/
				bool is_destination_reached = false;

				int route_changes = 0;

				int while_counter = 0;
				while (!is_destination_reached)
				{
					while_counter++;
					Route using_route = null;
					BusStop used_stop = null;
					foreach (Tuple<BusStop, Route> bus_stop in queue)
					{
						Tuple<bool, Route> accessable_route = bus_stop.Item1.hasAccessTo(bus_stops[second_stop]);
						List<Tuple<BusStop, Route>> accessable_stops = bus_stop.Item1.getDirectStops();
						using_route = bus_stop.Item2;
						used_stop = bus_stop.Item1;
						if (accessable_route.Item1)
						{ //is destination reached?!
							is_destination_reached = true;
							break;
						}
						queue = queue.GetRange(1, queue.Count - 1);
						queue.AddRange(accessable_stops);
					}
					used_stops.Add(used_stop);
					using_routes.Add(using_route);
					if (!is_destination_reached)
					{
						route_changes++;
					}
					else
					{
						using_routes.Add(queue[0].Item1.hasAccessTo(bus_stops[second_stop]).Item2);
						if (while_counter == 1 && using_routes.Count == 2 && using_routes[0].number == using_routes[1].number)
						{
							using_routes = using_routes.GetRange(1, using_routes.Count - 1);
						}
					}
				}

				string str_routes_used = "The shortest way is: ";

				for (int i = 0; i < used_stops.Count - 1; i++)
				{
					Console.WriteLine((i + 1) + ". From " + (used_stops[i].number + 1) + " to " + (used_stops[i + 1].number + 1) + ", using " + (using_routes[i].number + 1) + " route.");
				}
				Console.WriteLine(used_stops.Count + ". From " + (used_stops[used_stops.Count - 1].number + 1) + " to " + (bus_stops[second_stop].number + 1) + ", using " + (using_routes[using_routes.Count - 1].number + 1) + " route.");
				foreach (Route used_route in using_routes)
				{
					str_routes_used += (used_route.number + 1) + ">";
				}

				str_routes_used = str_routes_used.Substring(0, str_routes_used.Length - 1);
				Console.WriteLine("The shortest way is: " + str_routes_used + "; Use this route chain.\n");
				Console.Write("write 'exit' to close application or press enter to continue: ");
				var a = Console.ReadLine();
				if (a == "exit")
				{
					break;
				}
			}
		}
	}
}
