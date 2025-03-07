using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System;
using Investing.Models;
using System.Collections.Generic;

namespace Investing.Services
{
    public class StockMoexApi
    {
        private readonly HttpClient _httpClient;

        public StockMoexApi(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        internal async Task<List<Security>> GetStocksAsync()
        {
            var stocks = new List<Security>();

            // URL для получения данных по акциям
            string url = "https://iss.moex.com/iss/engines/stock/markets/shares/boards/TQBR/securities.json?iss.meta=off&iss.json=extended&limit=100";

            try
            {
                // Выполняем запрос к API
                HttpResponseMessage response = await _httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    // Читаем ответ как строку
                    string responseData = await response.Content.ReadAsStringAsync();

                    // Парсим JSON
                    using (JsonDocument doc = JsonDocument.Parse(responseData))
                    {
                        JsonElement root = doc.RootElement;

                        // Получаем данные по акциям
                        JsonElement securities = root[1].GetProperty("securities");
                        JsonElement marketdata = root[1].GetProperty("marketdata");

                        // Обрабатываем данные
                        for (int i = 0; i < securities.GetArrayLength(); i++)
                        {
                            var stock = new Security
                            {
                                SECID = securities[i].GetProperty("SECID").GetString(),
                                SHORTNAME = securities[i].GetProperty("SHORTNAME").GetString(),
                                PREVPRICE = (float?)securities[i].GetProperty("PREVPRICE").GetDouble()
                            };
                            stocks.Add(stock);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Логируем ошибку (можно добавить логирование)
                Console.WriteLine($"Ошибка при получении данных: {ex.Message}");
            }
            return stocks;
        }

        internal async Task<List<StockMoexUnion>> UnionImageStockAsync()
        {
            var listUnion = new List<StockMoexUnion>();
            var listStocks = await GetStocksAsync();
            var l = new List<StockMoexUnion>()
            {
                new StockMoexUnion
                {
                 //   SecId = listStocks
                }
            };
            return listUnion;
        }
    }
}