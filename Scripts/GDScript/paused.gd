extends Control



func _on_quit_button_pressed():
	get_tree().quit()


func _on_continue_button_pressed():
	get_tree().paused = false
	queue_free()
