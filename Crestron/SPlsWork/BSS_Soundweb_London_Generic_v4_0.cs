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

namespace UserModule_BSS_SOUNDWEB_LONDON_GENERIC_V4_0
{
    public class UserModuleClass_BSS_SOUNDWEB_LONDON_GENERIC_V4_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.AnalogInput VALUE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput OBJECTID__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogInput STATEVARIABLE__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalInput SUBSCRIBE__DOLLAR__;
        Crestron.Logos.SplusObjects.BufferInput RX__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogOutput VALUE_FB__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TX__DOLLAR__;
        ushort XOK = 0;
        CrestronString TEMPSTRING;
        CrestronString STATEVARIABLE;
        object STATEVARIABLE__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 54;
                STATEVARIABLE  .UpdateValue ( Functions.Chr (  (int) ( Functions.High( (ushort) STATEVARIABLE__DOLLAR__  .UshortValue ) ) ) + Functions.Chr (  (int) ( Functions.Low( (ushort) STATEVARIABLE__DOLLAR__  .UshortValue ) ) )  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object VALUE__DOLLAR___OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 59;
            MakeString ( TX__DOLLAR__ , "\u0088\u0000\u0000\u0003{0}{1}\u0000\u0000{2}{3}\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , STATEVARIABLE , Functions.Chr (  (int) ( Functions.High( (ushort) VALUE__DOLLAR__  .UshortValue ) ) ) , Functions.Chr (  (int) ( Functions.Low( (ushort) VALUE__DOLLAR__  .UshortValue ) ) ) ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object SUBSCRIBE__DOLLAR___OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 64;
        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_19__" , 20 , __SPLS_TMPVAR__WAITLABEL_19___Callback ) ;
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void __SPLS_TMPVAR__WAITLABEL_19___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 66;
            MakeString ( TX__DOLLAR__ , "\u0089\u0000\u0000\u0003{0}{1}\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , STATEVARIABLE ) ; 
            __context__.SourceCodeLine = 67;
            Functions.ProcessLogic ( ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object SUBSCRIBE__DOLLAR___OnRelease_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 73;
        MakeString ( TX__DOLLAR__ , "\u008A\u0000\u0000\u0003{0}{1}\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , STATEVARIABLE ) ; 
        __context__.SourceCodeLine = 74;
        Functions.ProcessLogic ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RX__DOLLAR___OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 79;
        if ( Functions.TestForTrue  ( ( XOK)  ) ) 
            { 
            __context__.SourceCodeLine = 81;
            XOK = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 82;
            while ( Functions.TestForTrue  ( ( Functions.Length( RX__DOLLAR__ ))  ) ) 
                { 
                __context__.SourceCodeLine = 84;
                if ( Functions.TestForTrue  ( ( Functions.Find( "\u0003\u0003\u0003\u0003\u0003" , RX__DOLLAR__ ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 86;
                    TEMPSTRING  .UpdateValue ( Functions.Remove ( "\u0003\u0003\u0003\u0003\u0003" , RX__DOLLAR__ )  ) ; 
                    __context__.SourceCodeLine = 87;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Mid( TEMPSTRING , (int)( 6 ) , (int)( 3 ) ) == "\u0000\u0000\u0000") ) || Functions.TestForTrue ( Functions.BoolToInt (Functions.Mid( TEMPSTRING , (int)( 6 ) , (int)( 3 ) ) == OBJECTID__DOLLAR__) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 89;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Byte( TEMPSTRING , (int)( 9 ) ) == Byte( STATEVARIABLE , (int)( 1 ) )) ) && Functions.TestForTrue ( Functions.BoolToInt (Byte( TEMPSTRING , (int)( 10 ) ) == Byte( STATEVARIABLE , (int)( 2 ) )) )) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 91;
                            VALUE_FB__DOLLAR__  .Value = (ushort) ( ((Byte( TEMPSTRING , (int)( 13 ) ) * 256) + Byte( TEMPSTRING , (int)( 14 ) )) ) ; 
                            } 
                        
                        } 
                    
                    __context__.SourceCodeLine = 94;
                    Functions.ClearBuffer ( TEMPSTRING ) ; 
                    } 
                
                __context__.SourceCodeLine = 82;
                } 
            
            __context__.SourceCodeLine = 97;
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
        
        __context__.SourceCodeLine = 107;
        XOK = (ushort) ( 1 ) ; 
        
        
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
    TEMPSTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 40, this );
    STATEVARIABLE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
    
    SUBSCRIBE__DOLLAR__ = new Crestron.Logos.SplusObjects.DigitalInput( SUBSCRIBE__DOLLAR____DigitalInput__, this );
    m_DigitalInputList.Add( SUBSCRIBE__DOLLAR____DigitalInput__, SUBSCRIBE__DOLLAR__ );
    
    VALUE__DOLLAR__ = new Crestron.Logos.SplusObjects.AnalogInput( VALUE__DOLLAR____AnalogSerialInput__, this );
    m_AnalogInputList.Add( VALUE__DOLLAR____AnalogSerialInput__, VALUE__DOLLAR__ );
    
    STATEVARIABLE__DOLLAR__ = new Crestron.Logos.SplusObjects.AnalogInput( STATEVARIABLE__DOLLAR____AnalogSerialInput__, this );
    m_AnalogInputList.Add( STATEVARIABLE__DOLLAR____AnalogSerialInput__, STATEVARIABLE__DOLLAR__ );
    
    VALUE_FB__DOLLAR__ = new Crestron.Logos.SplusObjects.AnalogOutput( VALUE_FB__DOLLAR____AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( VALUE_FB__DOLLAR____AnalogSerialOutput__, VALUE_FB__DOLLAR__ );
    
    OBJECTID__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( OBJECTID__DOLLAR____AnalogSerialInput__, 3, this );
    m_StringInputList.Add( OBJECTID__DOLLAR____AnalogSerialInput__, OBJECTID__DOLLAR__ );
    
    TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TX__DOLLAR____AnalogSerialOutput__, TX__DOLLAR__ );
    
    RX__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( RX__DOLLAR____AnalogSerialInput__, 400, this );
    m_StringInputList.Add( RX__DOLLAR____AnalogSerialInput__, RX__DOLLAR__ );
    
    __SPLS_TMPVAR__WAITLABEL_19___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_19___CallbackFn );
    
    STATEVARIABLE__DOLLAR__.OnAnalogChange.Add( new InputChangeHandlerWrapper( STATEVARIABLE__DOLLAR___OnChange_0, false ) );
    VALUE__DOLLAR__.OnAnalogChange.Add( new InputChangeHandlerWrapper( VALUE__DOLLAR___OnChange_1, false ) );
    SUBSCRIBE__DOLLAR__.OnDigitalPush.Add( new InputChangeHandlerWrapper( SUBSCRIBE__DOLLAR___OnPush_2, false ) );
    SUBSCRIBE__DOLLAR__.OnDigitalRelease.Add( new InputChangeHandlerWrapper( SUBSCRIBE__DOLLAR___OnRelease_3, false ) );
    RX__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( RX__DOLLAR___OnChange_4, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_BSS_SOUNDWEB_LONDON_GENERIC_V4_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction __SPLS_TMPVAR__WAITLABEL_19___Callback;


const uint VALUE__DOLLAR____AnalogSerialInput__ = 0;
const uint OBJECTID__DOLLAR____AnalogSerialInput__ = 1;
const uint STATEVARIABLE__DOLLAR____AnalogSerialInput__ = 2;
const uint SUBSCRIBE__DOLLAR____DigitalInput__ = 0;
const uint RX__DOLLAR____AnalogSerialInput__ = 3;
const uint VALUE_FB__DOLLAR____AnalogSerialOutput__ = 0;
const uint TX__DOLLAR____AnalogSerialOutput__ = 1;

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
