require 'json'

ruby_obj = JSON.parse('{"blue": [1,2], "ocean":"water"}')
puts "Ruby Object:============"
puts ruby_obj
puts "========================"

ruby_obj["ocean"] = {"water" => ["fishy", "salty"]}

puts "Ruby object pretty========================="
puts JSON.generate(ruby_obj)
puts JSON.pretty_generate(ruby_obj)
puts "==========================================="