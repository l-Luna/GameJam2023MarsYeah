extends TextureProgressBar

@export var player: HBoxContainer 

func _ready():
	set_max_health(100)
	set_max_health(100)
	#player.healthChanged.connect(update)
	#update()

#func update():
	#value = player.currentHealth * 100 / player.maxHealth

func set_max_health(health):
	max_value = health
	

func set_current_health(health):
	value = health



