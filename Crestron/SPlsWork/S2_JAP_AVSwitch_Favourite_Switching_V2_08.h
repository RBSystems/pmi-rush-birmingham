#ifndef __S2_JAP_AVSWITCH_FAVOURITE_SWITCHING_V2_08_H__
#define __S2_JAP_AVSWITCH_FAVOURITE_SWITCHING_V2_08_H__



/*
* STRUCTURE S2_JAP_AVSwitch_Favourite_Switching_V2_08___0
*/
#define _0__S2_JAP_AVSwitch_Favourite_Switching_V2_08__1_STRING_MAX_LEN 80
#define _0__S2_JAP_AVSwitch_Favourite_Switching_V2_08__5_STRING_MAX_LEN 256
START_STRUCTURE_DEFINITION( S2_JAP_AVSwitch_Favourite_Switching_V2_08, _0 )
{
   CREATE_STRING_STRUCT( S2_JAP_AVSwitch_Favourite_Switching_V2_08, _0___1, _0__S2_JAP_AVSwitch_Favourite_Switching_V2_08__1_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_JAP_AVSwitch_Favourite_Switching_V2_08, _0___1 );
   CREATE_STRING_STRUCT( S2_JAP_AVSwitch_Favourite_Switching_V2_08, _0___5, _0__S2_JAP_AVSwitch_Favourite_Switching_V2_08__5_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_JAP_AVSwitch_Favourite_Switching_V2_08, _0___5 );
   unsigned short _0___2;
   unsigned short _0___6;
   unsigned short _0___7;
   unsigned short _0___8;
   unsigned short _0___9;
   CREATE_INTARRAY1D( S2_JAP_AVSwitch_Favourite_Switching_V2_08, _0___3, 10 );;
   DECLARE_INTARRAY( S2_JAP_AVSwitch_Favourite_Switching_V2_08, _0___3 );
   CREATE_INTARRAY1D( S2_JAP_AVSwitch_Favourite_Switching_V2_08, _0___4, 10 );;
   DECLARE_INTARRAY( S2_JAP_AVSwitch_Favourite_Switching_V2_08, _0___4 );
   CREATE_INTARRAY1D( S2_JAP_AVSwitch_Favourite_Switching_V2_08, _0___10, 10 );;
   DECLARE_INTARRAY( S2_JAP_AVSwitch_Favourite_Switching_V2_08, _0___10 );
   CREATE_SIGNED_INTARRAY1D( S2_JAP_AVSwitch_Favourite_Switching_V2_08, _0___11, 10 );;
   DECLARE_SIGNED_INTARRAY( S2_JAP_AVSwitch_Favourite_Switching_V2_08, _0___11 );
};


/*
* Constructor and Destructor
*/
int S2_JAP_AVSwitch_Favourite_Switching_V2_08__0_Constructor ( START_STRUCTURE_DEFINITION( S2_JAP_AVSwitch_Favourite_Switching_V2_08, _0 ) * me, int nVerbose );
int S2_JAP_AVSwitch_Favourite_Switching_V2_08__0_Destructor ( START_STRUCTURE_DEFINITION( S2_JAP_AVSwitch_Favourite_Switching_V2_08, _0 ) * me, int nVerbose );

/*
* DIGITAL_INPUT
*/
#define __S2_JAP_AVSwitch_Favourite_Switching_V2_08_SELECT_ALL_DIG_INPUT 0
#define __S2_JAP_AVSwitch_Favourite_Switching_V2_08_CLEAR_ALL_DIG_INPUT 1

#define __S2_JAP_AVSwitch_Favourite_Switching_V2_08_CREATE_FAVOURITE_DIG_INPUT 2
#define __S2_JAP_AVSwitch_Favourite_Switching_V2_08_CREATE_FAVOURITE_ARRAY_LENGTH 8
#define __S2_JAP_AVSwitch_Favourite_Switching_V2_08_RECALL_FAVOURITE_DIG_INPUT 10
#define __S2_JAP_AVSwitch_Favourite_Switching_V2_08_RECALL_FAVOURITE_ARRAY_LENGTH 8
#define __S2_JAP_AVSwitch_Favourite_Switching_V2_08_OUTPUT_DIG_INPUT 18
#define __S2_JAP_AVSwitch_Favourite_Switching_V2_08_OUTPUT_ARRAY_LENGTH 404
#define __S2_JAP_AVSwitch_Favourite_Switching_V2_08_INPUT_DIG_INPUT 422
#define __S2_JAP_AVSwitch_Favourite_Switching_V2_08_INPUT_ARRAY_LENGTH 404

