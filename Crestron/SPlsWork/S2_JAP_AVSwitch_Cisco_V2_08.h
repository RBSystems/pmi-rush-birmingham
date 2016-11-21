#ifndef __S2_JAP_AVSWITCH_CISCO_V2_08_H__
#define __S2_JAP_AVSWITCH_CISCO_V2_08_H__



/*
* STRUCTURE S2_JAP_AVSwitch_Cisco_V2_08___0
*/
#define _0__S2_JAP_AVSwitch_Cisco_V2_08__1_STRING_MAX_LEN 80
#define _0__S2_JAP_AVSwitch_Cisco_V2_08__5_STRING_MAX_LEN 256
START_STRUCTURE_DEFINITION( S2_JAP_AVSwitch_Cisco_V2_08, _0 )
{
   CREATE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, _0___1, _0__S2_JAP_AVSwitch_Cisco_V2_08__1_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, _0___1 );
   CREATE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, _0___5, _0__S2_JAP_AVSwitch_Cisco_V2_08__5_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, _0___5 );
   unsigned short _0___2;
   unsigned short _0___6;
   unsigned short _0___7;
   unsigned short _0___8;
   unsigned short _0___9;
   CREATE_INTARRAY1D( S2_JAP_AVSwitch_Cisco_V2_08, _0___3, 10 );;
   DECLARE_INTARRAY( S2_JAP_AVSwitch_Cisco_V2_08, _0___3 );
   CREATE_INTARRAY1D( S2_JAP_AVSwitch_Cisco_V2_08, _0___4, 10 );;
   DECLARE_INTARRAY( S2_JAP_AVSwitch_Cisco_V2_08, _0___4 );
   CREATE_INTARRAY1D( S2_JAP_AVSwitch_Cisco_V2_08, _0___10, 10 );;
   DECLARE_INTARRAY( S2_JAP_AVSwitch_Cisco_V2_08, _0___10 );
   CREATE_SIGNED_INTARRAY1D( S2_JAP_AVSwitch_Cisco_V2_08, _0___11, 10 );;
   DECLARE_SIGNED_INTARRAY( S2_JAP_AVSwitch_Cisco_V2_08, _0___11 );
};

/*
* STRUCTURE S2_JAP_AVSwitch_Cisco_V2_08___41
*/
START_STRUCTURE_DEFINITION( S2_JAP_AVSwitch_Cisco_V2_08, _41 )
{
   unsigned short _41___42;
   unsigned short _41___43;
   unsigned short _41___44;
};

/*
* STRUCTURE S2_JAP_AVSwitch_Cisco_V2_08___63
*/
#define _63__S2_JAP_AVSwitch_Cisco_V2_08__64_STRING_MAX_LEN 64000
#define _63__S2_JAP_AVSwitch_Cisco_V2_08__67_STRING_MAX_LEN 15
#define _63__S2_JAP_AVSwitch_Cisco_V2_08__70_STRING_MAX_LEN 15
START_STRUCTURE_DEFINITION( S2_JAP_AVSwitch_Cisco_V2_08, _63 )
{
   CREATE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, _63___64, _63__S2_JAP_AVSwitch_Cisco_V2_08__64_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, _63___64 );
   CREATE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, _63___67, _63__S2_JAP_AVSwitch_Cisco_V2_08__67_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, _63___67 );
   CREATE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, _63___70, _63__S2_JAP_AVSwitch_Cisco_V2_08__70_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, _63___70 );
   unsigned short _63___65;
   unsigned short _63___66;
   unsigned short _63___68;
   unsigned short _63___69;
};

/*
* STRUCTURE S2_JAP_AVSwitch_Cisco_V2_08___72
*/
START_STRUCTURE_DEFINITION( S2_JAP_AVSwitch_Cisco_V2_08, _72 )
{
   unsigned short _72___73;
   unsigned short _72___74;
   unsigned short _72___75;
   unsigned short _72___76;
};

