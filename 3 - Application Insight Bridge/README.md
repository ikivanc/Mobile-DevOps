# Application Insight Bridge
Application insight son pozisyonlaması ile birlikte server-side uygulamaların takibinde kullanılırken, mobil uygulama kullanıcı hatalarını tespit etmek ve kullanıcı davranışlarını inceleyebilmek için HockeyApp'i kullanabiliyoruz. Özellikle de bu iki servisin tüm özelliklerinden faydalanabilmek için biribiri ile bağlayarak daha fazla analitik bilgiler edinmek mümkün.

## Application Insight ve Hockey App'i Birleştirme
Bu dökümanda 2 servisin adım adım nasıl entegre edilebileceğini görebileceğiz.

Application Insight ve HockeyApp'in yapabildiklerinin karşılaştırmaları ve nerede hangi aracı kullanmamız gerektiğini aşağıdaki tablodan edinebilirsiniz.

| Veri Tipi |Application Insights SDK 'sı tarafından desteklenenler|HockeySDK tarafından desteklenenler|
|--------|:-------|:-----------|
| Traces | Evet tüm platformlar | Sadece Windows platformları | 
| Custom events with custom dimensions |  Evet tüm platformlar| Evet tüm platformlar|| Page views | Evet tüm platformlar | Sadece Windows platformu | 
| Dependencies | Sadece Windows platformu | Sadece Windows platformu |
|Metrics |Evet tüm platformlar | Sadece Windows platformu |
|Exceptions | Evet, Custom Eventler aracılığı ile |Evet, Custom Eventler aracılığı ile 
|

HockeyApp ve Application Insight'ın birlikte kullanımı için, adım adım eklemeleri gerçekleştirelim.

1. Azure portal üzerinden login olarak yeni bir Application Insight projesi oluşturalım.
    <img src="images/1.png" alt="">

1. Burada "Application Type" olarak HockeyApp bridge application seçerek HockeyApp'ten aldığımı token'i buraya girelim.
    <img src="images/2.png" alt="">

1. HockeyApp'ten token'i alabilmek için "Account Settings" ten "API Token" I seçelim.
    <img src="images/3.png" alt="">

1. Burada yetki vermek istediğiniz uygulamayı seçerek ilgili hakları vererek isimlendirebiliriz.
    <img src="images/4.png" alt="">
    
1. Daha sonra aşağıdaki gibi uygulamamıza erişim token'ı verecektir.
    <img src="images/5.png" alt="">

1. Bu token'I Application Insight'ta kullanarak uygulamamımızın adınını otomatik olarak seçildiğini görebileceğiz. 
    <img src="images/6.png" alt="">

1. Sonra "Pin to dashboard"u seçerek oluşturduktan sonra aşağıdaki şekilde entegrasyonunun oluştuğunu görebileceğiz.
    <img src="images/7.png" alt="">

1. Oluşturulan projede uygulamamız çalıştıkça overview ve usage kısmından yansımalarını takip edebiliriz.
    <img src="images/8.png" alt="">

1. Rapordaki detaylara tıklayarak da raporun kırılımlarını görebilirsiniz. 
    <img src="images/9.png" alt="">

## Ek Kaynaklar

- [Azure IoT SDK GitHub Repo](https://github.com/Azure/azure-iot-sdks/)
- [Azure IoT Hub SDK - Node-RED "device" samples](https://github.com/Azure/azure-iot-sdk-node/tree/2047cad9224c328a2b421aae644ff23102d32f19/device/node-red)
- [Azure Service Bus/Event Hubs](https://azure.microsoft.com/en-us/services/event-hubs/)
- [Using reference data or lookup tables in a Stream Analytics input stream](https://docs.microsoft.com/en-us/azure/stream-analytics/stream-analytics-use-reference-data)
- [ Reference Data JOIN (Azure Stream Analytics)](https://msdn.microsoft.com/en-us/library/azure/dn949258.aspx?f=255&MSPPError=-2147217396)
- [Sample wiring code showing how to connect and send data to Microsoft Azure IoT Hub with a Texas Instruments CC3200 Launchpad](https://github.com/farukc/AzureIoTHub-TI-CC3200)
- [RaspBerry PI 3](https://www.raspberrypi.org/)
- [Texas Instruments SensorTag](http://ti.com/sensortag)
- [Node-RED](https://nodered.org/)
