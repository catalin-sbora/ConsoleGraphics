// See https://aka.ms/new-console-template for more information
using ConsoleGraphics.Commands;
using ConsoleGraphics.DynamicCommands;
using DynamicApp.Abstractions;
using DynamicApp.Shared;


List<IMenu> addFormItems = new() { 
    new MenuItem(new AddTriangleCommand(), "Triunghi"),      
    new MenuItem(new AddCircleCommand(),"Cerc"),    
    new MenuItem(new AddSquareCommand(), "Patrat")    
};

List<IMenu> mainMenuItems = new() {
    new MenuItem(new ViewBoardCommand(), "Vizualizare plansa"),
    new Menu(addFormItems) { DisplayText = "Adaugare forma" },
    new MenuItem(new RemoveShapeCommand(),"Stergere Forma" )
};

Menu mainMenu = new Menu(mainMenuItems) ;
mainMenu.Execute(null);


