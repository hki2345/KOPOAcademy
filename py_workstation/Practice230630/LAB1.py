import json

f = open("input/test_data.json")
jFile = json.load(f)
f.close()


points = jFile["shapes"][0]["points"]

xPoints = [i[0] for i in jFile["shapes"][0]["points"]]
yPoints = [i[1] for i in jFile["shapes"][0]["points"]]

print(f"가장 작은 x, y값: x: {min(xPoints)}, y: {min(yPoints)}")
print(f"가장 큰 x, y값: x: {max(xPoints)}, y: {max(yPoints)}")