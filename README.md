# MirrorShooter
![RocketMan](https://user-images.githubusercontent.com/12250862/222146843-2958848e-4f7b-4d43-b4e5-dbe4b27c06f3.png)
The game includes character movement mechanics using the Command pattern with separate command classes for walking, running, and jumping. The shooting mechanics have been designed using the Singleton pattern, with a single instance of the shooting class shared by all players. The rocket propulsion mechanics have been designed using the State pattern, with separate state classes for the different flight modes such as ascending, descending, and boosting. Additionally, the power-up mechanics have been designed using the Strategy pattern, with separate strategy classes for each type of power-up such as fuel, ammo, and health.

Overall, these design patterns provide a structured approach to designing the different mechanics of my game, allowing for more flexibility, extensibility, and maintainability. By implementing these patterns, I can easily modify and extend my game with new features and mechanics while keeping the existing code organized and maintainable.
