# :boat: Model Boat Club Simulator :video_game:
## Le meilleur simulateur de bateaux télécommandés qu'on peut imaginer ! Enfin presque...

Voici une idée de projet que j'ai commencé ce weekend.
Je me suis inspiré de [ce projet](https://github.com/RafaelKuebler/Flocking) pour la base de code.
J'ai commencé par importer des modèles 3D de bateaux.
J'ai créé 2~3 [Prefab](https://docs.unity3d.com/6000.2/Documentation/Manual/Prefabs.html) mais je me retrouve face à plusieurs problèmes et j'aurais besoin de ton coup de mains !

### **:information_source:  Tu peux déjà commencer par te créer une version de mon projet en [**forkant mon repo**](https://docs.github.com/en/pull-requests/collaborating-with-pull-requests/working-with-forks/fork-a-repo?tool=webui#forking-a-repository).**
### **:information_source: Tu pourra le mettre à jour à chaque fois que tu a complété une étape (en faisant un git push) et tu m'enverra le lien de ton repo github une fois fini ?**
### **:information_source: Si tu peux mettre un commentaire à chaque commit et à chaque "ligne/bloc" de code histoire que je ne sois pas perdu?**
### **:information_source: Si tu peux modifier seulement les lignes de code que tu estime nécessaire ? Pas de gros copier/coller venant d'internet s'il te plait :expressionless: sauf si tu sais ce que tu fais (et que tu me l'explique en commentaire).

## 1. Pouvoir pérennement éditer le comportement des bateaux en mode Play

Une fois que la simulation est lancée (en cliquant sur le bouton :arrow_forward:) je ne peux plus éditer les valeurs de comportement de mes bateaux à moins de tous les sélectionner directement dans la scène et il ne faut pas que j'oublie de me rappeler les valeurs sinon elles ne sont pas enregistrées quand je quitte le mode Play !

**Est-ce que tu pourrais trouver un moyen "d'extraire/externaliser" les variables du script `BoatAutoPilot.cs` ?**

Je crois qu'on peut utiliser les [ScriptableObject](https://docs.unity3d.com/6000.2/Documentation/Manual/class-ScriptableObject.html) pour ça ?

Peut importe la solution que tu utilise tant que je peux :
- Faire mes modifications sur leur comportement en mode Play et que ça reste sauvegardé **automatiquement** une fois que je quitte le mode Play.
- Que les mêmes instances d'un même bateau Prefab aient **le même comportement/les mêmes variables**. Si 50 instances de "Boat Tow B" sont dans la scène ils doivent se comporter de la même manière, donc avoir les mêmes variables en commun sans que j'ai besoin de tous les sélectionner.

**:information_source: Une fois que c'est fait : `commit`, `push` et passe à la suite :smile:**

## 1. (Bonus) Problème inverse (potentiel futur) ?

Si on "retire" les variables du script on ne pourra plus les éditer en sélectionnant directement un bateau dans la scène ?
En imaginant que j'ai pleins de bateaux différents avec chacun leur variables/comportement unique ça risque de nous faire faire beaucoup d'aller/retour entre le script et l'endroit où se trouve ces variable (plusieurs cliques supplémentaire par bateau, l'horreur pour éditer les données) !

Tu pense pouvoir modifier l'éditeur (l'endroit où sont affichées nos variables) afin de "faire revenir" **visuellement** nos variables dans le contexte d'édition (c.a.d. là ou elles étaient à la base, au niveau de notre script `BoatAutoPilot.cs`) ?

