extends Node2D

func _ready():
	var data_to_send={"name": "unity shit", "maxScore": 99999}
	var json = JSON.stringify(data_to_send)
	var headers = ["Content-Type: application/json"]
	$HTTPRequestPOST.request_completed.connect(_on_post_completed)
	$HTTPRequestPOST.request("https://nthapi.onrender.com/api/Players", headers, HTTPClient.METHOD_POST, json)
	
func _on_post_completed(result, response_code, headers, body):
	$HTTPRequestGET.request_completed.connect(_on_request_completed)
	$HTTPRequestGET.request("https://nthapi.onrender.com/api/players")


func _on_request_completed(result, response_code, headers, body):
	var json = JSON.parse_string(body.get_string_from_utf8())
	for player in json:
		print(player["name"])
	#print(headers.get_string_from_utf8())
