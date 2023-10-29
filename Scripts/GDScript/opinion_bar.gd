extends Control

@onready var earth_bias = $HBoxContainer/EarthBias
@onready var mars_bias = $HBoxContainer/MarsBias
var opinion_value : int = 0 : set = set_opinion

func _ready():
	set_opinion(0)

func set_opinion(value):
	opinion_value += value
	
	#biased towards martians
	if opinion_value > 0:
		earth_bias.value = 0
		mars_bias.value = opinion_value
		print("biased towards martians")
		
	#biased towards earth
	elif opinion_value < 0:
		mars_bias.value = 0
		earth_bias.value = opinion_value*-1
		print("biased towards earth")
		
	#no bias
	elif opinion_value == 0:
		earth_bias.value = 1
		mars_bias.value = 1
		print("no bias")
		
	print("set")
