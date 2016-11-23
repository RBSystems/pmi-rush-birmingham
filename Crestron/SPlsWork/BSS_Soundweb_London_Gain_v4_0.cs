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

namespace UserModule_BSS_SOUNDWEB_LONDON_GAIN_V4_0
{
    public class UserModuleClass_BSS_SOUNDWEB_LONDON_GAIN_V4_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput MUTE__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalInput UNMUTE__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalInput POLARITYON__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalInput POLARITYOFF__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogInput GAIN__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput OBJECTID__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalInput SUBSCRIBE__DOLLAR__;
        Crestron.Logos.SplusObjects.BufferInput RX__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput MUTE_FB__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput POLARITY_FB__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogOutput GAIN_FB__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TX__DOLLAR__;
        ushort I = 0;
        ushort SUBSCRIBE = 0;
        CrestronString RETURNSTRING;
        ushort RETURNI = 0;
        ushort XOK = 0;
        ushort VOLUMEINPUT = 0;
        CrestronString TEMPSTRING;
        private CrestronString ITOVOLUMEPERCENT (  SplusExecutionContext __context__, ushort INT ) 
            { 
            
            __context__.SourceCodeLine = 60;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Mod( INT , 2 ) == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 62;
                RETURNSTRING  .UpdateValue ( "\u0000" + Functions.Chr (  (int) ( (INT / 2) ) ) + "\u0000\u0000"  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 66;
                RETURNSTRING  .UpdateValue ( "\u0000" + Functions.Chr (  (int) ( (INT / 2) ) ) + "\u0080\u0000"  ) ; 
                } 
            
            __context__.SourceCodeLine = 68;
            return ( RETURNSTRING ) ; 
            
            }
            
