Links sobre Oddworld e design de som

- [OddWorld: Abe's Odyssee Speedrun](https://www.youtube.com/watch?v=Rlo8Cotvz_E)
- [Terry interview](https://www.youtube.com/watch?v=23JgGAmCGVU)

## Som e suas propriedades

**Som** é uma onda vibratória que se propaga por algum meio. Algumas de suas propriedades mais importantes estão listadas abaixo.

![](https://upload.wikimedia.org/wikipedia/commons/6/6d/Sine_waves_different_frequencies.svg)

#### Frequência e altura

Quando falamos de **[frequência](https://en.wikipedia.org/wiki/Audio_frequency)** de um som, estamos falando da velocidade dessa vibração. As frequências audíveis para humanos vão de 20 a 20.000 Hz, ou seja, de 20 a 20.000 ciclos por segundo. A nossa percepção subjetiva dessas frequências é chamada de **[altura](https://pt.wikipedia.org/wiki/Altura_(m%C3%BAsica))** (pitch). 

#### [Duração](https://pt.wikipedia.org/wiki/Dura%C3%A7%C3%A3o_(m%C3%BAsica))

A duração de um som é o tempo que conseguimos ouvi-lo. Está bsatante ligado à sua intensidade e, no caso de uma música, ao [andamento](https://pt.wikipedia.org/wiki/Andamento) (a base para a velocidade de uma música).

#### [Intensidade ou volume](https://pt.wikipedia.org/wiki/Intensidade_(ac%C3%BAstica))

A intensidade de um som está ligada à nossa percepção de a amplitude de sua onda, ou seja, o quanto ela varia ou a energia que ela apresenta em um determinado momento. Essa intensidade diminui coma  distância e com obstáculos no caminho da onda sonora, um dos fenômenos que nos permite associar distância com uma noção espacial apenas atavés do som. A intensidade sonora é medida em decibéis, uma escala logaritmíca, já  que a intensidade varia exponencialmente.

####[Timbre](https://pt.wikipedia.org/wiki/Timbre)

O timbre é nossa percepção das diferenças de fontes sonoras de cada som. Mesmo se um som tem a mesma intensidade e altura que outro som, o timbre nos permite diferenciar suas fontes. Por isso, uma mesma nota em um violino ou num teclado soam diferentes. Existem uma série de propriedades que diferenciam o timbre de uma fonte para outra, mas vamos focar em duas principais:

- **Formato da onda** está relacionado a como uma fonte faz o ar vibrar, ou seja, como essa pressão varia. Em um gráfico cartesiano, ess variação cria diferentes desenhos. Esse formato também está relacionado às *frequências harmônicas* de um som, ou seja, o conjunto de frequências simultâneas que compõem o som.

![](https://upload.wikimedia.org/wikipedia/commons/0/02/Formas_Onda.png)

- **Envelope sonoro**  é a forma, definida por intensidades e tempos em momentos diferentes, com que o som se desenvolve. Tem quatro fatores principais: *ataque* (início da nota), *decaimento* (diminuição de intensidade após início), *sustentação* (como a nota se mantém) e *relaxamento* (a forma com que termina). A sua abreviação **ADSR** é bastante usada. Acima temos uma imagem de três envelopes de instrumentos diferentes (tabla, trompa e flauta).

## Som digital

O som digital é uma forma de representar, armazenar, manipular e reproduzir sinais sonoros. Um sinal analógico é convertido para um sinal digital, através de processos de *sampling* (amostragem) e de *quantização*. 

![](https://upload.wikimedia.org/wikipedia/commons/thumb/2/21/4-bit-linear-PCM.svg/500px-4-bit-linear-PCM.svg.png)

*Acima: sinal analógico e seu equivalente já quantizado e amostrado.*

**[Sampling](https://en.wikipedia.org/wiki/Sampling_(signal_processing)) / amostragem** é o processo que "fatia" um som em pequenas partes para medir a intensidade do sinal nauqele momento do tempo. Cada fatia representa uma pequena porção de tempo e taxas de amostragem são medidas em Hz, ou número de amostragens por segundo. O som de um CD tem amostragem de 44100 Hz.

**[Quantização](https://pt.wikipedia.org/wiki/Quantiza%C3%A7%C3%A3o)** é o processo que aproxima o valor de uma amostragem para uma gama de valores reduzida. Significa estabelecer uma precisão máxima para o valor de cada amostragem e implica na simplificação do formato de onda do sinal original. Quanto menor esse valor, mais drásticas é a simplificação da onda.

Som digital pode ser tanto fruto de um processo de gravação quanto de sintetização, no qual esse sinal digital é gerado diretamente por um equipamento. Abaixo está um diagrama representando as principais etapas dos processos de gravação e reprodução de som digital.

![](https://upload.wikimedia.org/wikipedia/commons/8/84/A-D-A_Flow.svg)

*"<a href="https://commons.wikimedia.org/wiki/File:A-D-A_Flow.svg#/media/File:A-D-A_Flow.svg">A-D-A Flow</a>" por <a href="//commons.wikimedia.org/w/index.php?title=User:Teeks99&amp;action=edit&amp;redlink=1" class="new" title="User:Teeks99 (page does not exist)">Teeks99</a>.*