# UIForGalGame
UsingForGalGame(LikeConversation)
脚本使用介绍
原理是通过setactive和控制GameObject的顺序发展剧情  
## `C# ： DialogueManager`  
GameObject StartConversation 开场动画  
GameObject NextConversation  下一个场景  
## `C# : DialogueTrigger `  
在场景中创建空物体并加入脚本来实时更新剧情  
通过将含有DialogueTrigger的GameObject拉到Manager中即可  
通过衔接的方式NEXTConversation拉进NextConversation  
![01205_32_32](https://user-images.githubusercontent.com/65991081/111747211-02ff7700-88ca-11eb-82a6-1eaf316ff97f.png)