/*
* ANALOG_INPUT
*/
#define __S2_JAP_AVSwitch_Favourite_Switching_V2_08_OUTPUT_NUMBER_ANALOG_INPUT 1
#define __S2_JAP_AVSwitch_Favourite_Switching_V2_08_INPUT_NUMBER_ANALOG_INPUT 2

#define __S2_JAP_AVSwitch_Favourite_Switching_V2_08_PROCESSORTYPE_STRING_INPUT 0
#define __S2_JAP_AVSwitch_Favourite_Switching_V2_08_PROCESSORTYPE_STRING_MAX_LEN 256
CREATE_STRING_STRUCT( S2_JAP_AVSwitch_Favourite_Switching_V2_08, __PROCESSORTYPE, __S2_JAP_AVSwitch_Favourite_Switching_V2_08_PROCESSORTYPE_STRING_MAX_LEN );


#define __S2_JAP_AVSwitch_Favourite_Switching_V2_08_OUTPUTSTATUS_ANALOG_INPUT 3
#define __S2_JAP_AVSwitch_Favourite_Switching_V2_08_OUTPUTSTATUS_ARRAY_LENGTH 404

/*
* DIGITAL_OUTPUT
*/
#define __S2_JAP_AVSwitch_Favourite_Switching_V2_08_FAVOURITEFILEERROR_DIG_OUTPUT 0

#define __S2_JAP_AVSwitch_Favourite_Switching_V2_08_OUTPUTFB_DIG_OUTPUT 1
#define __S2_JAP_AVSwitch_Favourite_Switching_V2_08_OUTPUTFB_ARRAY_LENGTH 404

/*
* ANALOG_OUTPUT
*/

#define __S2_JAP_AVSwitch_Favourite_Switching_V2_08_FAVOURITE_CMD_STRING_OUTPUT 0
#define __S2_JAP_AVSwitch_Favourite_Switching_V2_08_MULTI_SWITCH_CMD_STRING_OUTPUT 1


/*
* Direct Socket Variables
*/




/*
* INTEGER_PARAMETER
*/
/*
* SIGNED_INTEGER_PARAMETER
*/
/*
* LONG_INTEGER_PARAMETER
*/
/*
* SIGNED_LONG_INTEGER_PARAMETER
*/
/*
* INTEGER_PARAMETER
*/
/*
* SIGNED_INTEGER_PARAMETER
*/
/*
* LONG_INTEGER_PARAMETER
*/
/*
* SIGNED_LONG_INTEGER_PARAMETER
*/
/*
* STRING_PARAMETER
*/


/*
* INTEGER
*/
CREATE_INTARRAY1D( S2_JAP_AVSwitch_Favourite_Switching_V2_08, ___49, 404 );;


/*
* LONG_INTEGER
*/


/*
* SIGNED_INTEGER
*/


/*
* SIGNED_LONG_INTEGER
*/


/*
* STRING
*/

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_JAP_AVSwitch_Favourite_Switching_V2_08 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __CREATE_FAVOURITE );
   DECLARE_IO_ARRAY( __RECALL_FAVOURITE );
   DECLARE_IO_ARRAY( __OUTPUT );
   DECLARE_IO_ARRAY( __INPUT );
   DECLARE_IO_ARRAY( __OUTPUTFB );
   DECLARE_IO_ARRAY( __OUTPUTSTATUS );
   unsigned short ___50;
   DECLARE_INTARRAY( S2_JAP_AVSwitch_Favourite_Switching_V2_08, ___49 );
   DECLARE_STRING_STRUCT( S2_JAP_AVSwitch_Favourite_Switching_V2_08, __PROCESSORTYPE );
};

START_NVRAM_VAR_STRUCT( S2_JAP_AVSwitch_Favourite_Switching_V2_08 )
{
};

DEFINE_WAITEVENT( S2_JAP_AVSwitch_Favourite_Switching_V2_08, __SPLS_TMPVAR__WAITLABEL_0__ );


#endif //__S2_JAP_AVSWITCH_FAVOURITE_SWITCHING_V2_08_H__

