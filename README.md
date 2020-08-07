<h1> Göteborgs hamn - Förslag på demo-arkitektur</h1>


<h3> <a href="https://docs.microsoft.com/en-us/azure/stream-analytics/stream-analytics-introduction"> Förslag 1:  End-to-end serverless streaming platform with Azure Stream Analytics </a></h3>  
<p align="center"><img src="https://docs.microsoft.com/en-us/azure/stream-analytics/media/stream-analytics-introduction/stream-analytics-e2e-pipeline.png" width="1200"></p>

<h4> Innehåll </h4>

| Resurs       | Förklaring      |
| ------------- |:-------------:|
| <p align="left">Event/IoT Hub </p>   |  <p align="left">En big data strömningsplattform och händelseinmatningstjänst. Kan ta emot och behandla miljoner händelser per sekund. Kan ta emot realtidsdata eller batchdata. Är Kafka kompatibel.</p>  |
|  <p align="left">Azure Stream Analytics </p>    |  <p align="left">Azure Stream Analytics är en event-processing engine som kan processa och bearbeta stora mängder realtidsdata från flera källor samtidigt.</p>|
|  <p align="left">Azure ML service </p>   |  <p align="left">En molnbaserad miljö som du kan använda för att träna, distribuera, automatisera och hantera ML-modeller. Är dock inte lika skalbar som Spark & Databricks.</p> |     

<h4> Krav </h4>

- [x] <b>Implementering och etablering av en molnbaserad tjänst</b>
<br>Microsoft Azure
- [x] <b>Tjänsten skall vara skalbar</b>
<br>Event Hub/IoT Hub är skalbar, kan processa upp till gb/s
- [x] <b>Tjänsten skall inkludera behörighets- och rollstyrd åtkomst</b>
<br>Microsoft Azure stödjer behörighets- och rollstyrd åtkomst (Azure active directory - AD, role based access control - RBAC, shared access signatures - SAS)
- [x] <b>Insamling och kvalitetssäkring av minst tre separata datakällor</b>
<br> Finns möjlighet att använda och joina flera datakällor till ett streaming event. Går också att skriva data till flera outputs.
- [x] <b>Sammanställ och presentera statistik och data till relevanta KPI:er</b>
<br> Datan skickas till Power BI där den kan sammanställas och visualiseras
- [x] <b>Presentera realtidssanningar på ett lättillgängligt, användarvänligt, skalbart, säkert och rollbaserat vis</b>
<br>Power BI har support for realtidsdata, är användarvänligt, skalbart och har support för rollstyrd åtkomst
- [ ] <b>Skapa mening och ”smartifiera” aktuella realtidsdata med hjälp av innovativ teknik såsom AI, IoT m.m för prediktion (exempelvis ETA)</b>
<br>Går att använda Azure ML service? Databricks är en bättre lösning?
 
<h3> <a href="https://docs.microsoft.com/en-us/azure/architecture/solution-ideas/articles/real-time-analytics"> Förslag 2: Real Time Analytics on Big Data Architecture </a></h3> 
 
<p align="center"><img src="https://docs.microsoft.com/sv-se/azure/architecture/solution-ideas/media/real-time-analytics.png"></p>


<h4> Innehåll </h4>

| Resurs       | Förklaring      |
| ------------- |:-------------:|
| <p align="left">Azure HDInsight</p>   |  <p align="left">Azure HDInsight är Hortonworks Hadoop i Azure (molnet) och stödjer skapandet av Hadoop-kluster genom Linux och Ubunti. HDinsight innehåller bland annat Apache Spark, Apache Kafka, Apache Hive, Apache HBase mm.</p>  |
|  <p align="left">Apache Kafka</p>   |  <p align="left"> Apache Kafka är en distributerad event streaming paltform. Apache Kafka är en del av Hadoop ecosystemet.</p>|
|  <p align="left">Apache Spark</p>  |  <p align="left"> genom parallel bearbetning (kluster) kan Apache Spark bprocessa stora mängder data. </p>|
|  <p align="left">Azure Databricks</p>    |  <p align="left">Azure Databricks är en samarbetsplattform där dataingenjörer och data scientiest kan arbeta med maskininlärning, dataanalys, AI etc. Databricks använder sig av Apache Spark för att processa data.  </p> |   

<h4> Krav </h4>

- [x] <b>Implementering och etablering av en molnbaserad tjänst</b>
<br>Vi använder oss utav Microsoft Azure
- [x] <b>Tjänsten skall vara skalbar</b>
<br> Kafka är väldigt skalbar, om en node crashar tillåter kafka automatisk återhämtning
- [x] <b>Tjänsten skall inkludera behörighets- och rollstyrd åtkomst</b>
<br>Microsoft Azure stödjer behörighets- och rollstyrd åtkomst (Azure active directory - AD, role based access control - RBAC, shared access signatures - SAS)
- [x] <b>Insamling och kvalitetssäkring av minst tre separata datakällor</b>
<br> Finns möjlighet att använda och joina flera datakällor till ett streaming event. Går också att skriva data till flera outputs.
- [x] <b>Sammanställ och presentera statistik och data till relevanta KPI:er</b>
<br> Datan skickas till Power BI där den kan sammanställas och visualiseras
- [x] <b>Presentera realtidssanningar på ett lättillgängligt, användarvänligt, skalbart, säkert och rollbaserat vis</b>
<br>Power BI har support for realtidsdata, är användarvänligt, skalbart och har support för rollstyrd åtkomst
- [x] <b>Skapa mening och ”smartifiera” aktuella realtidsdata med hjälp av innovativ teknik såsom AI, IoT m.m för prediktion (exempelvis ETA)</b>
<br> Med hjälp av spark har vi tillgång till parallel processing för ML, AI, Deep learning, big data,  etc. Databricks miljön faciliterar sammarbete mellan data analytiker. 