/*
* STRUCTURE S2_JAP_AVSwitch_Cisco_V2_08___78
*/
#define _78__S2_JAP_AVSwitch_Cisco_V2_08__79_STRING_MAX_LEN 5000
#define _78__S2_JAP_AVSwitch_Cisco_V2_08__80_STRING_MAX_LEN 100
#define _78__S2_JAP_AVSwitch_Cisco_V2_08__82_STRING_MAX_LEN 100
#define _78__S2_JAP_AVSwitch_Cisco_V2_08__84_STRING_MAX_LEN 100
START_STRUCTURE_DEFINITION( S2_JAP_AVSwitch_Cisco_V2_08, _78 )
{
   CREATE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, _78___79, _78__S2_JAP_AVSwitch_Cisco_V2_08__79_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, _78___79 );
   CREATE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, _78___80, _78__S2_JAP_AVSwitch_Cisco_V2_08__80_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, _78___80 );
   CREATE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, _78___82, _78__S2_JAP_AVSwitch_Cisco_V2_08__82_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, _78___82 );
   CREATE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, _78___84, _78__S2_JAP_AVSwitch_Cisco_V2_08__84_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, _78___84 );
   unsigned short _78___81;
   unsigned short _78___83;
};


/*
* Constructor and Destructor
*/
int S2_JAP_AVSwitch_Cisco_V2_08__0_Constructor ( START_STRUCTURE_DEFINITION( S2_JAP_AVSwitch_Cisco_V2_08, _0 ) * me, int nVerbose );
int S2_JAP_AVSwitch_Cisco_V2_08__0_Destructor ( START_STRUCTURE_DEFINITION( S2_JAP_AVSwitch_Cisco_V2_08, _0 ) * me, int nVerbose );
int S2_JAP_AVSwitch_Cisco_V2_08__41_Constructor ( START_STRUCTURE_DEFINITION( S2_JAP_AVSwitch_Cisco_V2_08, _41 ) * me, int nVerbose );
int S2_JAP_AVSwitch_Cisco_V2_08__41_Destructor ( START_STRUCTURE_DEFINITION( S2_JAP_AVSwitch_Cisco_V2_08, _41 ) * me, int nVerbose );
int S2_JAP_AVSwitch_Cisco_V2_08__63_Constructor ( START_STRUCTURE_DEFINITION( S2_JAP_AVSwitch_Cisco_V2_08, _63 ) * me, int nVerbose );
int S2_JAP_AVSwitch_Cisco_V2_08__63_Destructor ( START_STRUCTURE_DEFINITION( S2_JAP_AVSwitch_Cisco_V2_08, _63 ) * me, int nVerbose );
int S2_JAP_AVSwitch_Cisco_V2_08__72_Constructor ( START_STRUCTURE_DEFINITION( S2_JAP_AVSwitch_Cisco_V2_08, _72 ) * me, int nVerbose );
int S2_JAP_AVSwitch_Cisco_V2_08__72_Destructor ( START_STRUCTURE_DEFINITION( S2_JAP_AVSwitch_Cisco_V2_08, _72 ) * me, int nVerbose );
int S2_JAP_AVSwitch_Cisco_V2_08__78_Constructor ( START_STRUCTURE_DEFINITION( S2_JAP_AVSwitch_Cisco_V2_08, _78 ) * me, int nVerbose );
int S2_JAP_AVSwitch_Cisco_V2_08__78_Destructor ( START_STRUCTURE_DEFINITION( S2_JAP_AVSwitch_Cisco_V2_08, _78 ) * me, int nVerbose );

/*
* DIGITAL_INPUT
*/
#define __S2_JAP_AVSwitch_Cisco_V2_08___TRIGGER_SEND_NEXT_CMD_DIG_INPUT 0
#define __S2_JAP_AVSwitch_Cisco_V2_08___TRIGGER_HEARTBEAT_DIG_INPUT 1
#define __S2_JAP_AVSwitch_Cisco_V2_08___TRIGGER_PROCESS_SOCKET_RECEIVE_DIG_INPUT 2
#define __S2_JAP_AVSwitch_Cisco_V2_08_REFRESH_STATUS_DIG_INPUT 3
#define __S2_JAP_AVSwitch_Cisco_V2_08_START_MODULE_DIG_INPUT 4
#define __S2_JAP_AVSwitch_Cisco_V2_08_SEND_SAVE_DIG_INPUT 5


/*
* ANALOG_INPUT
*/

