resource "random_string" "suffix" {
    length = 12
    upper = false
    lower = true
    numeric = true
    special = false
}