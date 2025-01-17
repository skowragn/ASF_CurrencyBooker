# Azure Service Fabric - Currency Manager

## 1. Azure Service Fabric Overview
Azure Service Fabric is a distributed systems platform used to build hyper-scalable, reliable and easily managed applications for the cloud.

Nowadays it powers many Azure Cloud and Microsoft services.

![image](https://user-images.githubusercontent.com/97020391/151328873-d70de507-f41d-4090-88a9-70e877ef8cee.png)

***Figure 1. Azure Service Fabric - Azure services based on ASF***

More details: https://docs.microsoft.com/en-us/azure/service-fabric/


- Azure SQL Database
- Azure Cosmos DB
- Azure IoT Hub
- Azure Event Hub
- Skype
- Cortana
- Intune
- Dynamics
- Power BI
- Azure Database for MySQL
- Azure Database for PostgreSQL
- Azure Container Registry
- Azure Event Grid
- Azure Stream Analytics
- Azure DevOps (formerly Visual Studio Team Services)
- Azure Monitor
- Core Azure Services
- Azure Archive Storage


![image](https://user-images.githubusercontent.com/97020391/151329150-a071d8d0-a540-43b9-b01d-250f5526c4d9.png)

***Figure 2. Azure Service Fabric - Architecture***

References: https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-architecture

## 2. Azure Service Fabric Version
https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-get-started
![image](https://user-images.githubusercontent.com/97020391/147914744-e0bc9a27-fc21-42ad-85fa-dca359a0afc4.png)
![image](https://user-images.githubusercontent.com/97020391/147914751-bbf35faa-3563-4ee2-8b3b-e8a298d063eb.png)

***Figure 3. Azure Service Fabric - Runtime, SDK and Tools***

More details: https://techcommunity.microsoft.com/t5/azure-service-fabric-blog/azure-service-fabric-8-2-first-refresh-release/ba-p/3040415 

## 3. Azure Service Fabric - programming model
Azure Service Fabric cluster is on .NET Framework 4.8. 
It can run the folowing services/processes:
- Reliable service (stateful and stateless) with .NET 6.0
- ASP.NET Core services (stateful and stateless) with  ASP.NET Core 5/.NET 5 (Web API, MVC, with Angular/React etc.)
- Reliable Actors (reliable stateful services) with .NET Framework 4.8
- Guest executable - self-contained applications (e.g. NodeJS or Java)
- Containers (with Docker image)

More details: https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-choose-framework

![image](https://user-images.githubusercontent.com/97020391/151333252-13f99c2b-bff9-49ce-8591-20245af6d92f.png)

***Figure 4. Azure Service Fabric***

More details: https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-application-scenarios

### 3.1 Azure Service Fabric - Application Model
![image](https://user-images.githubusercontent.com/97020391/151333428-f3d0842b-2bee-407d-b85f-013e3c3723d0.png)

![image](https://user-images.githubusercontent.com/97020391/151333530-9475cd89-2e5d-4969-8cc1-0e49a5982d9b.png)

***Figure 5. Azure Service Fabric - Application Model Big picture***

References: https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-content-roadmap

![image](https://user-images.githubusercontent.com/97020391/151762619-77b308de-1426-4159-8210-516000c17356.png)
![image](https://user-images.githubusercontent.com/97020391/151762643-ca8957dd-32aa-4aa4-8f55-7f2ca7894ff6.png)

***Figure 6. Azure Service Fabric - Application Version***

### 3.2 Azure Service Fabric - Visual Studio 2022

![image](https://user-images.githubusercontent.com/97020391/147924407-06b5a7e8-4f3d-496d-b8e9-517c8a3c9d4a.png)

![image](https://user-images.githubusercontent.com/97020391/147924413-d379d964-cc11-409f-92f6-915ebd3e913d.png)

![image](https://user-images.githubusercontent.com/97020391/147924424-1deed3bd-8c90-4152-89eb-a9d6600dd1f1.png)

***Figure 7. Azure Service Fabric - Visual Studio 2022***

### 3.3 Azure Service Fabric - several application version on one cluster
![image](https://user-images.githubusercontent.com/97020391/148247465-d8521023-6e74-447e-8469-74aa90923d2a.png)

***Figure 8. Azure Service Fabric - Application Version on Azure Service Fabric Cluster Explorer***

### 3.4 Azure Service Fabric - monitoring and diagnostic
- Application Monitoring
- Cluster Monitoring
- Infrustructure Monitoring


### 3.5 Azure Service Fabric - Reference Architecture

![image](https://user-images.githubusercontent.com/97020391/151762960-14406e4f-5944-4c51-98f2-566c134706cd.png)

***Figure 9. Azure Service Fabric - Reference Architecture***

References: https://docs.microsoft.com/en-us/azure/architecture/reference-architectures/microservices/service-fabric



## 4. Currency Manager project
### 4.1 Prerequisites
- Visual Studio 2022 Pro: https://visualstudio.microsoft.com/pl/vs/
- Git: https://git-scm.com/
- Azure Service Fabric SDK and Tools: https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-get-started

Version: https://github.com/skowragn/ASF_CurrencyBooker/blob/main/README.md#2-azure-service-fabric-version

The Currency Manager based on the Quickstart with MS (Voting/.NET Framework 4.7.2): https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-quickstart-dotnet  
Azure-Samples/\service-fabric-dotnet-quickstart: https://github.com/Azure-Samples/service-fabric-dotnet-quickstart

### 4.2 Project Overview
The current project is based on the Azure Service Fabric Application Model (ASP.NET Core stateful and stateless services).
It consists of:

- One Azure Service Fabric application - Currency Manager

It has the following elements:

- Stateful ASP.NET Core 5 Web API service - **CountriesService**
- Stateful ASP.NET Core 5 Web API service  - **CurrencyManagerService**
- Stateless ASP.NET Core 5 MVC service - **CurrencyManagerWeb**


![image](https://user-images.githubusercontent.com/97020391/151197774-310d2a52-02e9-42c2-be6e-154c2851ea2d.png)

***Figure 10. Currency Manager Application Logical Architecture***

![image](https://user-images.githubusercontent.com/97020391/147924520-5f7c8eff-4792-4948-af1a-25310d23812a.png)

***Figure 11. Azure Service Fabric cluster overview***

![image](https://user-images.githubusercontent.com/97020391/147941627-68bece4c-9695-49ea-909f-e380b2303700.png)

***Figure 12. Visual Studio 2022 Service Fabric Application solution overview***

**CountriesService Stateful** |  | 
--- | --- 
PartitionCount| 1 |
MinReplicaSetSize| 1 |
TargetReplicaSetSize| 1 |

**CurrencyManagerService Stateful** |  | 
--- | --- 
PartitionCount| 3 |
MinReplicaSetSize| 1 |
TargetReplicaSetSize| 3 |

**CurrencyManagerWeb Stateless** |  | 
--- | --- 
InstanceCount| 1 |

**Cluster** |**Nodes** | **Application** | **Services** | **Partitions** |  **Replicas** | 
--- | --- | ---| ---| ---| ---
| | 5 | 1 | 3 | 5 | 11 (1*1 + 3*3 + 1)

![image](https://user-images.githubusercontent.com/97020391/151776700-c2890358-911c-40e8-8a48-5378c5ddec68.png)

***Figure 13. Local Service Fabric Currency Manager configuration with Azure Service Fabric***

![image](https://user-images.githubusercontent.com/97020391/147924511-d1b70def-0043-42f6-8c44-99410460cece.png)

***Figure 14. Currency Manager Application Version***

### 4.1. Currency Manager – ApplicationManifest.xml

![image](https://user-images.githubusercontent.com/97020391/147942280-2e4607b2-bb2b-47f4-b04e-9662e430344b.png)

***Figure 15. Currency Manager configuration - ApplicationManifest.xml***

### 4.2. Currency Manager project - StartupServices.xml
![image](https://user-images.githubusercontent.com/97020391/147943399-f501e09e-4b61-4f5b-bb43-f82234626f99.png)

***Figure 16. Currency Manager configuration - StartupServices.xml***

### 4.3. Currency Manager – LocalNode5.xml
![image](https://user-images.githubusercontent.com/97020391/147942487-c441b900-05e2-4148-a71f-98ada239c2d5.png)

***Figure 17. Currency Manager configuration - LocalNode5.xml***

![image](https://user-images.githubusercontent.com/97020391/151354539-f26f68f1-ab03-4438-8c74-043f1d53d4cd.png)

***Figure 18. Application Local Cluster overview***

![image](https://user-images.githubusercontent.com/97020391/151370595-50a6426a-a564-4055-94a9-bf70e3c64332.png)

***Figure 19. Application Local Cluster - particions and replicas with 5 Nodes Cluster***

![image](https://user-images.githubusercontent.com/97020391/151370526-95a49f6a-5dfa-4246-a599-e05dfdb216d5.png)

***Figure 20. Application Local Cluster - particions and replicas with 5 Nodes Cluster - with Primary and Secondary replicas details***

### 4.4. CurrencyManagerWeb - ASP.NET Core Stateless service
![image](https://user-images.githubusercontent.com/97020391/147942555-2f84c4ff-0a5f-4467-bcc2-a9855241d8c3.png)
![image](https://user-images.githubusercontent.com/97020391/147942570-a2ba5d61-cdf6-4c0c-bbd9-c87d42a8261e.png)

***Figure 21. Currency Manager - ASP.NET Core 5 MVC stateless reliable service***


### 4.5. CurrencyManagerService - ASP.NET Core Stateful service
![image](https://user-images.githubusercontent.com/97020391/147942628-0891782c-364d-4923-8db4-b4b49f3dcae7.png)
![image](https://user-images.githubusercontent.com/97020391/147942648-cd31596c-8738-4bbb-89ed-f9a300f44717.png)

***Figure 22. Currency Manager - ASP.NET Core 5 Web API stateful reliable service***

### 4.6. Currency Manager - Sum up

#### 4.6.1. CountriesService - Stateful Service

|     Parameter        | Number|
| -------------------- | ----- |
| PartitionCount       |     1 |
| MinReplicaSetSize    |     1 |
| TargetReplicaSetSize |     1 |


#### 4.6.2. CurrencyManagerService - Stateful Service

|     Parameter        | Number|
| -------------------- | ----- |
| PartitionCount       |     3 |
| MinReplicaSetSize    |     1 |
| TargetReplicaSetSize |     3 |


#### 4.6.3. CurrencyManagerWeb - Stateless Service

|     Parameter        | Number|
| -------------------- | ----- |
| InstanceCount        |     1 |


#### 4.6.4. Azure Service Fabric Cluster

![image](https://user-images.githubusercontent.com/97020391/147940564-44f77200-a1fe-40ef-b441-a567f38ed6b6.png)

***Figure 23. Azure Service Fabric managed cluster***

|     Parameter        | Number|
| -------------------- | ----- |
| Nodes                |     5 |
| Application          |     1 |
| Services             |     3 |
| Partitions           |     5 |
| Replicas             |    11 |


![image](https://user-images.githubusercontent.com/97020391/151201515-d169974e-6e88-4f8c-9352-942366e5e17b.png)

***Figure 24. Azure Service Fabric managed cluster with 5 Nodes***

#### 4.6.5. CurrencyManager - current solution

![image](https://user-images.githubusercontent.com/97020391/148247267-b1ccea4a-40fc-485d-b51b-15fda68977d2.png)

***Figure 25. Currency Manager Application - Home View***


![image](https://user-images.githubusercontent.com/97020391/148247310-3ad3ee20-3f2b-43cc-b390-3929e842f6b0.png)


***Figure 26. Currency Manager Application - Countries View***


![image](https://user-images.githubusercontent.com/97020391/148247324-d446b479-72b9-4dc3-a58c-6906f17fb559.png)

***Figure 27. Currency Manager Application - Currencies View***


------ Example Flow -----------------------------------------------------------------------------------------------
1. ***CurrencyManagerWeb*** -> Click on the **Countries** tab
2. ***CurrencyManagerWeb*** -> CountryListController -> Index 
3. ***CurrencyManagerWeb*** -> _countryListService.GetAsync()
4. ***CurrencyManagerWeb*** -> CountryListService

![image](https://user-images.githubusercontent.com/97020391/151806941-cb769ef4-56dd-443d-950e-b1fe32a21872.png)

***Figure 28. Currency Manager Application - CountryListService.cs (CurrencyManagerWeb)***

Note: CountriesService stateful service setup is only one partition, lowkey is 0 and highkey 99 (CurrencyManager -> StartupServices.xml)

More details and best particionig practises: https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-concepts-partitioning


5. ***CountriesService*** -> CountriesController -> GetAsync() -> _countryListService.GetAsync();
6.  ***CountriesService*** -> CountryListService -> GetAsync() -> _countriesRepository.GetCountriesAsync()
7.   ***CountriesService*** -> CountriesRepository -> GetCountriesAsync() -> call external service: https://restcountries.com/v3.1/all

-------------------------------------------------------------------------------------------------------------------
## 5. Deployemnt into Azure Cloud

### 5.1 Prerequisites
- Azure Cloud subscribtion with VS Subscription - 200$ per month
- Service Fabric managed clusters

Note:
- Service Fabric managed clusters are an evolution of the Azure Service Fabric cluster resource model

- The ARM template for a Service Fabric managed cluster is about 100 lines of JSON, versus some 1000 lines required to define a typical Service Fabric cluster

'The Azure Resource Model (ARM) template for traditional Service Fabric clusters requires you to define a cluster resource alongside a number of supporting resources, all of which must be "wired up" correctly in order for the cluster and your services to function properly. 
In contrast, the encapsulation model for Service Fabric managed clusters consists of a single, Service Fabric managed cluster resource. All of the underlying resources for the cluster are abstracted away and managed by Azure on your behalf.'

![image](https://user-images.githubusercontent.com/97020391/151338781-d0cdb4b3-3161-4684-ba9a-318107f012f0.png)

https://docs.microsoft.com/en-us/azure/service-fabric/overview-managed-cluster 



### 5.2 VS 2020 usage

![image](https://user-images.githubusercontent.com/97020391/151779104-d1afac9a-ef17-454b-a516-40989bfd42a6.png)

***Figure 29. Azure Service Cluster - managed cluster creation from VS 2022***

#### 5.2.1 Cloud.xml

![image](https://user-images.githubusercontent.com/97020391/151339033-bdc11e4f-72f6-46fe-bf98-af1c82b03602.png)

***Figure 30. Currency Manager configuration - Cloud.xml***

![image](https://user-images.githubusercontent.com/97020391/151339130-f3055db0-ed86-400d-aa02-bc66901f07ba.png)

***Figure 31. Currency Manager configuration - setup remote cluster in VS 2022***

![image](https://user-images.githubusercontent.com/97020391/151339149-4ad1b8fb-62c0-43e7-9209-ec31e566e792.png)

***Figure 32. Currency Manager configuration - services packages versions from application***

### 5.3 Azure Portal usage

![image](https://user-images.githubusercontent.com/97020391/151778734-37235dc7-f2a5-4341-ae8d-9bc1b693bd38.png)

***Figure 33. Currency Manager managed cluster creation - Azure Portal - ASF Cluster***

![image](https://user-images.githubusercontent.com/97020391/151338971-9d71b037-7884-49ed-9413-faddfbd0c466.png)

***Figure 34. Currency Manager managed cluster creation - Azure Portal - Azure Key vault setup for cluster certificates***

### 5.4 ARM Template usage

![image](https://user-images.githubusercontent.com/97020391/151342142-f0a135fa-e6e1-4533-8354-f9b19e21b069.png)
***Figure 35. Currency Manager cluster - ARM Template***


## 6. Cluster - Azure Cloud
![image](https://user-images.githubusercontent.com/97020391/151339893-12b4f460-2847-46fa-949f-b6afd1fe812e.png)
![image](https://user-images.githubusercontent.com/97020391/151339909-4eaad835-d760-47a7-a73e-c4d6d5415355.png)

***Figure 36. Currency Manager configuration - Azure Cloud remote cluster with 3 Nodes and supported services (e.g. Azure Key Vault, Azure Storages, LB etc.)***

![image](https://user-images.githubusercontent.com/97020391/151340012-6f6652ba-cc99-4b63-8f1d-a53efe8d8381.png)

***Figure 37. Currency Manager configuration - Azure Cloud remote cluster with 3 Nodes - Nodes***

![image](https://user-images.githubusercontent.com/97020391/151347863-1b7ae26d-b05f-4dcc-bd31-0d69da4de809.png)

***Figure 38. Currency Manager configuration - Azure Cloud remote cluster with 3 Nodes - Explorer***

Note: Service Fabric Explorer is using 19080 port:

e.g. http://localhost:19080/Explorer

e.g. https://currencymanager-cl-new.westeurope.cloudapp.azure.com:19080/Explorer


![image](https://user-images.githubusercontent.com/97020391/151353637-a2874b89-5f5b-4d48-b4c9-9a67361a3694.png)


***Figure 39. Azure Cloud cluster with 3 Nodes and deployed Currenct Manager application***


![image](https://user-images.githubusercontent.com/97020391/151353505-514783a1-1757-4623-815c-ea1483165fec.png)

***Figure 40. Currency Manager configuration - Azure Cloud remote cluster with 3 Nodes - Primary and Secondary replicas on 3 Nodes***

![image](https://user-images.githubusercontent.com/97020391/151340571-ab1b9178-2ea0-438b-bd9f-34960eb62136.png)

***Figure 41. Currency Manager cluster - on Azure Cloud***

## 7. Azure Service Fabric or Kubernetes 
More details:
https://www.ben-morris.com/azure-service-fabric-kubernetes/
https://techcommunity.microsoft.com/t5/azure-developer-community-blog/service-fabric-and-kubernetes-community-comparison-part-1-8211/ba-p/337421 

## 8. References

https://docs.microsoft.com/en-us/azure/service-fabric/

https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-connect-and-communicate-with-services

https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-application-scenarios

Mark Scurrell's presention (MS ASF team): https://www.youtube.com/watch?v=ot0sCx3bPc0

https://www.youtube.com/watch?v=nZqDZxLcJw4

https://azure.microsoft.com/en-us/services/service-fabric/#benefits

https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-concepts-partitioning

https://docs.microsoft.com/en-us/shows/building-microservices-applications-on-azure-service-fabric/service-fabric-history-and-customer-stories 

https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-overview-microservices

https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-content-roadmap

Szymon Kulec’s vblog: https://www.youtube.com/watch?v=tToSCPvOr10 (in Polish only)

https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-cluster-creation-via-portal 

https://techcommunity.microsoft.com/t5/azure-service-fabric-blog/azure-service-fabric-8-2-first-refresh-release/ba-p/3040415 

https://docs.microsoft.com/en-us/azure/service-fabric/overview-managed-cluster

https://techcommunity.microsoft.com/t5/azure-developer-community-blog/service-fabric-and-kubernetes-community-comparison-part-1-8211/ba-p/337421 
https://www.ben-morris.com/azure-service-fabric-kubernetes/

https://dzimchuk.net/service-fabric-stateful-services/

https://chsakell.com/2018/10/02/getting-started-with-azure-service-fabric/

https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-reliable-services-communication-remoting

https://medium.com/@Herger/chapter-6-azure-service-fabric-one-cluster-to-rule-them-all-ae18c3950e02

Rebai Hamida's presention regarding 'Containerize Microservices with Azure Service Fabric' on Azure User Group Sweden: https://www.youtube.com/watch?v=e2d0rUFJLlg