        private ushort VOLUMEPERCENTTOI (  SplusExecutionContext __context__, CrestronString STR ) 
            { 
            
            __context__.SourceCodeLine = 73;
            if ( Functions.TestForTrue  ( ( Functions.Not( Functions.BoolToInt (Functions.Mid( STR , (int)( 3 ) , (int)( 1 ) ) == "\u0000") ))  ) ) 
                { 
                __context__.SourceCodeLine = 75;
                RETURNI = (ushort) ( ((Byte( STR , (int)( 2 ) ) * 2) + 1) ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 79;
                RETURNI = (ushort) ( (Byte( STR , (int)( 2 ) ) * 2) ) ; 
                } 
            
            __context__.SourceCodeLine = 81;
            return (ushort)( RETURNI) ; 
            
            }
            
        object MUTE__DOLLAR___OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 89;
                MakeString ( TX__DOLLAR__ , "\u0088\u0000\u0000\u0003{0}\u0000\u0001\u0000\u0000\u0000\u0001\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ ) ; 
                __context__.SourceCodeLine = 90;
                if ( Functions.TestForTrue  ( ( SUBSCRIBE__DOLLAR__  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 92;
                    MakeString ( TX__DOLLAR__ , "\u0089\u0000\u0000\u0003{0}\u0000\u0001\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ ) ; 
                    __context__.SourceCodeLine = 93;
                    Functions.ProcessLogic ( ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object UNMUTE__DOLLAR___OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 99;
            MakeString ( TX__DOLLAR__ , "\u0088\u0000\u0000\u0003{0}\u0000\u0001\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 100;
            if ( Functions.TestForTrue  ( ( SUBSCRIBE__DOLLAR__  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 102;
                MakeString ( TX__DOLLAR__ , "\u0089\u0000\u0000\u0003{0}\u0000\u0001\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ ) ; 
                __context__.SourceCodeLine = 103;
                Functions.ProcessLogic ( ) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object POLARITYON__DOLLAR___OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 109;
        MakeString ( TX__DOLLAR__ , "\u0088\u0000\u0000\u0003{0}\u0000\u0002\u0000\u0000\u0000\u0001\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ ) ; 
        __context__.SourceCodeLine = 110;
        if ( Functions.TestForTrue  ( ( SUBSCRIBE__DOLLAR__  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 112;
            MakeString ( TX__DOLLAR__ , "\u0089\u0000\u0000\u0003{0}\u0000\u0002\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 113;
            Functions.ProcessLogic ( ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object POLARITYOFF__DOLLAR___OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 119;
        MakeString ( TX__DOLLAR__ , "\u0088\u0000\u0000\u0003{0}\u0000\u0002\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ ) ; 
        __context__.SourceCodeLine = 120;
        if ( Functions.TestForTrue  ( ( SUBSCRIBE__DOLLAR__  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 122;
            MakeString ( TX__DOLLAR__ , "\u0089\u0000\u0000\u0003{0}\u0000\u0002\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 123;
            Functions.ProcessLogic ( ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object GAIN__DOLLAR___OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 129;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (VOLUMEINPUT != GAIN__DOLLAR__  .UshortValue))  ) ) 
            { 
            __context__.SourceCodeLine = 131;
            VOLUMEINPUT = (ushort) ( GAIN__DOLLAR__  .UshortValue ) ; 
            __context__.SourceCodeLine = 132;
            GAIN_FB__DOLLAR__  .Value = (ushort) ( GAIN__DOLLAR__  .UshortValue ) ; 
            __context__.SourceCodeLine = 133;
            MakeString ( TX__DOLLAR__ , "\u008D\u0000\u0000\u0003{0}\u0000\u0000{1}\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , ITOVOLUMEPERCENT (  __context__ , (ushort)( GAIN__DOLLAR__  .UshortValue )) ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SUBSCRIBE__DOLLAR___OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 139;
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
        
            
            __context__.SourceCodeLine = 142;
            MakeString ( TX__DOLLAR__ , "\u008E\u0000\u0000\u0003{0}\u0000\u0000\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 143;
            Functions.ProcessLogic ( ) ; 
            __context__.SourceCodeLine = 144;
            MakeString ( TX__DOLLAR__ , "\u0089\u0000\u0000\u0003{0}\u0000\u0001\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 145;
            Functions.ProcessLogic ( ) ; 
            __context__.SourceCodeLine = 146;
            MakeString ( TX__DOLLAR__ , "\u0089\u0000\u0000\u0003{0}\u0000\u0002\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 147;
            Functions.ProcessLogic ( ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object SUBSCRIBE__DOLLAR___OnRelease_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 153;
        MakeString ( TX__DOLLAR__ , "\u008F\u0000\u0000\u0003{0}\u0000\u0000\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ ) ; 
        __context__.SourceCodeLine = 154;
        Functions.ProcessLogic ( ) ; 
        __context__.SourceCodeLine = 155;
        MakeString ( TX__DOLLAR__ , "\u008A\u0000\u0000\u0003{0}\u0000\u0001\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ ) ; 
        __context__.SourceCodeLine = 156;
        Functions.ProcessLogic ( ) ; 
        __context__.SourceCodeLine = 157;
        MakeString ( TX__DOLLAR__ , "\u008A\u0000\u0000\u0003{0}\u0000\u0002\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ ) ; 
        __context__.SourceCodeLine = 158;
        Functions.ProcessLogic ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RX__DOLLAR___OnChange_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 163;
        if ( Functions.TestForTrue  ( ( XOK)  ) ) 
            { 
            __context__.SourceCodeLine = 165;
            XOK = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 166;
            while ( Functions.TestForTrue  ( ( Functions.Length( RX__DOLLAR__ ))  ) ) 
                { 
                __context__.SourceCodeLine = 168;
                if ( Functions.TestForTrue  ( ( Functions.Find( "\u0003\u0003\u0003\u0003\u0003" , RX__DOLLAR__ ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 170;
                    TEMPSTRING  .UpdateValue ( Functions.Remove ( "\u0003\u0003\u0003\u0003\u0003" , RX__DOLLAR__ )  ) ; 
                    __context__.SourceCodeLine = 171;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Mid( TEMPSTRING , (int)( 6 ) , (int)( 3 ) ) == "\u0000\u0000\u0000") ) || Functions.TestForTrue ( Functions.BoolToInt (Functions.Mid( TEMPSTRING , (int)( 6 ) , (int)( 3 ) ) == OBJECTID__DOLLAR__) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 173;
                        
                            {
                            int __SPLS_TMPVAR__SWTCH_1__ = ((int)Byte( TEMPSTRING , (int)( 10 ) ));
                            
                                { 
                                if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 0) ) ) ) 
                                    { 
                                    __context__.SourceCodeLine = 177;
                                    VOLUMEINPUT = (ushort) ( VOLUMEPERCENTTOI( __context__ , Functions.Mid( TEMPSTRING , (int)( 11 ) , (int)( 4 ) ) ) ) ; 
                                    __context__.SourceCodeLine = 178;
                                    GAIN_FB__DOLLAR__  .Value = (ushort) ( VOLUMEINPUT ) ; 
                                    } 
                                
                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) ) ) ) 
                                    { 
                                    __context__.SourceCodeLine = 182;
                                    MUTE_FB__DOLLAR__  .Value = (ushort) ( Byte( TEMPSTRING , (int)( 14 ) ) ) ; 
                                    } 
                                
                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) ) ) ) 
                                    { 
                                    __context__.SourceCodeLine = 186;
                                    POLARITY_FB__DOLLAR__  .Value = (ushort) ( Byte( TEMPSTRING , (int)( 14 ) ) ) ; 
                                    } 
                                
                                } 
                                
                            }
                            
                        
                        } 
                    
                    __context__.SourceCodeLine = 190;
                    Functions.ClearBuffer ( TEMPSTRING ) ; 
                    } 
                
                __context__.SourceCodeLine = 166;
                } 
            
            __context__.SourceCodeLine = 193;
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
        
        __context__.SourceCodeLine = 203;
        XOK = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 204;
        SUBSCRIBE = (ushort) ( 0 ) ; 
        
        
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
    RETURNSTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
    TEMPSTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 40, this );
    
    MUTE__DOLLAR__ = new Crestron.Logos.SplusObjects.DigitalInput( MUTE__DOLLAR____DigitalInput__, this );
    m_DigitalInputList.Add( MUTE__DOLLAR____DigitalInput__, MUTE__DOLLAR__ );
    
    UNMUTE__DOLLAR__ = new Crestron.Logos.SplusObjects.DigitalInput( UNMUTE__DOLLAR____DigitalInput__, this );
    m_DigitalInputList.Add( UNMUTE__DOLLAR____DigitalInput__, UNMUTE__DOLLAR__ );
    
    POLARITYON__DOLLAR__ = new Crestron.Logos.SplusObjects.DigitalInput( POLARITYON__DOLLAR____DigitalInput__, this );
    m_DigitalInputList.Add( POLARITYON__DOLLAR____DigitalInput__, POLARITYON__DOLLAR__ );
    
    POLARITYOFF__DOLLAR__ = new Crestron.Logos.SplusObjects.DigitalInput( POLARITYOFF__DOLLAR____DigitalInput__, this );
    m_DigitalInputList.Add( POLARITYOFF__DOLLAR____DigitalInput__, POLARITYOFF__DOLLAR__ );
    
    SUBSCRIBE__DOLLAR__ = new Crestron.Logos.SplusObjects.DigitalInput( SUBSCRIBE__DOLLAR____DigitalInput__, this );
    m_DigitalInputList.Add( SUBSCRIBE__DOLLAR____DigitalInput__, SUBSCRIBE__DOLLAR__ );
    
    MUTE_FB__DOLLAR__ = new Crestron.Logos.SplusObjects.DigitalOutput( MUTE_FB__DOLLAR____DigitalOutput__, this );
    m_DigitalOutputList.Add( MUTE_FB__DOLLAR____DigitalOutput__, MUTE_FB__DOLLAR__ );
    
    POLARITY_FB__DOLLAR__ = new Crestron.Logos.SplusObjects.DigitalOutput( POLARITY_FB__DOLLAR____DigitalOutput__, this );
    m_DigitalOutputList.Add( POLARITY_FB__DOLLAR____DigitalOutput__, POLARITY_FB__DOLLAR__ );
    
    GAIN__DOLLAR__ = new Crestron.Logos.SplusObjects.AnalogInput( GAIN__DOLLAR____AnalogSerialInput__, this );
    m_AnalogInputList.Add( GAIN__DOLLAR____AnalogSerialInput__, GAIN__DOLLAR__ );
    
    GAIN_FB__DOLLAR__ = new Crestron.Logos.SplusObjects.AnalogOutput( GAIN_FB__DOLLAR____AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( GAIN_FB__DOLLAR____AnalogSerialOutput__, GAIN_FB__DOLLAR__ );
    
    OBJECTID__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( OBJECTID__DOLLAR____AnalogSerialInput__, 3, this );
    m_StringInputList.Add( OBJECTID__DOLLAR____AnalogSerialInput__, OBJECTID__DOLLAR__ );
    
    TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TX__DOLLAR____AnalogSerialOutput__, TX__DOLLAR__ );
    
    RX__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( RX__DOLLAR____AnalogSerialInput__, 400, this );
    m_StringInputList.Add( RX__DOLLAR____AnalogSerialInput__, RX__DOLLAR__ );
    
    __SPLS_TMPVAR__WAITLABEL_10___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_10___CallbackFn );
    
    MUTE__DOLLAR__.OnDigitalPush.Add( new InputChangeHandlerWrapper( MUTE__DOLLAR___OnPush_0, false ) );
    UNMUTE__DOLLAR__.OnDigitalPush.Add( new InputChangeHandlerWrapper( UNMUTE__DOLLAR___OnPush_1, false ) );
    POLARITYON__DOLLAR__.OnDigitalPush.Add( new InputChangeHandlerWrapper( POLARITYON__DOLLAR___OnPush_2, false ) );
    POLARITYOFF__DOLLAR__.OnDigitalPush.Add( new InputChangeHandlerWrapper( POLARITYOFF__DOLLAR___OnPush_3, false ) );
    GAIN__DOLLAR__.OnAnalogChange.Add( new InputChangeHandlerWrapper( GAIN__DOLLAR___OnChange_4, false ) );
    SUBSCRIBE__DOLLAR__.OnDigitalPush.Add( new InputChangeHandlerWrapper( SUBSCRIBE__DOLLAR___OnPush_5, false ) );
    SUBSCRIBE__DOLLAR__.OnDigitalRelease.Add( new InputChangeHandlerWrapper( SUBSCRIBE__DOLLAR___OnRelease_6, false ) );
    RX__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( RX__DOLLAR___OnChange_7, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_BSS_SOUNDWEB_LONDON_GAIN_V4_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction __SPLS_TMPVAR__WAITLABEL_10___Callback;


const uint MUTE__DOLLAR____DigitalInput__ = 0;
const uint UNMUTE__DOLLAR____DigitalInput__ = 1;
const uint POLARITYON__DOLLAR____DigitalInput__ = 2;
const uint POLARITYOFF__DOLLAR____DigitalInput__ = 3;
const uint GAIN__DOLLAR____AnalogSerialInput__ = 0;
const uint OBJECTID__DOLLAR____AnalogSerialInput__ = 1;
const uint SUBSCRIBE__DOLLAR____DigitalInput__ = 4;
const uint RX__DOLLAR____AnalogSerialInput__ = 2;
const uint MUTE_FB__DOLLAR____DigitalOutput__ = 0;
const uint POLARITY_FB__DOLLAR____DigitalOutput__ = 1;
const uint GAIN_FB__DOLLAR____AnalogSerialOutput__ = 0;
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
