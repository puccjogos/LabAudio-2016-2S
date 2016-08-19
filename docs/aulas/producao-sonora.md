## Produção sonora

Música (e som no geral), historicamente, são artes performáticas, presenciais. Com o surgimento de técnicas de registro e reprodução de performances, a forma de se relacionar com a música mudou, tanto do ponto de vista de artistas quanto dos ouvintes / consumidores. Para mais detalhes, vale olhar a [Wikipédia](https://pt.wikipedia.org/wiki/Grava%C3%A7%C3%A3o_e_reprodu%C3%A7%C3%A3o_sonora).

![Fonógrafo](https://raw.githubusercontent.com/puccjogos/LabAudio-2015-2S/master/Docs/IMGS/fonoografo.jpg)

*Fonógrafo, uma das primeiras tecnologias de gravação e reprodução de áudio.*

As tecnologias de gravação e reprodução mudaram muito desde seu surgimento, mas mantém algumas semelhanças estruturais. Os sons que saem de uma fonte emissora passam por um dispositivo de captação (ex. um microfone) que transforma as vibrações do ar em outro formato que facilite seu registro (ex. impulsos elétricos em um microfone). Esse impulsos são então codificados e armazenados em algum tipo de mídia, seja ela analógica, magnética ou digital.

**Produção sonora** é o conjunto de técnicas e práticas envolvidas nesse processo de registro de som, seja ele musical ou não. Ela envolve o uso de equipamentos especializados, criatividade em conseguir efeitos finais desejados, planejamento cuidadoso e colaboração com diferentes artistas.

### Áreas de atuação

De forma simplificada, o técnico de produção sonora tem diversas áreas de atuaçao. Qualquer mídia que envolve áudio pode se beneficiar do trabalho destes técnicos. Para nosso estudo, vamos focar em áreas criativas e expressivos mais comuns no desenvolvimento de jogos.

1. **Efeitos sonoros:** sons usados para criar ambientação ou representar os sons decorrentes de algum processo. Envolve tanto a captação de som com microfones quanto a criação de sons sintéticos. Exemplo: som quando um personagem pula, explosão, passos.

1. **Música:** seja linear ou adaptiva. Pode ser mais convencional ou experimental. Envolve tanto a captação de instrumentos e vozes quanto o uso de instrumentos sintéticos.

1. **Diálogo:** usado principalmente para dublagem de personagens e narrações.

### O que é som de jogos?

<iframe width="100%" height="400" src="https://www.youtube.com/embed/sM4YAio2LM4" frameborder="0" allowfullscreen></iframe>

### Lembrete: licenças e circulação

É essencial que todo criador conheça e respeite as licenças de uso de outras obras e se informar sobre diferentes formatos. Alguns conceitos importantes:

1. **O que é direito autoral / copyright?** É o direito dos criadores de uma obra de decidir sobre os usos e circulação de suas obras. No Brasil, esses direitos vencem 70 anos depois do falecimento dos autores. Isso varia por país.
1. **O que é domínio público?** Conteúdos e obras que estão livres de direitos patrimoniais e podem ser utilizadas por qualquer pessoa, de qualquer maneira.
3. **O que é Creative Commons?** É um conjunto de licenças que definem diferentes tipos de autorizações e restrições de uso para uma obra original, com o objetivo de incentivar uma cultura de recriação, remix e distribuição livre. As principais autorizações são: uso comercial (sim ou não), atribuição (sim ou não), manter uma licença aberta nas obras derivadas.

## Som e suas propriedades

**Som** é uma onda vibratória que se propaga por algum meio. Algumas de suas propriedades mais importantes estão listadas abaixo.

![](https://upload.wikimedia.org/wikipedia/commons/6/6d/Sine_waves_different_frequencies.svg)

*Acima: ondas senoidais em diferentes frequências.*

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

### Som digital

O som digital é uma forma de representar, armazenar, manipular e reproduzir sinais sonoros. Um sinal analógico é convertido para um sinal digital, através de processos de *sampling* (amostragem) e de *quantização*.

![](https://upload.wikimedia.org/wikipedia/commons/thumb/2/21/4-bit-linear-PCM.svg/500px-4-bit-linear-PCM.svg.png)

*Acima: sinal analógico e seu equivalente já quantizado e amostrado.*

**[Sampling](https://en.wikipedia.org/wiki/Sampling_(signal_processing)) / amostragem** é o processo que "fatia" um som em pequenas partes para medir a intensidade do sinal naquele momento do tempo. Cada fatia representa uma pequena porção de tempo e taxas de amostragem são medidas em Hz, ou número de amostragens por segundo. O som de um CD tem amostragem de 44100 Hz.

**[Quantização](https://pt.wikipedia.org/wiki/Quantiza%C3%A7%C3%A3o)** é o processo que aproxima o valor de uma amostragem para uma gama de valores reduzida. Significa estabelecer uma precisão máxima para o valor de cada amostragem e implica na simplificação do formato de onda do sinal original. Quanto menor esse valor, mais drásticas é a simplificação da onda.

Som digital pode ser tanto fruto de um processo de gravação quanto de sintetização, no qual esse sinal digital é gerado diretamente por um equipamento. Abaixo está um diagrama representando as principais etapas dos processos de gravação e reprodução de som digital.

![](https://upload.wikimedia.org/wikipedia/commons/8/84/A-D-A_Flow.svg)

*Acima: <a href="https://commons.wikimedia.org/wiki/File:A-D-A_Flow.svg#/media/File:A-D-A_Flow.svg">Fluxo analógico-digital-analógico</a>, por <a href="//commons.wikimedia.org/w/index.php?title=User:Teeks99&amp;action=edit&amp;redlink=1" class="new" title="User:Teeks99 (page does not exist)">Teeks99</a>.*
