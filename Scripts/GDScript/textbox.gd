extends CanvasLayer

@onready var textbox_container = $TextboxContainer
@onready var start = $TextboxContainer/MarginContainer/HBoxContainer/Start
@onready var end = $TextboxContainer/MarginContainer/HBoxContainer/End
@onready var label = $TextboxContainer/MarginContainer/HBoxContainer/Text

@export var CHAR_RATE = 0.02

var now = 0

const text = [
	"It is the year 2436, and the advancements in space exploration has lead to the possibility of the colonisation of Mars by the SpaceY corporation on earth.",
	"In order to fulfill the wishes of their glorious and immortal leader EELON MOOSK (who exists as a brian in a vat),",
	"The high ranking officials of SpaceY believe that it is the destiny of the human race to terraform mars into their second homeland.",
	"However, their convictions are foiled by the resiliant Martian Resistance, who hold that Mars is their home, and SpaceY have threatened the very livelihood of the Martian citizens.",
	"Join this conflict as either the leader of SpaceY, or the resistance, and make crucial decisions that influence the outcome of the war.",
	"Will it be the humans or the Martians that prevail..."
]

func _ready():
	add_text(text[now])

func show_textbox():
	start.text = "*"
	textbox_container.show()

func add_text(input_text: String):
	label.text = input_text
	label.visible_ratio = 0
	end.visible_ratio = 0
	show_textbox()
	var tween = get_tree().create_tween()
	tween.tween_property(label, "visible_ratio", 1, len(input_text) * CHAR_RATE)
	tween.tween_property(end, "visible_ratio", 1, 0.1)
	tween.play()

func _on_button_button_down():
	now += 1
	if now < len(text):
		add_text(text[now])
	else:
		var sceneHandler = $"/root/Scene Handler"
		sceneHandler.ToGame(self)
