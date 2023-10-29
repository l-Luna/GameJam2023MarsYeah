extends Control


# Called when the node enters the scene tree for the first time.
func _ready():
	pass # Replace with function body.

func set_player_won(player):
	$VBoxContainer/RichTextLabel.text = "[center]" + player + " Won"

func _on_quit_button_pressed():
	get_tree().quit()

func _on_back_to_menu_pressed():
	var sceneHandler = $"/root/Scene Handler"
	sceneHandler.ToMainMenu(self)


func on_play_button():
	var new_game = load("res://Scenes/game_handler.tscn").instantiate()
	get_parent().add_child(new_game)
	queue_free()

