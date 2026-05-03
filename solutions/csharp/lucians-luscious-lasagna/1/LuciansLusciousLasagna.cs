class Lasagna
{ private const int timeToPrepareLasagneLayout = 2 ; 
    // TODO: define the 'ExpectedMinutesInOven()' method
public int ExpectedMinutesInOven() 
{ return 40 ; }
    // TODO: define the 'RemainingMinutesInOven()' method
public int RemainingMinutesInOven ( int realTime )
{
    return this.ExpectedMinutesInOven() -  realTime ; 
}
    // TODO: define the 'PreparationTimeInMinutes()' method
public int PreparationTimeInMinutes( int nb)
{
    return timeToPrepareLasagneLayout*nb ; 
}
    // TODO: define the 'ElapsedTimeInMinutes()' method

 public int ElapsedTimeInMinutes(int nb , int cookingTime ) 
 { 
     return PreparationTimeInMinutes(nb)+ cookingTime ;
      
  }
}
