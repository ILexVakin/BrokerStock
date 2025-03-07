﻿namespace Investing.Models
{
    public class StockMoex
    {
        public MainMoex[] MainMoex { get; set; }
    }


    public class MainMoex
    {
        public Charsetinfo charsetinfo { get; set; }
        public Security[] securities { get; set; }
        public Marketdata[] marketdata { get; set; }
        public Dataversion[] dataversion { get; set; }
        public object[] marketdata_yields { get; set; }
    }

    public class Charsetinfo
    {
        public string name { get; set; }
    }

    public class Security
    {
        public string SECID { get; set; }
        public string BOARDID { get; set; }
        public string SHORTNAME { get; set; }
        public float? PREVPRICE { get; set; }
        public int LOTSIZE { get; set; }
        public float FACEVALUE { get; set; }
        public string STATUS { get; set; }
        public string BOARDNAME { get; set; }
        public int DECIMALS { get; set; }
        public string SECNAME { get; set; }
        public object REMARKS { get; set; }
        public string MARKETCODE { get; set; }
        public string INSTRID { get; set; }
        public object SECTORID { get; set; }
        public float MINSTEP { get; set; }
        public float? PREVWAPRICE { get; set; }
        public string FACEUNIT { get; set; }
        public string PREVDATE { get; set; }
        public long ISSUESIZE { get; set; }
        public string ISIN { get; set; }
        public string LATNAME { get; set; }
        public string REGNUMBER { get; set; }
        public float? PREVLEGALCLOSEPRICE { get; set; }
        public string CURRENCYID { get; set; }
        public string SECTYPE { get; set; }
        public int LISTLEVEL { get; set; }
        public string SETTLEDATE { get; set; }
    }

    public class Marketdata
    {
        public string SECID { get; set; }
        public string BOARDID { get; set; }
        public object BID { get; set; }
        public object BIDDEPTH { get; set; }
        public object OFFER { get; set; }
        public object OFFERDEPTH { get; set; }
        public int SPREAD { get; set; }
        public int BIDDEPTHT { get; set; }
        public int OFFERDEPTHT { get; set; }
        public float? OPEN { get; set; }
        public float? LOW { get; set; }
        public float? HIGH { get; set; }
        public float? LAST { get; set; }
        public int LASTCHANGE { get; set; }
        public int LASTCHANGEPRCNT { get; set; }
        public int QTY { get; set; }
        public float VALUE { get; set; }
        public float VALUE_USD { get; set; }
        public float? WAPRICE { get; set; }
        public int LASTCNGTOLASTWAPRICE { get; set; }
        public float WAPTOPREVWAPRICEPRCNT { get; set; }
        public float WAPTOPREVWAPRICE { get; set; }
        public object CLOSEPRICE { get; set; }
        public float? MARKETPRICETODAY { get; set; }
        public float? MARKETPRICE { get; set; }
        public float LASTTOPREVPRICE { get; set; }
        public int NUMTRADES { get; set; }
        public long VOLTODAY { get; set; }
        public long VALTODAY { get; set; }
        public int VALTODAY_USD { get; set; }
        public object ETFSETTLEPRICE { get; set; }
        public string TRADINGSTATUS { get; set; }
        public string UPDATETIME { get; set; }
        public object LASTBID { get; set; }
        public object LASTOFFER { get; set; }
        public float? LCLOSEPRICE { get; set; }
        public float? LCURRENTPRICE { get; set; }
        public float? MARKETPRICE2 { get; set; }
        public object NUMBIDS { get; set; }
        public object NUMOFFERS { get; set; }
        public float? CHANGE { get; set; }
        public string TIME { get; set; }
        public object HIGHBID { get; set; }
        public object LOWOFFER { get; set; }
        public float? PRICEMINUSPREVWAPRICE { get; set; }
        public float? OPENPERIODPRICE { get; set; }
        public long SEQNUM { get; set; }
        public string SYSTIME { get; set; }
        public float? CLOSINGAUCTIONPRICE { get; set; }
        public int? CLOSINGAUCTIONVOLUME { get; set; }
        public float? ISSUECAPITALIZATION { get; set; }
        public string ISSUECAPITALIZATION_UPDATETIME { get; set; }
        public object ETFSETTLECURRENCY { get; set; }
        public long VALTODAY_RUR { get; set; }
        public object TRADINGSESSION { get; set; }
        public float TRENDISSUECAPITALIZATION { get; set; }
    }

    public class Dataversion
    {
        public int data_version { get; set; }
        public long seqnum { get; set; }
    }

}

