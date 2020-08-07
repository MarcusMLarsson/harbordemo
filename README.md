<h1> Göteborgs hamn - Förslag på demo-arkitektur</h1>


<h3> <a href="https://docs.microsoft.com/en-us/azure/stream-analytics/stream-analytics-introduction"> Förslag 1:  End-to-end serverless streaming platform with Azure Stream Analytics </a></h3>  
<p align="center"><img src="https://docs.microsoft.com/en-us/azure/stream-analytics/media/stream-analytics-introduction/stream-analytics-e2e-pipeline.png" width="1200"></p>

- [x] <b>Implementering och etablering av en molnbaserad tjänst</b>
<br>Vi använder oss utav Microsoft Azure
- [x] <b>Tjänsten skall vara skalbar</b>
<br>Event Hub/IoT Hub är skalbar, kan processa upp till gb/s, använder Kafka protokoll
- [x] <b>Tjänsten skall inkludera behörighets- och rollstyrd åtkomst</b>
<br>Microsoft Azure stödjer behörighets- och rollstyrd åtkomst (Azure active directory - AD, role based access control - RBAC, shared access signatures - SAS)
- [x] <b>Insamling och kvalitetssäkring av minst tre separata datakällor</b>
<br> Finns möjlighet att joina flera datakällor till ett streaming event. Går också att skriva data till flera outputs.
- [x] <b>Sammanställ och presentera statistik och data till relevanta KPI:er</b>
<br> Datan skickas till Power BI där den kan sammanställas och visualiseras
- [x] <b>Presentera realtidssanningar på ett lättillgängligt, användarvänligt, skalbart, säkert och rollbaserat vis</b>
<br>Power BI har support for realtidsdata, är användarvänligt, skalbart och har support för rollstyrd åtkomst
- [ ] <b>Skapa mening och ”smartifiera” aktuella realtidsdata med hjälp av innovativ teknik såsom AI, IoT m.m för prediktion (exempelvis ETA)</b>
<br>Går att använda Azure ML service? Databricks borde vara en bättre lösning

  
<h3> <a href="https://docs.microsoft.com/en-us/azure/architecture/solution-ideas/articles/real-time-analytics"> Förslag 2: Real Time Analytics on Big Data Architecture </a></h3> 
 
<p align="center"><img src="https://docs.microsoft.com/sv-se/azure/architecture/solution-ideas/media/real-time-analytics.png"></p>

- [x] <b>Implementering och etablering av en molnbaserad tjänst</b>
<br>Vi använder oss utav Microsoft Azure
- [x] <b>Tjänsten skall vara skalbar</b>
<br>Event Hub/IoT Hub är skalbar, kan processa upp till gb/s, använder Kafka protokoll
- [x] <b>Tjänsten skall inkludera behörighets- och rollstyrd åtkomst</b>
<br>Microsoft Azure stödjer behörighets- och rollstyrd åtkomst (Azure active directory - AD, role based access control - RBAC, shared access signatures - SAS)
- [x] <b>Insamling och kvalitetssäkring av minst tre separata datakällor</b>
<br> Finns möjlighet att joina flera datakällor till ett streaming event. Går också att skriva data till flera outputs.
- [x] <b>Sammanställ och presentera statistik och data till relevanta KPI:er</b>
<br> Datan skickas till Power BI där den kan sammanställas och visualiseras
- [x] <b>Presentera realtidssanningar på ett lättillgängligt, användarvänligt, skalbart, säkert och rollbaserat vis</b>
<br>Power BI har support for realtidsdata, är användarvänligt, skalbart och har support för rollstyrd åtkomst
- [ ] <b>Skapa mening och ”smartifiera” aktuella realtidsdata med hjälp av innovativ teknik såsom AI, IoT m.m för prediktion (exempelvis ETA)</b>
<br>Går att använda Azure ML service? Databricks borde vara en bättre lösning



<br>
<br>
<br>
<br>
<hr>






<p align="center"><img src="https://docs.microsoft.com/en-us/azure/architecture/solution-ideas/media/streaming-using-hdinsight.png"></p>


