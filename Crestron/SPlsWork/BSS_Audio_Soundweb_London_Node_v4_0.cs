using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace UserModule_BSS_AUDIO_SOUNDWEB_LONDON_NODE_V4_0
{
    public class UserModuleClass_BSS_AUDIO_SOUNDWEB_LONDON_NODE_V4_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.BufferInput MODULESTX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput NODE__DOLLAR__;
        Crestron.Logos.SplusObjects.BufferInput COMRX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MODULESRX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput COMTX__DOLLAR__;
        ushort XOK1 = 0;
        CrestronString TEMPSTRING1;
        ushort CHECKSUM = 0;
        ushort I = 0;
        CrestronString SENDSTRING;
        ushort XOK2 = 0;
        CrestronString TEMPSTRING2;
        CrestronString TEMPSTRING3;
        ushort J = 0;
        CrestronString RECEIVESTRING;
        ushort MARKER1 = 0;
        ushort MARKER2 = 0;
        private void SEND (  SplusExecutionContext __context__, CrestronString STR1 ) 
            { 
            
            __context__.SourceCodeLine = 57;
            CHECKSUM = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 58;
            SENDSTRING  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 59;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( STR1 ); 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 61;
                CHECKSUM = (ushort) ( (CHECKSUM ^ Byte( STR1 , (int)( I ) )) ) ; 
                __context__.SourceCodeLine = 62;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Byte( STR1 , (int)( I ) ) == 2) ) || Functions.TestForTrue ( Functions.BoolToInt (Byte( STR1 , (int)( I ) ) == 3) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (Byte( STR1 , (int)( I ) ) == 6) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (Byte( STR1 , (int)( I ) ) == 21) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (Byte( STR1 , (int)( I ) ) == 27) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 64;
                    MakeString ( SENDSTRING , "{0}\u001B{1}", SENDSTRING , Functions.Chr (  (int) ( (Byte( STR1 , (int)( I ) ) + 128) ) ) ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 68;
                    MakeString ( SENDSTRING , "{0}{1}", SENDSTRING , Functions.Chr (  (int) ( Byte( STR1 , (int)( I ) ) ) ) ) ; 
                    } 
                
                __context__.SourceCodeLine = 59;
                } 
            
            __context__.SourceCodeLine = 71;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (CHECKSUM == 2) ) || Functions.TestForTrue ( Functions.BoolToInt (CHECKSUM == 3) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (CHECKSUM == 6) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (CHECKSUM == 21) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (CHECKSUM == 27) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 73;
                MakeString ( COMTX__DOLLAR__ , "\u0002{0}\u001B{1}\u0003", SENDSTRING , Functions.Chr (  (int) ( (CHECKSUM + 128) ) ) ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 77;
                MakeString ( COMTX__DOLLAR__ , "\u0002{0}{1}\u0003", SENDSTRING , Functions.Chr (  (int) ( CHECKSUM ) ) ) ; 
                } 
            
            
            }
            
        private CrestronString RECEIVE (  SplusExecutionContext __context__, CrestronString STR2 ) 
            { 
            
            __context__.SourceCodeLine = 83;
            RECEIVESTRING  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 84;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( STR2 ); 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( J  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (J  >= __FN_FORSTART_VAL__1) && (J  <= __FN_FOREND_VAL__1) ) : ( (J  <= __FN_FORSTART_VAL__1) && (J  >= __FN_FOREND_VAL__1) ) ; J  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 86;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( STR2 , (int)( J ) ) == 27))  ) ) 
                    { 
                    __context__.SourceCodeLine = 88;
                    RECEIVESTRING  .UpdateValue ( RECEIVESTRING + Functions.Chr (  (int) ( (Byte( STR2 , (int)( (J + 1) ) ) - 128) ) )  ) ; 
                    __context__.SourceCodeLine = 89;
                    J = (ushort) ( (J + 1) ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 93;
                    RECEIVESTRING  .UpdateValue ( RECEIVESTRING + Functions.Chr (  (int) ( Byte( STR2 , (int)( J ) ) ) )  ) ; 
                    } 
                
                __context__.SourceCodeLine = 84;
                } 
            
            __context__.SourceCodeLine = 96;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( RECEIVESTRING , (int)( 1 ) ) == 6))  ) ) 
                { 
                __context__.SourceCodeLine = 98;
                RECEIVESTRING  .UpdateValue ( Functions.Right ( RECEIVESTRING ,  (int) ( (Functions.Length( RECEIVESTRING ) - 1) ) )  ) ; 
                __context__.SourceCodeLine = 96;
                } 
            
            __context__.SourceCodeLine = 100;
            return ( RECEIVESTRING ) ; 
            
            }
            
        object MODULESTX__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 108;
                if ( Functions.TestForTrue  ( ( XOK1)  ) ) 
                    { 
                    __context__.SourceCodeLine = 110;
                    XOK1 = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 111;
                    while ( Functions.TestForTrue  ( ( Functions.Length( MODULESTX__DOLLAR__ ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 113;
                        MARKER1 = (ushort) ( Functions.Find( "\u0003\u0003\u0003\u0003\u0003" , MODULESTX__DOLLAR__ ) ) ; 
                        __context__.SourceCodeLine = 114;
                        MARKER2 = (ushort) ( (MARKER1 + 5) ) ; 
                        __context__.SourceCodeLine = 115;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( MARKER2 <= Functions.Length( MODULESTX__DOLLAR__ ) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 117;
                            while ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( MODULESTX__DOLLAR__ , (int)( MARKER2 ) ) == 3))  ) ) 
                                { 
                                __context__.SourceCodeLine = 119;
                                MARKER1 = (ushort) ( (MARKER1 + 1) ) ; 
                                __context__.SourceCodeLine = 120;
                                MARKER2 = (ushort) ( (MARKER2 + 1) ) ; 
                                __context__.SourceCodeLine = 121;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( MARKER2 > Functions.Length( MODULESTX__DOLLAR__ ) ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 123;
                                    break ; 
                                    } 
                                
                                __context__.SourceCodeLine = 117;
                                } 
                            
                            } 
                        
                        __context__.SourceCodeLine = 127;
                        if ( Functions.TestForTrue  ( ( MARKER1)  ) ) 
                            { 
                            __context__.SourceCodeLine = 129;
                            MARKER1 = (ushort) ( (MARKER1 + 4) ) ; 
                            __context__.SourceCodeLine = 130;
                            TEMPSTRING1  .UpdateValue ( Functions.Remove ( Functions.Mid ( MODULESTX__DOLLAR__ ,  (int) ( 1 ) ,  (int) ( MARKER1 ) ) , MODULESTX__DOLLAR__ )  ) ; 
                            __context__.SourceCodeLine = 131;
                            MakeString ( TEMPSTRING1 , "{0}{1}{2}", Functions.Left ( TEMPSTRING1 ,  (int) ( 1 ) ) , NODE__DOLLAR__ , Functions.Right ( TEMPSTRING1 ,  (int) ( (Functions.Length( TEMPSTRING1 ) - 3) ) ) ) ; 
                            __context__.SourceCodeLine = 132;
                            SEND (  __context__ , Functions.Left( TEMPSTRING1 , (int)( (Functions.Length( TEMPSTRING1 ) - 5) ) )) ; 
                            __context__.SourceCodeLine = 133;
                            Functions.ClearBuffer ( TEMPSTRING1 ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 111;
                        } 
                    
                    __context__.SourceCodeLine = 136;
                    XOK1 = (ushort) ( 1 ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object COMRX__DOLLAR___OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 142;
            if ( Functions.TestForTrue  ( ( XOK2)  ) ) 
                { 
                __context__.SourceCodeLine = 144;
                XOK2 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 145;
                while ( Functions.TestForTrue  ( ( Functions.Length( COMRX__DOLLAR__ ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 147;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( COMRX__DOLLAR__ , (int)( 1 ) ) == 6))  ) ) 
                        { 
                        __context__.SourceCodeLine = 149;
                        TEMPSTRING2  .UpdateValue ( Functions.Remove ( "\u0006" , COMRX__DOLLAR__ )  ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 153;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "\u0003" , COMRX__DOLLAR__ ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 155;
                            TEMPSTRING2  .UpdateValue ( Functions.Remove ( "\u0003" , COMRX__DOLLAR__ )  ) ; 
                            __context__.SourceCodeLine = 156;
                            TEMPSTRING3  .UpdateValue ( RECEIVE (  __context__ , TEMPSTRING2)  ) ; 
                            __context__.SourceCodeLine = 157;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( TEMPSTRING3 ) >= 4 ) ) && Functions.TestForTrue ( Functions.BoolToInt (Byte( TEMPSTRING3 , (int)( 3 ) ) == Byte( NODE__DOLLAR__ , (int)( 1 ) )) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (Byte( TEMPSTRING3 , (int)( 4 ) ) == Byte( NODE__DOLLAR__ , (int)( 2 ) )) )) ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 159;
                                MODULESRX__DOLLAR__  .UpdateValue ( TEMPSTRING3 + "\u0003\u0003\u0003\u0003"  ) ; 
                                } 
                            
                            } 
                        
                        } 
                    
                    __context__.SourceCodeLine = 163;
                    Functions.ClearBuffer ( TEMPSTRING2 ) ; 
                    __context__.SourceCodeLine = 164;
                    Functions.ClearBuffer ( TEMPSTRING3 ) ; 
                    __context__.SourceCodeLine = 145;
                    } 
                
                __context__.SourceCodeLine = 166;
                XOK2 = (ushort) ( 1 ) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 176;
        XOK1 = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 177;
        XOK2 = (ushort) ( 1 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    SocketInfo __socketinfo__ = new SocketInfo( 1, this );
    InitialParametersClass.ResolveHostName = __socketinfo__.ResolveHostName;
    _SplusNVRAM = new SplusNVRAM( this );
    TEMPSTRING1  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 80, this );
    SENDSTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 80, this );
    TEMPSTRING2  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 80, this );
    TEMPSTRING3  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 80, this );
    RECEIVESTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 80, this );
    
    NODE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( NODE__DOLLAR____AnalogSerialInput__, 2, this );
    m_StringInputList.Add( NODE__DOLLAR____AnalogSerialInput__, NODE__DOLLAR__ );
    
    MODULESRX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MODULESRX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MODULESRX__DOLLAR____AnalogSerialOutput__, MODULESRX__DOLLAR__ );
    
    COMTX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( COMTX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( COMTX__DOLLAR____AnalogSerialOutput__, COMTX__DOLLAR__ );
    
    MODULESTX__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( MODULESTX__DOLLAR____AnalogSerialInput__, 1000, this );
    m_StringInputList.Add( MODULESTX__DOLLAR____AnalogSerialInput__, MODULESTX__DOLLAR__ );
    
    COMRX__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( COMRX__DOLLAR____AnalogSerialInput__, 1000, this );
    m_StringInputList.Add( COMRX__DOLLAR____AnalogSerialInput__, COMRX__DOLLAR__ );
    
    
    MODULESTX__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( MODULESTX__DOLLAR___OnChange_0, false ) );
    COMRX__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( COMRX__DOLLAR___OnChange_1, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_BSS_AUDIO_SOUNDWEB_LONDON_NODE_V4_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint MODULESTX__DOLLAR____AnalogSerialInput__ = 0;
const uint NODE__DOLLAR____AnalogSerialInput__ = 1;
const uint COMRX__DOLLAR____AnalogSerialInput__ = 2;
const uint MODULESRX__DOLLAR____AnalogSerialOutput__ = 0;
const uint COMTX__DOLLAR____AnalogSerialOutput__ = 1;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