#define __S2_JAP_AVSwitch_Cisco_V2_08_FAVOUTITE_CMD_STRING_INPUT 0
#define __S2_JAP_AVSwitch_Cisco_V2_08_FAVOUTITE_CMD_STRING_MAX_LEN 1000
CREATE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, __FAVOUTITE_CMD, __S2_JAP_AVSwitch_Cisco_V2_08_FAVOUTITE_CMD_STRING_MAX_LEN );
#define __S2_JAP_AVSwitch_Cisco_V2_08_POE_CMD_STRING_INPUT 1
#define __S2_JAP_AVSwitch_Cisco_V2_08_POE_CMD_STRING_MAX_LEN 1000
CREATE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, __POE_CMD, __S2_JAP_AVSwitch_Cisco_V2_08_POE_CMD_STRING_MAX_LEN );
#define __S2_JAP_AVSwitch_Cisco_V2_08_DEBUGENABLE_STRING_INPUT 2
#define __S2_JAP_AVSwitch_Cisco_V2_08_DEBUGENABLE_STRING_MAX_LEN 50
CREATE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, __DEBUGENABLE, __S2_JAP_AVSwitch_Cisco_V2_08_DEBUGENABLE_STRING_MAX_LEN );
#define __S2_JAP_AVSwitch_Cisco_V2_08_CRESTRON_MAC_STRING_INPUT 3
#define __S2_JAP_AVSwitch_Cisco_V2_08_CRESTRON_MAC_STRING_MAX_LEN 200
CREATE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, __CRESTRON_MAC, __S2_JAP_AVSwitch_Cisco_V2_08_CRESTRON_MAC_STRING_MAX_LEN );


#define __S2_JAP_AVSwitch_Cisco_V2_08_OUTPUT_ANALOG_INPUT 4
#define __S2_JAP_AVSwitch_Cisco_V2_08_OUTPUT_ARRAY_LENGTH 404

/*
* DIGITAL_OUTPUT
*/
#define __S2_JAP_AVSwitch_Cisco_V2_08___TRIGGER_SEND_NEXT_CMD_OUT_DIG_OUTPUT 0
#define __S2_JAP_AVSwitch_Cisco_V2_08___TRIGGER_START_HEARTBEAT_OUT_DIG_OUTPUT 1
#define __S2_JAP_AVSwitch_Cisco_V2_08___SOCKET_RECEIVE_BUSY_DIG_OUTPUT 2
#define __S2_JAP_AVSwitch_Cisco_V2_08_REBOOTINGINPROGRESS_DIG_OUTPUT 3


/*
* ANALOG_OUTPUT
*/
#define __S2_JAP_AVSwitch_Cisco_V2_08_NUMOFOUTPUTS_ANALOG_OUTPUT 4
#define __S2_JAP_AVSwitch_Cisco_V2_08_NUMOFINPUTS_ANALOG_OUTPUT 5

#define __S2_JAP_AVSwitch_Cisco_V2_08_OPERATIONFB$_STRING_OUTPUT 0
#define __S2_JAP_AVSwitch_Cisco_V2_08_CRESTRONID$_STRING_OUTPUT 1
#define __S2_JAP_AVSwitch_Cisco_V2_08_VERSION$_STRING_OUTPUT 2
#define __S2_JAP_AVSwitch_Cisco_V2_08_ERRORMSG$_STRING_OUTPUT 3

#define __S2_JAP_AVSwitch_Cisco_V2_08_OUTPUTFB_ANALOG_OUTPUT 6
#define __S2_JAP_AVSwitch_Cisco_V2_08_OUTPUTFB_ARRAY_LENGTH 404

/*
* Direct Socket Variables
*/

