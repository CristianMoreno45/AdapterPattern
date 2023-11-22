# Adapter Pattern

Este proyecto tiene dos soluciones:

##AdapterPattern.sln##
Es el productor de un servicio SOAP el cual tiene una operación la cual supera el minuto llamado `Sum` en el endpoint `https://localhost:7184/service.asmx` el cual suma dos numeros y está escrito en C# `.NEt Core 6`.

## AdapterPattern2.sln## 
Es el Consumidor de un servicio REST el cual tiene un método llamado `Get` dentro del API `Values`, este consume el servicio SOAP enviándole dos parámetros por `querystring` llamados `num1`  y `num2` , está escrito en `.NEt Framework 4.6.1`.
