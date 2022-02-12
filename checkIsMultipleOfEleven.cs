public static class checkIsMultipleOfEleven
{ 
    public static multiplesOfEleven[] checkIsMultiple(string[] numbers){
    try {
      List<multiplesOfEleven> resultado = new List<multiplesOfEleven>();
      int[] numbersInt = ConverStringArrayToNumber(numbers);

      foreach (var x in numbersInt){
        if(x % 11 == 0)
          resultado.Add(new multiplesOfEleven() {number= x, isMultiple=true});
        else
          resultado.Add(new multiplesOfEleven() {number= x, isMultiple=false});
      }

      return resultado.ToArray();
    } catch(Exception ex) {
      throw new Exception("Internal server error: " + ex.Message);
    }
  }
  
  private static int[] ConverStringArrayToNumber(string[] text){
    int[] myInts = Array.ConvertAll(text, s => ConvertStringToNumber(s));
    return myInts;
  }
  
  private static int ConvertStringToNumber (string text) {
    if (string.IsNullOrEmpty(text)) return 0;

    int number;
    bool success = Int32.TryParse(text, out number);
    if (success)
      return number;
    else
      throw new Exception($"The mumber \"{text}\" is invalid.");
  }
}