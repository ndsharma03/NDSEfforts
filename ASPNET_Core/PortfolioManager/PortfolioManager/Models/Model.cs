using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Models
{


    public class Portfolio
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }

        public int CreatedBy { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; }

        public int ModifiedBy { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime ModifiedDate { get; set; }

        public List<PortfolioStock> Stocks { get; set; }

    }

    public class PortfolioStock
    {
        public int Id { get; set; }
        public int StockId { get; set; }
        public Stock Stock { get; set; }

        public int PortfolioId { get; set; }

        public Portfolio Portfolio { get; set; }
    }
    public class AssetClass
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }

        public List<Category> Categories { get; set; }
    }
    public class Category
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }

        public int AssetClassId { get; set; }

        public AssetClass AssetClass { get; set; }
        public List<Stock> Stocks { get; set; }
    }
    public class Broker
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }

        public List<StockBroker> BrokerStocks {get;set;}
    }
   

    public class Stock
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string ISIN { get; set; }
        [MaxLength(100)]
        public string Symbol { get; set; }
        [MaxLength(100)]
        public string CompanyName { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public List<StockBroker> StockBrokers { get; set; }

        public List<Rate> Rates { get; set; }

       public List<PortfolioStock> Portfolios { get; set; }
    }

    public class StockBroker {
        public int Id { get; set; }
        public int StockId{ get; set; }
        public Stock Stock { get; set; }
        public int BrokerId { get; set; }

        public Broker Broker { get; set; }

    }
   public class Rate
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        public int StockId { get; set; }
        public Stock Stock { get; set; }

        public int Qty { get; set; }
    }

   public class RateHistory
    {public int Id { get; set; }
        [MaxLength(100)]
        public string Symbol { get; set; }
        [MaxLength(50
            )]
        public string Series { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }
        public decimal PrevClose { get; set; }
        public decimal OpenPrice { get; set; }
        public decimal HighPrice { get; set; }
        public decimal LowPrice { get; set; }
        public decimal LastPrice { get; set; }

        public decimal ClosePrice { get; set; }

        public int TotalTrade { get; set; }
        public int Quantity{ get; set; }

        public string VWAP { get; set; }
        public decimal Turnover { get; set; }
        public int NoOfTrades { get; set; }


     
    }    
 }

/*
 * 
 * www.nseindia.com/content/historical/EQUITIES/2019/DEV/cm27DEC2019bhav.csv.zip








Rate
	Symbol
	price
	date

RateHistory
	Symbol	
	Series	
	Date	
	PrevClose	
	OpenPrice	
	HighPrice	
	LowPrice	
	LastPrice	
	ClosePrice	
	VWAP	
	TotalTraded
	Quantity	
	Turnover	
	NoOfTrades

 */
