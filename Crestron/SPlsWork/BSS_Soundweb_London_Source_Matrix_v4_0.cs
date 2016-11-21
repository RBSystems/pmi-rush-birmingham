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

namespace UserModule_BSS_SOUNDWEB_LONDON_SOURCE_MATRIX_V4_0
{
    public class UserModuleClass_BSS_SOUNDWEB_LONDON_SOURCE_MATRIX_V4_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput SUBSCRIBE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput OBJECTID__DOLLAR__;
        Crestron.Logos.SplusObjects.BufferInput RX__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogInput IMAXOUTPUT;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> INPUTFOROUTPUT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TX__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> INPUTFOROUTPUT_FB__DOLLAR__;
        ushort XOK = 0;
        ushort I = 0;
        CrestronString TEMPSTRING;
        ushort X = 0;
        ushort XINDEX = 0;
        ushort STATEVAR = 0;
        ushort SUBSCRIBE = 0;
        object INPUTFOROUTPUT__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 52;
                XINDEX = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
                __context__.SourceCodeLine = 53;
                STATEVAR = (ushort) ( (XINDEX - 1) ) ; 
                __context__.SourceCodeLine = 54;
                MakeString ( TX__DOLLAR__ , "\u0088\u0000\u0000\u0003{0}\u0000{1}\u0000\u0000\u0000{2}\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( STATEVAR ) ) , Functions.Chr (  (int) ( INPUTFOROUTPUT__DOLLAR__[ (STATEVAR + 1) ] .UshortValue ) ) ) ; 
                __context__.SourceCodeLine = 55;
                if ( Functions.TestForTrue  ( ( SUBSCRIBE)  ) ) 
                    { 
                    __context__.SourceCodeLine = 57;
                    MakeString ( TX__DOLLAR__ , "\u0089\u0000\u0000\u0003{0}\u0000{1}\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( (XINDEX - 1) ) ) ) ; 
                    __context__.SourceCodeLine = 58;
                    Functions.ProcessLogic ( ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object SUBSCRIBE__DOLLAR___OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 64;
            CreateWait ( "__SPLS_TMPVAR__WAITLABEL_10__" , 20 , __SPLS_TMPVAR__WAITLABEL_10___Callback ) ;
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
public void __SPLS_TMPVAR__WAITLABEL_10___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 66;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)IMAXOUTPUT  .UshortValue; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 68;
                MakeString ( TX__DOLLAR__ , "\u0089\u0000\u0000\u0003{0}\u0000{1}\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( (I - 1) ) ) ) ; 
                __context__.SourceCodeLine = 69;
                Functions.ProcessLogic ( ) ; 
                __context__.SourceCodeLine = 66;
                } 
            
            __context__.SourceCodeLine = 71;
            SUBSCRIBE = (ushort) ( SUBSCRIBE__DOLLAR__  .Value ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object SUBSCRIBE__DOLLAR___OnRelease_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 77;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)IMAXOUTPUT  .UshortValue; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 79;
            MakeString ( TX__DOLLAR__ , "\u008A\u0000\u0000\u0003{0}\u0000{1}\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( (I - 1) ) ) ) ; 
            __context__.SourceCodeLine = 80;
            Functions.ProcessLogic ( ) ; 
            __context__.SourceCodeLine = 77;
            } 
        
        __context__.SourceCodeLine = 82;
        SUBSCRIBE = (ushort) ( SUBSCRIBE__DOLLAR__  .Value ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RX__DOLLAR___OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 87;
        if ( Functions.TestForTrue  ( ( XOK)  ) ) 
            { 
            __context__.SourceCodeLine = 89;
            XOK = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 90;
            while ( Functions.TestForTrue  ( ( Functions.Length( RX__DOLLAR__ ))  ) ) 
                { 
                __context__.SourceCodeLine = 92;
                if ( Functions.TestForTrue  ( ( Functions.Find( "\u0003\u0003\u0003\u0003\u0003" , RX__DOLLAR__ ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 94;
                    TEMPSTRING  .UpdateValue ( Functions.Remove ( "\u0003\u0003\u0003\u0003\u0003" , RX__DOLLAR__ )  ) ; 
                    __context__.SourceCodeLine = 95;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Mid( TEMPSTRING , (int)( 6 ) , (int)( 3 ) ) == "\u0000\u0000\u0000") ) || Functions.TestForTrue ( Functions.BoolToInt (Functions.Mid( TEMPSTRING , (int)( 6 ) , (int)( 3 ) ) == OBJECTID__DOLLAR__) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 97;
                        INPUTFOROUTPUT_FB__DOLLAR__ [ (Byte( TEMPSTRING , (int)( 10 ) ) + 1)]  .Value = (ushort) ( Byte( TEMPSTRING , (int)( 14 ) ) ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 99;
                    Functions.ClearBuffer ( TEMPSTRING ) ; 
                    } 
                
                __context__.SourceCodeLine = 90;
                } 
            
            __context__.SourceCodeLine = 102;
            XOK = (ushort) ( 1 ) ; 
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
        
        __context__.SourceCodeLine = 112;
        XOK = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 113;
        SUBSCRIBE = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    TEMPSTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 40, this );
    
    SUBSCRIBE__DOLLAR__ = new Crestron.Logos.SplusObjects.DigitalInput( SUBSCRIBE__DOLLAR____DigitalInput__, this );
    m_DigitalInputList.Add( SUBSCRIBE__DOLLAR____DigitalInput__, SUBSCRIBE__DOLLAR__ );
    
    IMAXOUTPUT = new Crestron.Logos.SplusObjects.AnalogInput( IMAXOUTPUT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( IMAXOUTPUT__AnalogSerialInput__, IMAXOUTPUT );
    
    INPUTFOROUTPUT__DOLLAR__ = new InOutArray<AnalogInput>( 96, this );
    for( uint i = 0; i < 96; i++ )
    {
        INPUTFOROUTPUT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( INPUTFOROUTPUT__DOLLAR____AnalogSerialInput__ + i, INPUTFOROUTPUT__DOLLAR____AnalogSerialInput__, this );
        m_AnalogInputList.Add( INPUTFOROUTPUT__DOLLAR____AnalogSerialInput__ + i, INPUTFOROUTPUT__DOLLAR__[i+1] );
    }
    
    INPUTFOROUTPUT_FB__DOLLAR__ = new InOutArray<AnalogOutput>( 96, this );
    for( uint i = 0; i < 96; i++ )
    {
        INPUTFOROUTPUT_FB__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( INPUTFOROUTPUT_FB__DOLLAR____AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( INPUTFOROUTPUT_FB__DOLLAR____AnalogSerialOutput__ + i, INPUTFOROUTPUT_FB__DOLLAR__[i+1] );
    }
    
    OBJECTID__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( OBJECTID__DOLLAR____AnalogSerialInput__, 3, this );
    m_StringInputList.Add( OBJECTID__DOLLAR____AnalogSerialInput__, OBJECTID__DOLLAR__ );
    
    TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TX__DOLLAR____AnalogSerialOutput__, TX__DOLLAR__ );
    
    RX__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( RX__DOLLAR____AnalogSerialInput__, 400, this );
    m_StringInputList.Add( RX__DOLLAR____AnalogSerialInput__, RX__DOLLAR__ );
    
    __SPLS_TMPVAR__WAITLABEL_10___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_10___CallbackFn );
    
    for( uint i = 0; i < 96; i++ )
        INPUTFOROUTPUT__DOLLAR__[i+1].OnAnalogChange.Add( new InputChangeHandlerWrapper( INPUTFOROUTPUT__DOLLAR___OnChange_0, false ) );
        
    SUBSCRIBE__DOLLAR__.OnDigitalPush.Add( new InputChangeHandlerWrapper( SUBSCRIBE__DOLLAR___OnPush_1, false ) );
    SUBSCRIBE__DOLLAR__.OnDigitalRelease.Add( new InputChangeHandlerWrapper( SUBSCRIBE__DOLLAR___OnRelease_2, false ) );
    RX__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( RX__DOLLAR___OnChange_3, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_BSS_SOUNDWEB_LONDON_SOURCE_MATRIX_V4_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction __SPLS_TMPVAR__WAITLABEL_10___Callback;


const uint SUBSCRIBE__DOLLAR____DigitalInput__ = 0;
const uint OBJECTID__DOLLAR____AnalogSerialInput__ = 0;
const uint RX__DOLLAR____AnalogSerialInput__ = 1;
const uint IMAXOUTPUT__AnalogSerialInput__ = 2;
const uint INPUTFOROUTPUT__DOLLAR____AnalogSerialInput__ = 3;
const uint TX__DOLLAR____AnalogSerialOutput__ = 0;
const uint INPUTFOROUTPUT_FB__DOLLAR____AnalogSerialOutput__ = 1;

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
