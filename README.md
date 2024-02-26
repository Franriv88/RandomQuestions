# RandomQuestions

Este proyecto tienen la finalidad de realizar un muestreo random del contenido de un archivo Excel importado.
El objetivo es que el cliente pueda importar un archivo Excel que contenga numerosas frases establecidas dentro de las filas de este archivo y el programa sea capaz de leerlo y mostrar por pantalla la cantidad de frases establecidas por el usuario. Posteriormente, se podrán copiar dichas frases seleccionadas y mostradas aleatóriamente para ser utilizadas según la necesidad del cliente.

El objetivo es que las preguntas que han sido seleccionadas (copiadas) por el usuario deberán quedar inhabilitadas por un período de tiempo establecido de 2 meses, desde el preciso momento que el usuario hace click en el botón "copy". Para lograr esto, se establece a cada fila del archivo excel un id que corresponde a un text, y su respectiva fecha de lastUse. De esta forma, las frases seleccionadas no serán repetidas si luego de haber sido copiadas se vuelve a barajear el contenido del archivo Excel importado.

Estas frases tomarán su fecha y hora en el lastUse de cada una, tomando la fecha y hora del sistema al moemnto de hacer click en el botón "copy". Cuando transcurra el tiempo determinado de 2 meses, estas quedarán disponibles de nuevo para su uso.

En todo momento se deberá mostrar el Stock total que es el contenido de frases existentes en el archivo y las frases que quedan disponibles luego de haber seleccionado frases y quedando inhabilitadas conforme se vayan usando.
