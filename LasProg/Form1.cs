using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Diagnostics;
using EntityFramework.BulkInsert.Extensions;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using MongoDB.Bson.Serialization;
using Newtonsoft.Json;

namespace LasProg
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public class Product
		{
			public int ProductID { get; set; }
			public string ProductName { get; set; }
			public int UnitPriceHUF { get; set; }
			public string Category { get; set; }
		}

		public class MongoProduct
		{
			public int ProductID { get; set; }
			public string ProductName { get; set; }
			public int UnitPriceHUF { get; set; }
			public string Category { get; set; }
		}

		private void mssql_100migrate_Click(object sender, EventArgs e)
		{
			LoadProgressText.Text = "MsSQL 100 Load in Progress";
			//Read Files//
			var path = firstPath.Text;
			var row = string.Empty;
			var products = new List<Product>();
			using (var fs = new FileStream(path,FileMode.Open))
			using (var sr = new StreamReader(fs,Encoding.UTF8))
			{
				while (null != (row = sr.ReadLine()))
				{
					var pieces = row.Split(';');
					var p = new Product()
					{
						ProductID = int.Parse(pieces[0]),
						ProductName = pieces[1],
						UnitPriceHUF = int.Parse(pieces[2]),
						Category = pieces[3]
					};
					products.Add(p);
				}

			}
			//Load Database//
			var sometime = new List<long>();

			for (int i = 0; i < products.Count; i=i+100)
			{
				var items = products.Skip(i).Take(100);
				using (var db = new TesztEntities())
				{
					var pp = new List<Products>();
					var sw = new Stopwatch();
					sw.Start();
					foreach (var item in items)
					{
						var p = new Products()
						{
							ProductID = item.ProductID,
							ProductName = item.ProductName,
							UnitPriceHUF = item.UnitPriceHUF,
							Category = item.Category
						};
						pp.Add(p);
					}
					db.BulkInsert(pp);
					db.SaveChanges();
					sw.Stop();
					Debug.WriteLine(sw.ElapsedMilliseconds.ToString());
					sometime.Add(sw.ElapsedMilliseconds);
				}
			}
			//Write TXT//
			using (var streamw = new StreamWriter("100_load_mssql.txt"))
			{
				foreach (var item in sometime)
				{
					streamw.WriteLine(item);
				}
				streamw.Close();
			}
			LoadProgressText.Text = "Nothing in Progress";
			MessageBox.Show("Finished");
		}

		private void mssql_1000migrate_Click(object sender, EventArgs e)
		{
			LoadProgressText.Text = "MsSQL 1000 Load in Progress";
			//Read Files//
			var path = firstPath.Text;
			var row = string.Empty;
			var products = new List<Product>();
			using (var fs = new FileStream(path, FileMode.Open))
			using (var sr = new StreamReader(fs, Encoding.UTF8))
			{
				while (null != (row = sr.ReadLine()))
				{
					var pieces = row.Split(';');
					var p = new Product()
					{
						ProductID = int.Parse(pieces[0]),
						ProductName = pieces[1],
						UnitPriceHUF = int.Parse(pieces[2]),
						Category = pieces[3]
					};
					products.Add(p);
				}

			}
			//Load Database//
			var sometime = new List<long>();

			for (int i = 0; i < products.Count; i = i + 1000)
			{
				var items = products.Skip(i).Take(1000);
				using (var db = new TesztEntities())
				{
					var pp = new List<Products>();
					var sw = new Stopwatch();
					sw.Start();
					foreach (var item in items)
					{
						var p = new Products()
						{
							ProductID = item.ProductID,
							ProductName = item.ProductName,
							UnitPriceHUF = item.UnitPriceHUF,
							Category = item.Category
						};
						pp.Add(p);
					}
					db.BulkInsert(pp);
					db.SaveChanges();
					sw.Stop();
					Debug.WriteLine(sw.ElapsedMilliseconds.ToString());
					sometime.Add(sw.ElapsedMilliseconds);
				}
			}
			//Write TXT//
			using (var streamw = new StreamWriter("1000_load_mssql.txt"))
			{
				foreach (var item in sometime)
				{
					streamw.WriteLine(item);
				}
				streamw.Close();
			}
			LoadProgressText.Text = "Nothing in Progress";
			MessageBox.Show("Finished");
		}

		private async void mongodb_100migrate_Click(object sender, EventArgs e)
		{
			LoadProgressText.Text = "MongoDB 100 Load in Progress";
			//Read Files//
			var path = secondPath.Text;
			var row = string.Empty;
			var products = new List<MongoProduct>();
			using (var fs = new FileStream(path, FileMode.Open))
			using (var sr = new StreamReader(fs, Encoding.UTF8))
			{
				while (null != (row = sr.ReadLine()))
				{
					var pieces = row.Split(';');
					var p = new MongoProduct()
					{
						ProductID = int.Parse(pieces[0]),
						ProductName = pieces[1],
						UnitPriceHUF = int.Parse(pieces[2]),
						Category = pieces[3]
					};
					products.Add(p);
				}

			}
			//Load Database//
			var client = new MongoClient("mongodb://localhost:27017");
			var database = client.GetDatabase("demo");
			var collec = database.GetCollection<BsonDocument>("Products");
			var sometime = new List<long>();

			for (int i = 0; i < products.Count; i = i + 100)
			{
				var items = products.Skip(i).Take(100);
				var sw = new Stopwatch();
				var EmptyInfoArray = new List<BsonDocument>();
				sw.Start();
				foreach (var item in items)
				{
					var document = new BsonDocument {
					{ "_id",item.ProductID},
					{ "ProductName",item.ProductName  },
					{ "UnitPriceHUF",item.UnitPriceHUF },
					{ "Category",item.Category }
					};
					EmptyInfoArray.Add(document);
				}
				await collec.InsertManyAsync(EmptyInfoArray);
				sw.Stop();
				Debug.WriteLine(sw.ElapsedMilliseconds.ToString());
				sometime.Add(sw.ElapsedMilliseconds);
			}
			//Write TXT//
			using (var streamw = new StreamWriter("100_load_mongodb.txt"))
			{
				foreach (var item in sometime)
				{
					streamw.WriteLine(item);
				}
				streamw.Close();
			}
			LoadProgressText.Text = "Nothing in Progress";
			MessageBox.Show("Finished");
		}

		private async void mongodb_1000migrate_Click(object sender, EventArgs e)
		{
			LoadProgressText.Text = "Mongo 1000 Load in Progress";
			//Read Files//
			var path = secondPath.Text;
			var row = string.Empty;
			var products = new List<MongoProduct>();
			using (var fs = new FileStream(path, FileMode.Open))
			using (var sr = new StreamReader(fs, Encoding.UTF8))
			{
				while (null != (row = sr.ReadLine()))
				{
					var pieces = row.Split(';');
					var p = new MongoProduct()
					{
						ProductID = int.Parse(pieces[0]),
						ProductName = pieces[1],
						UnitPriceHUF = int.Parse(pieces[2]),
						Category = pieces[3]
					};
					products.Add(p);
				}

			}
			//Load Database//
			var client = new MongoClient("mongodb://localhost:27017");
			var database = client.GetDatabase("demo");
			var collec = database.GetCollection<BsonDocument>("Products");
			var sometime = new List<long>();

			for (int i = 0; i < products.Count; i = i + 1000)
			{
				var items = products.Skip(i).Take(1000);
				var sw = new Stopwatch();
				var EmptyInfoArray = new List<BsonDocument>();
				sw.Start();
				foreach (var item in items)
				{
					var document = new BsonDocument {
					{ "_id",item.ProductID},
					{ "ProductName",item.ProductName  },
					{ "UnitPriceHUF",item.UnitPriceHUF },
					{ "Category",item.Category }
					};
					EmptyInfoArray.Add(document);
				}
				await collec.InsertManyAsync(EmptyInfoArray);
				sw.Stop();
				Debug.WriteLine(sw.ElapsedMilliseconds.ToString());
				sometime.Add(sw.ElapsedMilliseconds);
			}
			//Write TXT//
			using (var streamw = new StreamWriter("1000_load_mongodb.txt"))
			{
				foreach (var item in sometime)
				{
					streamw.WriteLine(item);
				}
				streamw.Close();
			}
			LoadProgressText.Text = "Nothing in Progress";
			MessageBox.Show("Finished");
		}

		private void mssqlq_load_Click(object sender, EventArgs e)
		{
			using (var con = new SqlConnection("Server=.\\sqlexpress2017;Database=Teszt;Trusted_Connection=True"))
			{
				var sw = new Stopwatch();
				sw.Start();
				var sqlCmd = new SqlCommand();
				sqlCmd.Connection = con;
				sqlCmd.CommandType = CommandType.Text;
				sqlCmd.CommandText = "SELECT o.OrderID,p.ProductID,p.ProductName,cu.Date," +
									 "ct.CurrencyType,c.CustomerCity FROM Orders o " +
									 "inner join Customers c on c.CustomerID=o.CustomerID " +
									 "inner join Products p on p.ProductID=o.ProductID " +
									 "inner join Currency cu on cu.CurrencyID=o.CurrencyID " +
									 "inner join CurrencyT ct on ct.CurrencyTID=cu.CurrencyTID";
				var sqlDataApp = new SqlDataAdapter(sqlCmd);
				var dtRec = new DataTable();
				sqlDataApp.Fill(dtRec);
				dataGridView1.DataSource = dtRec;
				sw.Stop();
				mssq_load_text.Text = "Completed in " + sw.ElapsedMilliseconds.ToString() + " ms";

			}
		}

		private async void mongodb_load_Click(object sender, EventArgs e)
		{
			var client = new MongoClient("mongodb://localhost:27017");
			var database = client.GetDatabase("demo");
			var collec2 = database.GetCollection<BsonDocument>("Orders");
			var sw = new Stopwatch();
			sw.Start();
			var res2 = await collec2.Aggregate()
									.Lookup("Products", "ProductID", "_id", "prod-order")
									.Lookup("Customers", "CustomerID", "_id", "cus-order")
									.Lookup("Currency", "CurrencyID", "_id", "curr-order")
									.Lookup("CurrencyT", "curr-order.CurrencyTID", "_id", "curr-currt")
									.Unwind("prod-order")
									.Unwind("cus-order")
									.Unwind("curr-order")
									.Unwind("curr-currt")
									.Project("{ProductID:1,'ProductName':'$prod-order.ProductName','Date':'$curr-order.Date','CurrencyType':'$curr-currt.CurrencyType','CustomerCity':'$cus-order.CustomerCity'}").ToListAsync();
			

			var fl = new List<MongoResult>();

			foreach (var item in res2)
			{
				var c = new MongoResult();
				c.OrderID = item[0].AsDouble;
				c.ProductID = item[1].AsDouble;
				c.ProductName = item[2].AsString;
				c.Date = item[3].AsString;
				c.CurrencyType = item[4].AsString;
				c.CustomerCity = item[5].AsString;
				fl.Add(c);
			}

			dataGridView2.DataSource = fl;
			sw.Stop();
			mongo_load_text.Text = "Competed in " + sw.ElapsedMilliseconds.ToString() + " ms";
		}

		public class MongoResult
		{
			public double OrderID { get; set; }
			public double ProductID { get; set; }
			public string ProductName { get; set; }
			public string Date { get; set; }
			public string CurrencyType { get; set; }
			public string CustomerCity { get; set; }
		}

	}
}