#define __S2_JAP_AVSwitch_Cisco_V2_08_SWITCH_CLIENT_SOCKET 408
#define __S2_JAP_AVSwitch_Cisco_V2_08_SWITCH_CLIENT_STRING_MAX_LEN 64000
START_SOCKET_DEFINITION( S2_JAP_AVSwitch_Cisco_V2_08, __SWITCH_CLIENT )
{
   int SocketStatus;
   enum ESplusSocketType eSocketType;
   int SocketID;
   void *SocketPtr;
CREATE_SOCKET_STRING( S2_JAP_AVSwitch_Cisco_V2_08, SocketRxBuf, __S2_JAP_AVSwitch_Cisco_V2_08_SWITCH_CLIENT_STRING_MAX_LEN );
};



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
#define __S2_JAP_AVSwitch_Cisco_V2_08_P_SWITCHIP_STRING_PARAMETER 10
#define __S2_JAP_AVSwitch_Cisco_V2_08_P_SWITCHUSERNAME_STRING_PARAMETER 11
#define __S2_JAP_AVSwitch_Cisco_V2_08_P_SWITCHPASSWORD_STRING_PARAMETER 12
#define __S2_JAP_AVSwitch_Cisco_V2_08_P_SWITCHLICENCEKEY_STRING_PARAMETER 13
#define __S2_JAP_AVSwitch_Cisco_V2_08_P_SWITCHIP_PARAM_MAX_LEN 15
CREATE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, __P_SWITCHIP, __S2_JAP_AVSwitch_Cisco_V2_08_P_SWITCHIP_PARAM_MAX_LEN );
#define __S2_JAP_AVSwitch_Cisco_V2_08_P_SWITCHUSERNAME_PARAM_MAX_LEN 32
CREATE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, __P_SWITCHUSERNAME, __S2_JAP_AVSwitch_Cisco_V2_08_P_SWITCHUSERNAME_PARAM_MAX_LEN );
#define __S2_JAP_AVSwitch_Cisco_V2_08_P_SWITCHPASSWORD_PARAM_MAX_LEN 32
CREATE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, __P_SWITCHPASSWORD, __S2_JAP_AVSwitch_Cisco_V2_08_P_SWITCHPASSWORD_PARAM_MAX_LEN );
#define __S2_JAP_AVSwitch_Cisco_V2_08_P_SWITCHLICENCEKEY_PARAM_MAX_LEN 256
CREATE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, __P_SWITCHLICENCEKEY, __S2_JAP_AVSwitch_Cisco_V2_08_P_SWITCHLICENCEKEY_PARAM_MAX_LEN );


/*
* INTEGER
*/
CREATE_INTARRAY1D( S2_JAP_AVSwitch_Cisco_V2_08, ___94, 80 );;


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
#define __S2_JAP_AVSwitch_Cisco_V2_08__93_STRING_MAX_LEN 1000
CREATE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, ___93, __S2_JAP_AVSwitch_Cisco_V2_08__93_STRING_MAX_LEN );
#define __S2_JAP_AVSwitch_Cisco_V2_08__95_STRING_MAX_LEN 1000
CREATE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, ___95, __S2_JAP_AVSwitch_Cisco_V2_08__95_STRING_MAX_LEN );
#define __S2_JAP_AVSwitch_Cisco_V2_08__97_STRING_MAX_LEN 32
CREATE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, ___97, __S2_JAP_AVSwitch_Cisco_V2_08__97_STRING_MAX_LEN );
#define __S2_JAP_AVSwitch_Cisco_V2_08__99_STRING_MAX_LEN 500
CREATE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, ___99, __S2_JAP_AVSwitch_Cisco_V2_08__99_STRING_MAX_LEN );
#define __S2_JAP_AVSwitch_Cisco_V2_08__101_STRING_MAX_LEN 20
CREATE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, ___101, __S2_JAP_AVSwitch_Cisco_V2_08__101_STRING_MAX_LEN );
#define __S2_JAP_AVSwitch_Cisco_V2_08__100_ARRAY_NUM_ELEMS 404
#define __S2_JAP_AVSwitch_Cisco_V2_08__100_ARRAY_NUM_CHARS 10
CREATE_STRING_ARRAY( S2_JAP_AVSwitch_Cisco_V2_08, ___100, __S2_JAP_AVSwitch_Cisco_V2_08__100_ARRAY_NUM_ELEMS, __S2_JAP_AVSwitch_Cisco_V2_08__100_ARRAY_NUM_CHARS );
#define __S2_JAP_AVSwitch_Cisco_V2_08__106_ARRAY_NUM_ELEMS 1500
#define __S2_JAP_AVSwitch_Cisco_V2_08__106_ARRAY_NUM_CHARS 2
CREATE_STRING_ARRAY( S2_JAP_AVSwitch_Cisco_V2_08, ___106, __S2_JAP_AVSwitch_Cisco_V2_08__106_ARRAY_NUM_ELEMS, __S2_JAP_AVSwitch_Cisco_V2_08__106_ARRAY_NUM_CHARS );
#define __S2_JAP_AVSwitch_Cisco_V2_08__107_ARRAY_NUM_ELEMS 1500
#define __S2_JAP_AVSwitch_Cisco_V2_08__107_ARRAY_NUM_CHARS 2
CREATE_STRING_ARRAY( S2_JAP_AVSwitch_Cisco_V2_08, ___107, __S2_JAP_AVSwitch_Cisco_V2_08__107_ARRAY_NUM_ELEMS, __S2_JAP_AVSwitch_Cisco_V2_08__107_ARRAY_NUM_CHARS );

