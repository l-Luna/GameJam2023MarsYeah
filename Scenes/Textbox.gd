extends CanvasLayer

@onready var textbox_container = $TextboxContainer
@onready var start = $TextboxContainer/MarginContainer/HBoxContainer/Start
@onready var end = $TextboxContainer/MarginContainer/HBoxContainer/End
@onready var label = $TextboxContainer/MarginContainer/HBoxContainer/Text 
@onready var audio_player = $TextboxContainer/AudioStreamPlayer

var tween = get_tree().create_tween()
const CHAR_RATE = 0.02 
var sfx: AudioStream 


func _ready():
	hide_textbox()
	add_text("Default text added",sfx)
	
func hide_textbox():
	start.text = ""
	end.text = ""
	label.text = ""
	textbox_container.hide()
	
func show_textbox():
	start.text = "*"
	textbox_container.show()

func add_text(input_text,speech_sfx:AudioStream):
	audio_player.stream = speech_sfx
	label.text = input_text
	show_textbox()
	tween.interpolate_property(label, "percent_visible",0.0,1.0,len(input_text)*CHAR_RATE,tween.TRANS_LINEAR,tween.EASE_IN_OUT)
	tween.start()

func _on_tween_all_completed():
	end.text = "v"

