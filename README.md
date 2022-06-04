# CSharp-Unity-Dialogue-System
Codigo criado para implementar dialogo 2D no unity - usando c#

Usei Array de string para as falas do jogo e Array de sprite para sprites que vao aparecer durante o dialogo ex: expressoes dos personagens.
Para usar voce tem que criar um novo c# script e colar o código, quando voce criar a salvar voce vera que agora tem espacos em brancos em algumas partes do componente Script(variaveis publicas para ficar mais facil de visualizar no unity). 

Para as strings
--------
Criar um UI Text no unity - nele colocar (Box collider is trigger e editar onde vc quer que o personagem passe para comecar o dialogo E o Script Teste.

Para completar voce tem que colocar:
- public string[] text - as frases do dialogo;
- public Canvas canvas - colocar o canvas que voce criou para ter um UI Text; (vai detectar o canvas e no codigo vai ligar o dialogo quando entrar em contato com outro boxCollider)
- public Text texto - colocar o component text que vai ser criado junto com o UI Text com o nome Text;

ai pronto assim que outro GameObject com RigidBody e box collider passar por ali o texto vai comecar, basta apertar ESPACE para ir para a proxima fala


Ja para os Sprites vc vai criar um Script SpriteArray.
--------
Para criar uma imagem voce clica com o botao direito no canvas criado anteriormente e cria uma Image e posiciona onde voce quer

Para completar voce tem que colocar:
- public Image prot_ - coloca o GameObject Image que voce criou anteriormente;
- public Sprite[] protExpressoes - coloca os Sprites na ordem que voce quer que apareca 
- O Elemento 0 do string vai aparecer ao mesmo tempo que o Elemento 0 no sprite assim voce pode se organizar;

<!-- Code Created to implement dialogue in unity - using C sharp 

I used array string for the dialogue and array sprite for some sprites that appear during the dialogue(Ex : characters expression).

To use you have to creat a new c# script and paste the code.

when you do it you wil see some publics variables/space to complete on unity.
to complete you have to put:
- public string[] text - put the strings from dialogue;
- public Canvas canvas - put the Canvas that you can create from unity UI that have text/text mesh pro;
- public Text texto - put the Component text that will be added on GO Text when you creat UI - Text;
 -->