/*
* STRUCTURE
*/
#define __S2_JAP_AVSwitch_Cisco_V2_08__85_STRUCT_MAX_LEN 1000
CREATE_STRUCTURE_ARRAY( S2_JAP_AVSwitch_Cisco_V2_08, ___85, _78, __S2_JAP_AVSwitch_Cisco_V2_08__85_STRUCT_MAX_LEN );

START_GLOBAL_VAR_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __OUTPUT );
   DECLARE_IO_ARRAY( __OUTPUTFB );
   unsigned short ___89;
   unsigned short ___90;
   unsigned short ___91;
   unsigned short ___92;
   unsigned short ___96;
   unsigned short ___98;
   unsigned short ___102;
   unsigned short ___103;
   unsigned short ___104;
   unsigned short ___105;
   unsigned short ___108;
   unsigned short ___109;
   unsigned short ___110;
   unsigned short ___111;
   unsigned short ___112;
   unsigned short ___113;
   unsigned short ___114;
   DECLARE_INTARRAY( S2_JAP_AVSwitch_Cisco_V2_08, ___94 );
   DECLARE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, ___93 );
   DECLARE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, ___95 );
   DECLARE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, ___97 );
   DECLARE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, ___99 );
   DECLARE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, ___101 );
   DECLARE_STRING_ARRAY( S2_JAP_AVSwitch_Cisco_V2_08, ___100 );
   DECLARE_STRING_ARRAY( S2_JAP_AVSwitch_Cisco_V2_08, ___106 );
   DECLARE_STRING_ARRAY( S2_JAP_AVSwitch_Cisco_V2_08, ___107 );
   DECLARE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, __FAVOUTITE_CMD );
   DECLARE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, __POE_CMD );
   DECLARE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, __DEBUGENABLE );
   DECLARE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, __CRESTRON_MAC );
   DECLARE_SOCKET( S2_JAP_AVSwitch_Cisco_V2_08, __SWITCH_CLIENT );
   DECLARE_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, _63, ___71 );
   DECLARE_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, _72, ___77 );
   DECLARE_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, _78, ___86 );
   DECLARE_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, _41, ___87 );
   DECLARE_STRUCT_ARRAY( S2_JAP_AVSwitch_Cisco_V2_08, ___85 );
   DECLARE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, __P_SWITCHIP );
   DECLARE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, __P_SWITCHUSERNAME );
   DECLARE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, __P_SWITCHPASSWORD );
   DECLARE_STRING_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08, __P_SWITCHLICENCEKEY );
};

START_NVRAM_VAR_STRUCT( S2_JAP_AVSwitch_Cisco_V2_08 )
{
   unsigned short ___88;
};

DEFINE_WAITEVENT( S2_JAP_AVSwitch_Cisco_V2_08, WAIT_FOR_RX_SEND );
DEFINE_WAITEVENT( S2_JAP_AVSwitch_Cisco_V2_08, __SPLS_TMPVAR__WAITLABEL_0__ );
DEFINE_WAITEVENT( S2_JAP_AVSwitch_Cisco_V2_08, __SPLS_TMPVAR__WAITLABEL_1__ );
DEFINE_WAITEVENT( S2_JAP_AVSwitch_Cisco_V2_08, __SPLS_TMPVAR__WAITLABEL_2__ );
DEFINE_WAITEVENT( S2_JAP_AVSwitch_Cisco_V2_08, __SPLS_TMPVAR__WAITLABEL_3__ );
DEFINE_WAITEVENT( S2_JAP_AVSwitch_Cisco_V2_08, __SPLS_TMPVAR__WAITLABEL_4__ );


#endif //__S2_JAP_AVSWITCH_CISCO_V2_08_H__

