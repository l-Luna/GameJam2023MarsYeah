extends Control


<<<<<<< HEAD
=======
# Called when the node enters the scene tree for the first time.
func _ready():
	pass # Replace with function body.



>>>>>>> 0fe9cd346b047192acc910f1a3686d2c2caad65a
func _on_quit_button_pressed():
	get_tree().quit()


func _on_continue_button_pressed():
	get_tree().paused = false
	queue_free()
