extends Node

@export var event: EventAsset

var instance: EventInstance
var curTarget: int = 0

func _ready():
	instance = FMODRuntime.create_instance(event)
	instance.start()
	instance.release()

func _process(delta):
	pass

func to_menu_theme():
	instance.set_parameter_by_name("theme", 0)

func to_human_theme():
	instance.set_parameter_by_name("theme", 1)

func to_martian_theme():
	instance.set_parameter_by_name("theme", 2)
