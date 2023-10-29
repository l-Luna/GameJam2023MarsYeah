extends Node


# Called when the node enters the scene tree for the first time.
func _ready():
	pass # Replace with function body.


func _on_play_button_button_down():
	var sceneHandler = $"/root/Scene Handler"
	sceneHandler.ToGame(self)
