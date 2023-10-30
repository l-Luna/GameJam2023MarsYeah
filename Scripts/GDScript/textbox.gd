extends CanvasLayer

@onready var textbox_container = $TextboxContainer
@onready var start = $TextboxContainer/MarginContainer/HBoxContainer/Start
@onready var end = $TextboxContainer/MarginContainer/HBoxContainer/End
@onready var label = $TextboxContainer/MarginContainer/HBoxContainer/Text

@export var CHAR_RATE = 0.02

var now = 0

const text = [
	"abcdefg",
	"hijk lmnop",
	"qrs",
	"tuv,",
	"w, x;",
	"y and z"
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
