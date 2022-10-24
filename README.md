# SolucionViajes
A continuacion explicaré los pasos para ejecutar la aplicacion

# Como configurar el backend
TENER EN CUENTA => el proyecto se realizó con .Net6

El proyecto para el backend cuenta con las librerias newtonsoft, microsoft entity framework core, microsoft entity framework design y microsoft entity framework core sqlServer. asegurarse de que estas librerias se encuentran descargadas para poder ejecutar el pryecto.
para descargar las librerías, damos click derecho en dependencias y seleccionamos administrador de paqutes NuGet, en examinar buscamos los paquetes antes mensionados y los descargamos

![image](https://user-images.githubusercontent.com/84154739/197449053-32dc1ea5-5fe0-4c38-882c-f389ff3653ef.png)

# Como configurar el frontend
TENER EN CUENTA => el pryecto se realizó con las versiones de Angular CLI: 14.2.6 y Node: 16.15.0

Para el Frontend se descargó la librería de bootstrap, asegurarse de que se encuentra instalada, ya el resto se encuentra configurado
Para descargar Bootstrap, en la consola en la ubicacion de proyecto en SolucionFront ejecutamos el comando npm install bootstrap --save
![image](https://user-images.githubusercontent.com/84154739/197449465-7126987c-6b1e-40c5-aaae-c6d374666561.png)

#Correr el proyecto
Una vez tengamos todas las librerias instaladas, ejecutamos la aplicación, primero ejecutamos el backend y luego el frontend

Cuando el ejecutamos el backend este nos abrirá una pestaña en el navegador por defecto, se ejecutará suagger y con este tambien podemos probar el backend

![image](https://user-images.githubusercontent.com/84154739/197449799-f7679562-1ac6-4e84-a41b-39aca88e0194.png)

![image](https://user-images.githubusercontent.com/84154739/197449829-70cd0bc2-9e14-484d-8562-1ac5f285cdf7.png)


Cuando ya tenemos el backend corriendo, ejecutamos el frontend indicando en la consola el comando ng serve --open (sefurarse de encontrarse en la ubicacion SolucionFront)
![image](https://user-images.githubusercontent.com/84154739/197449947-9edab3d9-73ec-4f2d-b0b3-fcfd9d4a3c1d.png)

Se ejecutará una una ventana en el navegador donde pueden ver el funcionamiento

![image](https://user-images.githubusercontent.com/84154739/197450058-8d9bad47-3371-49f4-aa9f-7821f5f15475.png)

