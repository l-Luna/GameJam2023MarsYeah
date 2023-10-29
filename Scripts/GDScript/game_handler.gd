extends Node2D

@onready var animation_player = $AnimationPlayer
@onready var camera = $Camera2D



# Called when the node enters the scene tree for the first time.
func _ready():
	pass # Replace with function body.



func _input(event):
	if event.is_action_pressed("ui_accept"):
		pan_camera()
		
	if event.is_action_pressed("ui_cancel"):
		get_tree().quit()
		

func pan_camera():
	if camera.offset == Vector2.ZERO:
		animation_player.play("pan_to_martian")
	else:
		animation_player.play("pan_to_human")
	
	
