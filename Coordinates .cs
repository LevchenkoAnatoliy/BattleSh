public class Coordinates implements ICoordinates  {
	public static final String NUMBERS[] = {
			"1","2","3","4","5","6","7","8","9","10"
	};	
	public static final String LETTERS[] = {
			"À","Á","Â","Ã","Ä","Å","¨","Æ","Ç","È",
			"à","á","â","ã","ä","å","¸","æ","ç","è",
	};
	
	public String validatedCoordinate;
	public String letter;
	public int number;
	public int firstArray;
	public int secondArray;
	
		
	Coordinates(){		
		validatedCoordinate = LETTERS[0] + NUMBERS[0];
		letter = LETTERS[0];
		number = Integer.valueOf(NUMBERS[0]);
		firstArray = 0;
		secondArray = 0;
		
		
	}
	
	Coordinates(String letter, String number){	
		String coordinates = letter + number;
		if(validateCoordinates(coordinates)){	
			validatedCoordinate = pars(coordinates);
			this.letter = validatedCoordinate.substring(0, 1);
			if(validatedCoordinate.length() == 2){
				this.number = Integer.valueOf(validatedCoordinate.substring(1, 2));
			} else {
				this.number = Integer.valueOf(validatedCoordinate.substring(1, 3));
			}
			seekPos(this.letter,this.number);
		} else {
			validatedCoordinate = LETTERS[0] + NUMBERS[0];
			this.letter = LETTERS[0];
			this.number = Integer.valueOf(NUMBERS[0]);
			firstArray = 0;
			secondArray = 0;
			System.out.println("Incorrect input. Coordinate was set as (A,1)");
		}
		
	}
	
	Coordinates(String coordinates){
		if(validateCoordinates(coordinates)){	
			validatedCoordinate = pars(coordinates);
			letter = validatedCoordinate.substring(0, 1);
			if(validatedCoordinate.length() == 2){
				number = Integer.valueOf(validatedCoordinate.substring(1, 2));
			} else {
				number = Integer.valueOf(validatedCoordinate.substring(1, 3));
			}	
			seekPos(this.letter,this.number);
		} else {
			validatedCoordinate = LETTERS[0] + NUMBERS[0];
			letter = LETTERS[0];
			number = Integer.valueOf(NUMBERS[0]);
			firstArray = 0;
			secondArray = 0;
			System.out.println("Incorrect input. Coordinate was set as (A,1)");
		}		
	}	
	
	public boolean validateCoordinates(String coordinates){
		boolean containsInt = false;
		boolean containsChar = false;		
		for(int i = 0; i<coordinates.length(); i++){
			if(Arrays.asList(LETTERS).contains(coordinates.substring(i,i+1))){
				containsChar = true;								
			}			
			if(Arrays.asList(NUMBERS).contains(coordinates.substring(i,i+1))){
				containsInt = true;								
			}
		}
		if(containsChar && containsInt){
			return true;
		} else {
			return false;
		}
		
	}
	
	public String pars(String coordinates){
		String result = "";
		if(validateCoordinates(coordinates)){
			for(int i = 0; i<coordinates.length(); i++){
				if(Arrays.asList(LETTERS).contains(coordinates.substring(i,i+1))){
					result += coordinates.substring(i,i+1);	
					break;
				}							
			}
			for(int i = 0; i<coordinates.length(); i++){
				try{
					if("10".equals(coordinates.substring(i,i+2))){
					result += coordinates.substring(i,i+2);
					break;
					}
				} catch(StringIndexOutOfBoundsException e){
					//Do nothing
				}
				if(Arrays.asList(NUMBERS).contains(coordinates.substring(i,i+1))){
					result += coordinates.substring(i,i+1);
					break;
				}							
			}			
		} else {
			result += NUMBERS[0];
			result += LETTERS[0];
			System.out.println("Incorrect input. Coordinate was set as (A,1");			
		}
		return result;		
	}
	
	public boolean equals(Coordinates coordinate){
		if( (coordinate.validatedCoordinate.equals(this.validatedCoordinate) ) &&
			(coordinate.letter.equals(letter) )	&&
			(coordinate.number == number) ) {
			return true;
		} else {
			return false;
		}
	}
	
	private void seekPos(String letter, int number){
		firstArray = number - 1;
		for (int i = 0; i < 20; i++){
			if(letter.equals(LETTERS[i])){
				if(i > 9){
					secondArray = i - 10; 					
				} else {
					secondArray = i;
				}
			}
		}
		
	}

}