J'ai entendu dire que l'inspecteur de Unity est modifiable, notamment via [CustomEditor](https://docs.unity3d.com/6000.2/Documentation/Manual/editor-CustomEditors.html), [SerializedObject](https://docs.unity3d.com/ScriptReference/SerializedProperty.html) et [SerializedProperty](https://docs.unity3d.com/ScriptReference/SerializedProperty.html).

**C'est beaucoup demander à un profil designer donc n'hésite pas à faire ça en dernier.**
Mais n'oublie pas : "Le piment de la vie est la diversité. Sa (re)présentation est d'autant plus importante."

**:information_source: Une fois que c'est fait : `commit`, `push` et passe à la suite :smile:**

## 2. Ils sont bien sympa avec leur Prefab mais...

J'ai commencé a créer des [Prefab](https://docs.unity3d.com/6000.2/Documentation/Manual/Prefabs.html) pour les bateaux mais j'ai plusieurs problèmes.
Je pense qu'on peut utiliser les [Prefab Variant](https://docs.unity3d.com/Manual/PrefabVariants.html) pour les fixer ?

### **:information_source: Dans l'idée j'aimerais que tu mette en place, dans cette étape #2, au MINIMUM deux "familles/variantes" de bateau (e.g. Speed et Tow, ou Sail et House, tu choisis) et au MINIMUM deux variantes visuelles dans ces familles.**
Avec ça en place je pourrais voir comment tu t'es débrouillée et je pourrais reprendre la main derrière.

## 2.a Répétition de la même étape

Vu que ce sont des modèles réduit je modifie la taille du modèle à 40% de sa taille initiale (0.4 en scale x/y/z).
Le soucis c'est que je dois le faire à chaque fois que je créé un nouveau Prefab !
Je pourrais modifier le scale racine de mon Prefab mais **il est recommandé de ne jamais modifier le scale du transform "racine" d'une entité !**
Et surtout si jamais on décide de changer l'échelle du projet (à 30 ou 60% par exemple) je vais devoir le refaire sur tout mes Prefabs ?!
**Quelle solution pourrait-tu apporter à ce problème ?**

Peut-être définir le scale "en amont" ? :thinking:

**:information_source: Une fois que c'est fait : `commit`, `push` et passe à la suite :smile:**

## 2.b Répétition de la même étape (bis)

Quand j'ai plusieurs variantes visuelles d'une même famille de bateau je dois à chaque fois lui redonner ses variables de comportement (le "Boat Speed" en à 10 !).
Non seulement c'est répétitif, créateur d'erreur potentiel mais j'aimerais en plus m'assurer qu'ils aient "véritablement" le même comportement commun.
Si je décide que "Boat Speed A" et "Boat Speed B" ont le même comportement et que je modifie le comportement de la variante A j'aimerais que la variante B soit aussi affectée/modifiée.
**Est-ce que tu pourrais configurer les Prefabs d'une même famille pour que le comportement d'une variante visuel soit définie en amont de cette dernière ?**

**:information_source: Une fois que c'est fait : `commit`, `push` et passe à la suite :smile:**

## 3. Fini la préparation, place à l'action !

Maintenant tu devrais avoir quelques familles de Prefab de prêt ?
J'ai commencé à modifier le script qui s'occupe de faire apparaitre les instances de Prefab mais j'ai deux problèmes.

### 3.a Toutes ces références en dure me rendent fou...

Comme tu peux le voir dans le script `Boat Manager` j'ai commencé à rajouter deux autres variables/références pour les Prefab "Boat House B" et "Boat House C" (habilement nommées `boatHouseA` et `boatHouseC`).
Mais on ne va pas faire ça pour tout nos Prefab ?!
Il devrait y avoir un moyen de réunir ces familles dans une grande collection; non ?
**Est-ce que tu aurais une solution pour ne plus qu'on ai besoin de modifier le script à chaque fois qu'on a une nouvelle variante de bateau ?**

**:information_source: Une fois que c'est fait : `commit`, `push` et passe à la suite :smile:**

### 3.a (Bonus) Mega flemme de remplir ce tableau à la main

### 3.b Am, stram, gram, pic et pic et colégram...

J'ai aussi rajouté une méthode pour choisir un bateau au hasard, appelée `GetRandomBoat()`.
Le soucis c'est que non seulement je ne veux pas écrire des `if {} else if {}` à l'infini mais en plus si on réuni toutes nos variantes dans une collection le script ne saura plus spécifiquement le nombre de variantes ? Enfin si il saura via la propriété `Length` ou `Count` mais ça nous donne juste un nombre entier.
Il faudrait pouvoir choisir un nombre au hasard et *pointer son index* sur une variante et la renvoyer pour qu'elle soit instanciée.

**:information_source: Une fois que c'est fait : `commit`, `push` et passe à la suite :smile:**

### 3.b  (Bonus) Chance pondérée

**:information_source: Une fois que c'est fait : `commit`, `push` et passe à la suite :smile:**
