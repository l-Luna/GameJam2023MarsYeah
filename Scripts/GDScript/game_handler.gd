extends Node2D

@onready var animation_player = $AnimationPlayer
@onready var camera = $Camera2D


# Called when the node enters the scene tree for the first time.
func _ready():
	pass # Replace with function body.



func _input(event):
	if event.is_action_pressed("ui_cancel"):
		pause_game()
		
		

func pan_camera():
	if camera.offset == Vector2.ZERO:
		animation_player.play("pan_to_martian")
	elif camera.offset == Vector2(1920,0):
		animation_player.play("pan_to_human")
	
	
func pause_game():
	get_tree().paused = true
	var pause_scene = load("res://Scenes/paused.tscn").instantiate()
	$CanvasLayer.add_child(pause_scene)

