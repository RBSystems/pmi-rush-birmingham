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

namespace UserModule_BSS_SOUNDWEB_LONDON_ROOM_COMBINE_V4_0
{
    public class UserModuleClass_BSS_SOUNDWEB_LONDON_ROOM_COMBINE_V4_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput ENABLE_FEEDBACK__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput OBJECTID__DOLLAR__;
        Crestron.Logos.SplusObjects.BufferInput RX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TX__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> SOURCEMUTE__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> BGM_MUTE__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> MASTERMUTE__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> PARTITION__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> SOURCE_GAINS_CHANGE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> BGM_GAINS_CHANGE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> MASTER_GAINS_CHANGE;
        Crestron.Logos.SplusObjects.AnalogInput CHAN_OFFSET__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogInput MAX_ROOMS__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> SOURCEGAIN__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> BGM_GAIN__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> MASTERGAIN__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> BGM_INPUT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> GROUP__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> SOURCEMUTE_FB__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> BGM_MUTE_FB__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> MASTERMUTE_FB__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> PARTITION_FB__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> SOURCEGAIN_FB__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> BGM_GAIN_FB__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> MASTERGAIN_FB__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> BGM_INPUT_FB__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> GROUP_FB__DOLLAR__;
        private CrestronString ITOVOLUMEPERCENT (  SplusExecutionContext __context__, ushort INT ) 
            { 
            
            __context__.SourceCodeLine = 133;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Mod( INT , 2 ) == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 135;
                _SplusNVRAM.RETURNSTRING  .UpdateValue ( "\u0000" + Functions.Chr (  (int) ( (INT / 2) ) ) + "\u0000\u0000"  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 139;
                _SplusNVRAM.RETURNSTRING  .UpdateValue ( "\u0000" + Functions.Chr (  (int) ( (INT / 2) ) ) + "\u0080\u0000"  ) ; 
                } 
            
            __context__.SourceCodeLine = 141;
            return ( _SplusNVRAM.RETURNSTRING ) ; 
            
            }
            
        private ushort VOLUMEPERCENTTOI (  SplusExecutionContext __context__, CrestronString STR ) 
            { 
            
            __context__.SourceCodeLine = 147;
            if ( Functions.TestForTrue  ( ( Functions.Not( Functions.BoolToInt (Functions.Mid( STR , (int)( 3 ) , (int)( 1 ) ) == "\u0000") ))  ) ) 
                { 
                __context__.SourceCodeLine = 149;
                _SplusNVRAM.RETURNI = (ushort) ( ((Byte( STR , (int)( 2 ) ) * 2) + 1) ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 153;
                _SplusNVRAM.RETURNI = (ushort) ( (Byte( STR , (int)( 2 ) ) * 2) ) ; 
                } 
            
            __context__.SourceCodeLine = 155;
            return (ushort)( _SplusNVRAM.RETURNI) ; 
            
            }
            
        object CHAN_OFFSET__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 165;
                _SplusNVRAM.OFFSET = (ushort) ( (CHAN_OFFSET__DOLLAR__  .UshortValue * 8) ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object ENABLE_FEEDBACK__DOLLAR___OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 171;
            CreateWait ( "__SPLS_TMPVAR__WAITLABEL_12__" , 20 , __SPLS_TMPVAR__WAITLABEL_12___Callback ) ;
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
public void __SPLS_TMPVAR__WAITLABEL_12___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 173;
            _SplusNVRAM.FEEDBACK = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 175;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)MAX_ROOMS__DOLLAR__  .UshortValue; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( _SplusNVRAM.I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_SplusNVRAM.I  >= __FN_FORSTART_VAL__1) && (_SplusNVRAM.I  <= __FN_FOREND_VAL__1) ) : ( (_SplusNVRAM.I  <= __FN_FORSTART_VAL__1) && (_SplusNVRAM.I  >= __FN_FOREND_VAL__1) ) ; _SplusNVRAM.I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 177;
                _SplusNVRAM.STATEVARSUB = (ushort) ( ((((_SplusNVRAM.I + _SplusNVRAM.OFFSET) - 1) * 50) + 256) ) ; 
                __context__.SourceCodeLine = 178;
                MakeString ( TX__DOLLAR__ , "\u0089\u0000\u0000\u0003{0}{1}{2}\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( Functions.High( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) , Functions.Chr (  (int) ( Functions.Low( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) ) ; 
                __context__.SourceCodeLine = 179;
                _SplusNVRAM.STATEVARSUB = (ushort) ( ((((_SplusNVRAM.I + _SplusNVRAM.OFFSET) - 1) * 50) + 258) ) ; 
                __context__.SourceCodeLine = 180;
                MakeString ( TX__DOLLAR__ , "\u0089\u0000\u0000\u0003{0}{1}{2}\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( Functions.High( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) , Functions.Chr (  (int) ( Functions.Low( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) ) ; 
                __context__.SourceCodeLine = 181;
                _SplusNVRAM.STATEVARSUB = (ushort) ( ((((_SplusNVRAM.I + _SplusNVRAM.OFFSET) - 1) * 50) + 254) ) ; 
                __context__.SourceCodeLine = 182;
                MakeString ( TX__DOLLAR__ , "\u0089\u0000\u0000\u0003{0}{1}{2}\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( Functions.High( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) , Functions.Chr (  (int) ( Functions.Low( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) ) ; 
                __context__.SourceCodeLine = 184;
                _SplusNVRAM.STATEVARSUB = (ushort) ( ((((_SplusNVRAM.I + _SplusNVRAM.OFFSET) - 1) * 50) + 255) ) ; 
                __context__.SourceCodeLine = 185;
                MakeString ( TX__DOLLAR__ , "\u008E\u0000\u0000\u0003{0}{1}{2}{3}\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( Functions.High( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) , Functions.Chr (  (int) ( Functions.Low( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) , "\u0000\u0000\u0000\u0000" ) ; 
                __context__.SourceCodeLine = 186;
                _SplusNVRAM.STATEVARSUB = (ushort) ( ((((_SplusNVRAM.I + _SplusNVRAM.OFFSET) - 1) * 50) + 257) ) ; 
                __context__.SourceCodeLine = 187;
                MakeString ( TX__DOLLAR__ , "\u008E\u0000\u0000\u0003{0}{1}{2}{3}\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( Functions.High( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) , Functions.Chr (  (int) ( Functions.Low( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) , "\u0000\u0000\u0000\u0000" ) ; 
                __context__.SourceCodeLine = 188;
                _SplusNVRAM.STATEVARSUB = (ushort) ( ((((_SplusNVRAM.I + _SplusNVRAM.OFFSET) - 1) * 50) + 252) ) ; 
                __context__.SourceCodeLine = 189;
                MakeString ( TX__DOLLAR__ , "\u008E\u0000\u0000\u0003{0}{1}{2}{3}\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( Functions.High( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) , Functions.Chr (  (int) ( Functions.Low( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) , "\u0000\u0000\u0000\u0000" ) ; 
                __context__.SourceCodeLine = 191;
                _SplusNVRAM.STATEVARSUB = (ushort) ( ((((_SplusNVRAM.I + _SplusNVRAM.OFFSET) - 1) * 50) + 259) ) ; 
                __context__.SourceCodeLine = 192;
                MakeString ( TX__DOLLAR__ , "\u0089\u0000\u0000\u0003{0}{1}{2}\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( Functions.High( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) , Functions.Chr (  (int) ( Functions.Low( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) ) ; 
                __context__.SourceCodeLine = 194;
                _SplusNVRAM.STATEVARSUB = (ushort) ( ((_SplusNVRAM.I + _SplusNVRAM.OFFSET) - 1) ) ; 
                __context__.SourceCodeLine = 195;
                MakeString ( TX__DOLLAR__ , "\u0089\u0000\u0000\u0003{0}{1}{2}\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( Functions.High( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) , Functions.Chr (  (int) ( Functions.Low( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) ) ; 
                __context__.SourceCodeLine = 197;
                _SplusNVRAM.STATEVARSUB = (ushort) ( ((((_SplusNVRAM.I + _SplusNVRAM.OFFSET) - 1) * 50) + 250) ) ; 
                __context__.SourceCodeLine = 198;
                MakeString ( TX__DOLLAR__ , "\u0089\u0000\u0000\u0003{0}{1}{2}\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( Functions.High( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) , Functions.Chr (  (int) ( Functions.Low( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) ) ; 
                __context__.SourceCodeLine = 175;
                } 
            
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object ENABLE_FEEDBACK__DOLLAR___OnRelease_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 205;
        _SplusNVRAM.FEEDBACK = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 207;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)MAX_ROOMS__DOLLAR__  .UshortValue; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( _SplusNVRAM.I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_SplusNVRAM.I  >= __FN_FORSTART_VAL__1) && (_SplusNVRAM.I  <= __FN_FOREND_VAL__1) ) : ( (_SplusNVRAM.I  <= __FN_FORSTART_VAL__1) && (_SplusNVRAM.I  >= __FN_FOREND_VAL__1) ) ; _SplusNVRAM.I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 209;
            _SplusNVRAM.STATEVARSUB = (ushort) ( ((((_SplusNVRAM.I + _SplusNVRAM.OFFSET) - 1) * 50) + 256) ) ; 
            __context__.SourceCodeLine = 210;
            MakeString ( TX__DOLLAR__ , "\u008A\u0000\u0000\u0003{0}{1}{2}\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( Functions.High( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) , Functions.Chr (  (int) ( Functions.Low( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) ) ; 
            __context__.SourceCodeLine = 211;
            _SplusNVRAM.STATEVARSUB = (ushort) ( ((((_SplusNVRAM.I + _SplusNVRAM.OFFSET) - 1) * 50) + 258) ) ; 
            __context__.SourceCodeLine = 212;
            MakeString ( TX__DOLLAR__ , "\u008A\u0000\u0000\u0003{0}{1}{2}\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( Functions.High( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) , Functions.Chr (  (int) ( Functions.Low( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) ) ; 
            __context__.SourceCodeLine = 213;
            _SplusNVRAM.STATEVARSUB = (ushort) ( ((((_SplusNVRAM.I + _SplusNVRAM.OFFSET) - 1) * 50) + 254) ) ; 
            __context__.SourceCodeLine = 214;
            MakeString ( TX__DOLLAR__ , "\u008A\u0000\u0000\u0003{0}{1}{2}\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( Functions.High( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) , Functions.Chr (  (int) ( Functions.Low( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) ) ; 
            __context__.SourceCodeLine = 216;
            _SplusNVRAM.STATEVARSUB = (ushort) ( ((((_SplusNVRAM.I + _SplusNVRAM.OFFSET) - 1) * 50) + 255) ) ; 
            __context__.SourceCodeLine = 217;
            MakeString ( TX__DOLLAR__ , "\u008F\u0000\u0000\u0003{0}{1}{2}{3}\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( Functions.High( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) , Functions.Chr (  (int) ( Functions.Low( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) , "\u0000\u0000\u0000\u0000" ) ; 
            __context__.SourceCodeLine = 218;
            _SplusNVRAM.STATEVARSUB = (ushort) ( ((((_SplusNVRAM.I + _SplusNVRAM.OFFSET) - 1) * 50) + 257) ) ; 
            __context__.SourceCodeLine = 219;
            MakeString ( TX__DOLLAR__ , "\u008F\u0000\u0000\u0003{0}{1}{2}{3}\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( Functions.High( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) , Functions.Chr (  (int) ( Functions.Low( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) , "\u0000\u0000\u0000\u0000" ) ; 
            __context__.SourceCodeLine = 220;
            _SplusNVRAM.STATEVARSUB = (ushort) ( ((((_SplusNVRAM.I + _SplusNVRAM.OFFSET) - 1) * 50) + 252) ) ; 
            __context__.SourceCodeLine = 221;
            MakeString ( TX__DOLLAR__ , "\u008F\u0000\u0000\u0003{0}{1}{2}{3}\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( Functions.High( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) , Functions.Chr (  (int) ( Functions.Low( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) , "\u0000\u0000\u0000\u0000" ) ; 
            __context__.SourceCodeLine = 223;
            _SplusNVRAM.STATEVARSUB = (ushort) ( ((((_SplusNVRAM.I + _SplusNVRAM.OFFSET) - 1) * 50) + 259) ) ; 
            __context__.SourceCodeLine = 224;
            MakeString ( TX__DOLLAR__ , "\u008A\u0000\u0000\u0003{0}{1}{2}\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( Functions.High( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) , Functions.Chr (  (int) ( Functions.Low( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) ) ; 
            __context__.SourceCodeLine = 226;
            _SplusNVRAM.STATEVARSUB = (ushort) ( ((_SplusNVRAM.I + _SplusNVRAM.OFFSET) - 1) ) ; 
            __context__.SourceCodeLine = 227;
            MakeString ( TX__DOLLAR__ , "\u008A\u0000\u0000\u0003{0}{1}{2}\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( Functions.High( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) , Functions.Chr (  (int) ( Functions.Low( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) ) ; 
            __context__.SourceCodeLine = 229;
            _SplusNVRAM.STATEVARSUB = (ushort) ( ((((_SplusNVRAM.I + _SplusNVRAM.OFFSET) - 1) * 50) + 250) ) ; 
            __context__.SourceCodeLine = 230;
            MakeString ( TX__DOLLAR__ , "\u008A\u0000\u0000\u0003{0}{1}{2}\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( Functions.High( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) , Functions.Chr (  (int) ( Functions.Low( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) ) ; 
            __context__.SourceCodeLine = 207;
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SOURCEMUTE__DOLLAR___OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 236;
        _SplusNVRAM.X = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 237;
        _SplusNVRAM.STATEVAR = (ushort) ( ((((_SplusNVRAM.X + _SplusNVRAM.OFFSET) - 1) * 50) + 256) ) ; 
        __context__.SourceCodeLine = 239;
        if ( Functions.TestForTrue  ( ( SOURCEMUTE_FB__DOLLAR__[ _SplusNVRAM.X ] .Value)  ) ) 
            {
            __context__.SourceCodeLine = 240;
            MakeString ( TX__DOLLAR__ , "\u0088\u0000\u0000\u0003{0}{1}{2}\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( Functions.High( (ushort) _SplusNVRAM.STATEVAR ) ) ) , Functions.Chr (  (int) ( Functions.Low( (ushort) _SplusNVRAM.STATEVAR ) ) ) ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 242;
            MakeString ( TX__DOLLAR__ , "\u0088\u0000\u0000\u0003{0}{1}{2}\u0000\u0000\u0000\u0001\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( Functions.High( (ushort) _SplusNVRAM.STATEVAR ) ) ) , Functions.Chr (  (int) ( Functions.Low( (ushort) _SplusNVRAM.STATEVAR ) ) ) ) ; 
            }
        
        __context__.SourceCodeLine = 244;
        if ( Functions.TestForTrue  ( ( _SplusNVRAM.FEEDBACK)  ) ) 
            {
            __context__.SourceCodeLine = 245;
            MakeString ( TX__DOLLAR__ , "\u0089\u0000\u0000\u0003{0}{1}{2}\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( Functions.High( (ushort) _SplusNVRAM.STATEVAR ) ) ) , Functions.Chr (  (int) ( Functions.Low( (ushort) _SplusNVRAM.STATEVAR ) ) ) ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BGM_MUTE__DOLLAR___OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 262;
        _SplusNVRAM.X = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 263;
        _SplusNVRAM.STATEVAR = (ushort) ( ((((_SplusNVRAM.X + _SplusNVRAM.OFFSET) - 1) * 50) + 258) ) ; 
        __context__.SourceCodeLine = 265;
        if ( Functions.TestForTrue  ( ( BGM_MUTE_FB__DOLLAR__[ _SplusNVRAM.X ] .Value)  ) ) 
            {
            __context__.SourceCodeLine = 266;
            MakeString ( TX__DOLLAR__ , "\u0088\u0000\u0000\u0003{0}{1}{2}\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( Functions.High( (ushort) _SplusNVRAM.STATEVAR ) ) ) , Functions.Chr (  (int) ( Functions.Low( (ushort) _SplusNVRAM.STATEVAR ) ) ) ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 268;
            MakeString ( TX__DOLLAR__ , "\u0088\u0000\u0000\u0003{0}{1}{2}\u0000\u0000\u0000\u0001\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( Functions.High( (ushort) _SplusNVRAM.STATEVAR ) ) ) , Functions.Chr (  (int) ( Functions.Low( (ushort) _SplusNVRAM.STATEVAR ) ) ) ) ; 
            }
        
        __context__.SourceCodeLine = 270;
        if ( Functions.TestForTrue  ( ( _SplusNVRAM.FEEDBACK)  ) ) 
            {
            __context__.SourceCodeLine = 271;
            MakeString ( TX__DOLLAR__ , "\u0089\u0000\u0000\u0003{0}{1}{2}\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( Functions.High( (ushort) _SplusNVRAM.STATEVAR ) ) ) , Functions.Chr (  (int) ( Functions.Low( (ushort) _SplusNVRAM.STATEVAR ) ) ) ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MASTERMUTE__DOLLAR___OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 288;
        _SplusNVRAM.X = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 289;
        _SplusNVRAM.STATEVAR = (ushort) ( ((((_SplusNVRAM.X + _SplusNVRAM.OFFSET) - 1) * 50) + 254) ) ; 
        __context__.SourceCodeLine = 291;
        if ( Functions.TestForTrue  ( ( MASTERMUTE_FB__DOLLAR__[ _SplusNVRAM.X ] .Value)  ) ) 
            {
            __context__.SourceCodeLine = 292;
            MakeString ( TX__DOLLAR__ , "\u0088\u0000\u0000\u0003{0}{1}{2}\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( Functions.High( (ushort) _SplusNVRAM.STATEVAR ) ) ) , Functions.Chr (  (int) ( Functions.Low( (ushort) _SplusNVRAM.STATEVAR ) ) ) ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 294;
            MakeString ( TX__DOLLAR__ , "\u0088\u0000\u0000\u0003{0}{1}{2}\u0000\u0000\u0000\u0001\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( Functions.High( (ushort) _SplusNVRAM.STATEVAR ) ) ) , Functions.Chr (  (int) ( Functions.Low( (ushort) _SplusNVRAM.STATEVAR ) ) ) ) ; 
            }
        
        __context__.SourceCodeLine = 296;
        if ( Functions.TestForTrue  ( ( _SplusNVRAM.FEEDBACK)  ) ) 
            {
            __context__.SourceCodeLine = 297;
            MakeString ( TX__DOLLAR__ , "\u0089\u0000\u0000\u0003{0}{1}{2}\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( Functions.High( (ushort) _SplusNVRAM.STATEVAR ) ) ) , Functions.Chr (  (int) ( Functions.Low( (ushort) _SplusNVRAM.STATEVAR ) ) ) ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SOURCEGAIN__DOLLAR___OnChange_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 314;
        _SplusNVRAM.X = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 316;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.SOURCEGAIN[ _SplusNVRAM.X ] != SOURCEGAIN__DOLLAR__[ _SplusNVRAM.X ] .UshortValue))  ) ) 
            { 
            __context__.SourceCodeLine = 318;
            _SplusNVRAM.STATEVAR = (ushort) ( ((((_SplusNVRAM.X + _SplusNVRAM.OFFSET) - 1) * 50) + 255) ) ; 
            __context__.SourceCodeLine = 319;
            _SplusNVRAM.SOURCEGAIN [ _SplusNVRAM.X] = (ushort) ( SOURCEGAIN__DOLLAR__[ _SplusNVRAM.X ] .UshortValue ) ; 
            __context__.SourceCodeLine = 320;
            SOURCEGAIN_FB__DOLLAR__ [ _SplusNVRAM.X]  .Value = (ushort) ( SOURCEGAIN__DOLLAR__[ _SplusNVRAM.X ] .UshortValue ) ; 
            __context__.SourceCodeLine = 321;
            MakeString ( TX__DOLLAR__ , "\u008D\u0000\u0000\u0003{0}{1}{2}{3}\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( Functions.High( (ushort) _SplusNVRAM.STATEVAR ) ) ) , Functions.Chr (  (int) ( Functions.Low( (ushort) _SplusNVRAM.STATEVAR ) ) ) , ITOVOLUMEPERCENT (  __context__ , (ushort)( SOURCEGAIN__DOLLAR__[ _SplusNVRAM.X ] .UshortValue )) ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SOURCE_GAINS_CHANGE_OnRelease_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 333;
        _SplusNVRAM.I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 334;
        if ( Functions.TestForTrue  ( ( _SplusNVRAM.FEEDBACK)  ) ) 
            { 
            __context__.SourceCodeLine = 336;
            _SplusNVRAM.STATEVARSUB = (ushort) ( ((((_SplusNVRAM.I + _SplusNVRAM.OFFSET) - 1) * 50) + 255) ) ; 
            __context__.SourceCodeLine = 337;
            MakeString ( TX__DOLLAR__ , "\u008E\u0000\u0000\u0003{0}{1}{2}{3}\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( Functions.High( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) , Functions.Chr (  (int) ( Functions.Low( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) , "\u0000\u0000\u0000\u0000" ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BGM_GAIN__DOLLAR___OnChange_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 343;
        _SplusNVRAM.X = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 345;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.BGM_GAIN[ _SplusNVRAM.X ] != BGM_GAIN__DOLLAR__[ _SplusNVRAM.X ] .UshortValue))  ) ) 
            { 
            __context__.SourceCodeLine = 347;
            _SplusNVRAM.STATEVAR = (ushort) ( ((((_SplusNVRAM.X + _SplusNVRAM.OFFSET) - 1) * 50) + 257) ) ; 
            __context__.SourceCodeLine = 348;
            _SplusNVRAM.BGM_GAIN [ _SplusNVRAM.X] = (ushort) ( BGM_GAIN__DOLLAR__[ _SplusNVRAM.X ] .UshortValue ) ; 
            __context__.SourceCodeLine = 349;
            BGM_GAIN_FB__DOLLAR__ [ _SplusNVRAM.X]  .Value = (ushort) ( BGM_GAIN__DOLLAR__[ _SplusNVRAM.X ] .UshortValue ) ; 
            __context__.SourceCodeLine = 350;
            MakeString ( TX__DOLLAR__ , "\u008D\u0000\u0000\u0003{0}{1}{2}{3}\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( Functions.High( (ushort) _SplusNVRAM.STATEVAR ) ) ) , Functions.Chr (  (int) ( Functions.Low( (ushort) _SplusNVRAM.STATEVAR ) ) ) , ITOVOLUMEPERCENT (  __context__ , (ushort)( BGM_GAIN__DOLLAR__[ _SplusNVRAM.X ] .UshortValue )) ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BGM_GAINS_CHANGE_OnRelease_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 363;
        _SplusNVRAM.I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 364;
        if ( Functions.TestForTrue  ( ( _SplusNVRAM.FEEDBACK)  ) ) 
            { 
            __context__.SourceCodeLine = 366;
            _SplusNVRAM.STATEVARSUB = (ushort) ( ((((_SplusNVRAM.I + _SplusNVRAM.OFFSET) - 1) * 50) + 257) ) ; 
            __context__.SourceCodeLine = 367;
            MakeString ( TX__DOLLAR__ , "\u008E\u0000\u0000\u0003{0}{1}{2}{3}\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( Functions.High( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) , Functions.Chr (  (int) ( Functions.Low( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) , "\u0000\u0000\u0000\u0000" ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MASTERGAIN__DOLLAR___OnChange_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 373;
        _SplusNVRAM.X = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 375;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.MASTERGAIN[ _SplusNVRAM.X ] != MASTERGAIN__DOLLAR__[ _SplusNVRAM.X ] .UshortValue))  ) ) 
            { 
            __context__.SourceCodeLine = 377;
            _SplusNVRAM.STATEVAR = (ushort) ( ((((_SplusNVRAM.X + _SplusNVRAM.OFFSET) - 1) * 50) + 252) ) ; 
            __context__.SourceCodeLine = 378;
            _SplusNVRAM.MASTERGAIN [ _SplusNVRAM.X] = (ushort) ( MASTERGAIN__DOLLAR__[ _SplusNVRAM.X ] .UshortValue ) ; 
            __context__.SourceCodeLine = 379;
            MASTERGAIN_FB__DOLLAR__ [ _SplusNVRAM.X]  .Value = (ushort) ( MASTERGAIN__DOLLAR__[ _SplusNVRAM.X ] .UshortValue ) ; 
            __context__.SourceCodeLine = 380;
            MakeString ( TX__DOLLAR__ , "\u008D\u0000\u0000\u0003{0}{1}{2}{3}\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( Functions.High( (ushort) _SplusNVRAM.STATEVAR ) ) ) , Functions.Chr (  (int) ( Functions.Low( (ushort) _SplusNVRAM.STATEVAR ) ) ) , ITOVOLUMEPERCENT (  __context__ , (ushort)( MASTERGAIN__DOLLAR__[ _SplusNVRAM.X ] .UshortValue )) ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MASTER_GAINS_CHANGE_OnRelease_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 393;
        _SplusNVRAM.I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 394;
        if ( Functions.TestForTrue  ( ( _SplusNVRAM.FEEDBACK)  ) ) 
            { 
            __context__.SourceCodeLine = 396;
            _SplusNVRAM.STATEVARSUB = (ushort) ( ((((_SplusNVRAM.I + _SplusNVRAM.OFFSET) - 1) * 50) + 252) ) ; 
            __context__.SourceCodeLine = 397;
            MakeString ( TX__DOLLAR__ , "\u008E\u0000\u0000\u0003{0}{1}{2}{3}\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( Functions.High( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) , Functions.Chr (  (int) ( Functions.Low( (ushort) _SplusNVRAM.STATEVARSUB ) ) ) , "\u0000\u0000\u0000\u0000" ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BGM_INPUT__DOLLAR___OnChange_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 403;
        _SplusNVRAM.X = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 404;
        _SplusNVRAM.STATEVAR = (ushort) ( ((((_SplusNVRAM.X + _SplusNVRAM.OFFSET) - 1) * 50) + 259) ) ; 
        __context__.SourceCodeLine = 406;
        MakeString ( TX__DOLLAR__ , "\u0088\u0000\u0000\u0003{0}{1}{2}\u0000\u0000\u0000{3}\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( Functions.High( (ushort) _SplusNVRAM.STATEVAR ) ) ) , Functions.Chr (  (int) ( Functions.Low( (ushort) _SplusNVRAM.STATEVAR ) ) ) , Functions.Chr (  (int) ( BGM_INPUT__DOLLAR__[ _SplusNVRAM.X ] .UshortValue ) ) ) ; 
        __context__.SourceCodeLine = 408;
        if ( Functions.TestForTrue  ( ( _SplusNVRAM.FEEDBACK)  ) ) 
            {
            __context__.SourceCodeLine = 409;
            MakeString ( TX__DOLLAR__ , "\u0089\u0000\u0000\u0003{0}{1}{2}\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( Functions.High( (ushort) _SplusNVRAM.STATEVAR ) ) ) , Functions.Chr (  (int) ( Functions.Low( (ushort) _SplusNVRAM.STATEVAR ) ) ) ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PARTITION__DOLLAR___OnPush_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 414;
        _SplusNVRAM.X = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 415;
        _SplusNVRAM.STATEVAR = (ushort) ( ((_SplusNVRAM.X + _SplusNVRAM.OFFSET) - 1) ) ; 
        __context__.SourceCodeLine = 417;
        if ( Functions.TestForTrue  ( ( PARTITION_FB__DOLLAR__[ _SplusNVRAM.X ] .Value)  ) ) 
            {
            __context__.SourceCodeLine = 418;
            MakeString ( TX__DOLLAR__ , "\u0088\u0000\u0000\u0003{0}{1}{2}\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( Functions.High( (ushort) _SplusNVRAM.STATEVAR ) ) ) , Functions.Chr (  (int) ( Functions.Low( (ushort) _SplusNVRAM.STATEVAR ) ) ) ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 420;
            MakeString ( TX__DOLLAR__ , "\u0088\u0000\u0000\u0003{0}{1}{2}\u0000\u0000\u0000\u0001\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( Functions.High( (ushort) _SplusNVRAM.STATEVAR ) ) ) , Functions.Chr (  (int) ( Functions.Low( (ushort) _SplusNVRAM.STATEVAR ) ) ) ) ; 
            }
        
        __context__.SourceCodeLine = 422;
        if ( Functions.TestForTrue  ( ( _SplusNVRAM.FEEDBACK)  ) ) 
            {
            __context__.SourceCodeLine = 423;
            MakeString ( TX__DOLLAR__ , "\u0089\u0000\u0000\u0003{0}{1}{2}\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( Functions.High( (ushort) _SplusNVRAM.STATEVAR ) ) ) , Functions.Chr (  (int) ( Functions.Low( (ushort) _SplusNVRAM.STATEVAR ) ) ) ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object GROUP__DOLLAR___OnChange_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 428;
        _SplusNVRAM.X = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 429;
        _SplusNVRAM.STATEVAR = (ushort) ( ((((_SplusNVRAM.X + _SplusNVRAM.OFFSET) - 1) * 50) + 250) ) ; 
        __context__.SourceCodeLine = 431;
        MakeString ( TX__DOLLAR__ , "\u0088\u0000\u0000\u0003{0}{1}{2}\u0000\u0000\u0000{3}\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( Functions.High( (ushort) _SplusNVRAM.STATEVAR ) ) ) , Functions.Chr (  (int) ( Functions.Low( (ushort) _SplusNVRAM.STATEVAR ) ) ) , Functions.Chr (  (int) ( GROUP__DOLLAR__[ _SplusNVRAM.X ] .UshortValue ) ) ) ; 
        __context__.SourceCodeLine = 433;
        if ( Functions.TestForTrue  ( ( _SplusNVRAM.FEEDBACK)  ) ) 
            {
            __context__.SourceCodeLine = 434;
            MakeString ( TX__DOLLAR__ , "\u0089\u0000\u0000\u0003{0}{1}{2}\u0000\u0000\u0000\u0000\u0003\u0003\u0003\u0003\u0003", OBJECTID__DOLLAR__ , Functions.Chr (  (int) ( Functions.High( (ushort) _SplusNVRAM.STATEVAR ) ) ) , Functions.Chr (  (int) ( Functions.Low( (ushort) _SplusNVRAM.STATEVAR ) ) ) ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RX__DOLLAR___OnChange_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 441;
        if ( Functions.TestForTrue  ( ( _SplusNVRAM.XOK)  ) ) 
            { 
            __context__.SourceCodeLine = 443;
            _SplusNVRAM.XOK = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 444;
            while ( Functions.TestForTrue  ( ( Functions.Length( RX__DOLLAR__ ))  ) ) 
                { 
                __context__.SourceCodeLine = 446;
                if ( Functions.TestForTrue  ( ( Functions.Find( "\u0003\u0003\u0003\u0003\u0003" , RX__DOLLAR__ ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 448;
                    _SplusNVRAM.TEMPSTRING  .UpdateValue ( Functions.Remove ( "\u0003\u0003\u0003\u0003\u0003" , RX__DOLLAR__ )  ) ; 
                    __context__.SourceCodeLine = 449;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Mid( _SplusNVRAM.TEMPSTRING , (int)( 6 ) , (int)( 3 ) ) == "\u0000\u0000\u0000") ) || Functions.TestForTrue ( Functions.BoolToInt (Functions.Mid( _SplusNVRAM.TEMPSTRING , (int)( 6 ) , (int)( 3 ) ) == OBJECTID__DOLLAR__) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 451;
                        _SplusNVRAM.SV = (ushort) ( ((Byte( _SplusNVRAM.TEMPSTRING , (int)( 9 ) ) * 256) + Byte( _SplusNVRAM.TEMPSTRING , (int)( 10 ) )) ) ; 
                        __context__.SourceCodeLine = 453;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.SV < 49 ))  ) ) 
                            {
                            __context__.SourceCodeLine = 454;
                            PARTITION_FB__DOLLAR__ [ ((_SplusNVRAM.SV + 1) - _SplusNVRAM.OFFSET)]  .Value = (ushort) ( Byte( _SplusNVRAM.TEMPSTRING , (int)( 14 ) ) ) ; 
                            }
                        
                        else 
                            {
                            __context__.SourceCodeLine = 455;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.SV > 249 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 457;
                                _SplusNVRAM.SV_MOD = (ushort) ( Mod( _SplusNVRAM.SV , 50 ) ) ; 
                                __context__.SourceCodeLine = 459;
                                
                                    {
                                    int __SPLS_TMPVAR__SWTCH_1__ = ((int)_SplusNVRAM.SV_MOD);
                                    
                                        { 
                                        if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 0) ) ) ) 
                                            { 
                                            __context__.SourceCodeLine = 461;
                                            GROUP_FB__DOLLAR__ [ (((_SplusNVRAM.SV - 200) / 50) - _SplusNVRAM.OFFSET)]  .Value = (ushort) ( Byte( _SplusNVRAM.TEMPSTRING , (int)( 14 ) ) ) ; 
                                            } 
                                        
                                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 6) ) ) ) 
                                            { 
                                            __context__.SourceCodeLine = 462;
                                            SOURCEMUTE_FB__DOLLAR__ [ (((_SplusNVRAM.SV - 206) / 50) - _SplusNVRAM.OFFSET)]  .Value = (ushort) ( Byte( _SplusNVRAM.TEMPSTRING , (int)( 14 ) ) ) ; 
                                            } 
                                        
                                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 8) ) ) ) 
                                            { 
                                            __context__.SourceCodeLine = 463;
                                            BGM_MUTE_FB__DOLLAR__ [ (((_SplusNVRAM.SV - 208) / 50) - _SplusNVRAM.OFFSET)]  .Value = (ushort) ( Byte( _SplusNVRAM.TEMPSTRING , (int)( 14 ) ) ) ; 
                                            } 
                                        
                                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 4) ) ) ) 
                                            { 
                                            __context__.SourceCodeLine = 464;
                                            MASTERMUTE_FB__DOLLAR__ [ (((_SplusNVRAM.SV - 204) / 50) - _SplusNVRAM.OFFSET)]  .Value = (ushort) ( Byte( _SplusNVRAM.TEMPSTRING , (int)( 14 ) ) ) ; 
                                            } 
                                        
                                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 5) ) ) ) 
                                            { 
                                            __context__.SourceCodeLine = 467;
                                            _SplusNVRAM.SOURCEGAIN [ (((_SplusNVRAM.SV - 205) / 50) - _SplusNVRAM.OFFSET)] = (ushort) ( VOLUMEPERCENTTOI( __context__ , Functions.Mid( _SplusNVRAM.TEMPSTRING , (int)( 11 ) , (int)( 4 ) ) ) ) ; 
                                            __context__.SourceCodeLine = 468;
                                            SOURCEGAIN_FB__DOLLAR__ [ (((_SplusNVRAM.SV - 205) / 50) - _SplusNVRAM.OFFSET)]  .Value = (ushort) ( _SplusNVRAM.SOURCEGAIN[ (((_SplusNVRAM.SV - 205) / 50) - _SplusNVRAM.OFFSET) ] ) ; 
                                            } 
                                        
                                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 7) ) ) ) 
                                            { 
                                            __context__.SourceCodeLine = 472;
                                            _SplusNVRAM.BGM_GAIN [ (((_SplusNVRAM.SV - 207) / 50) - _SplusNVRAM.OFFSET)] = (ushort) ( VOLUMEPERCENTTOI( __context__ , Functions.Mid( _SplusNVRAM.TEMPSTRING , (int)( 11 ) , (int)( 4 ) ) ) ) ; 
                                            __context__.SourceCodeLine = 473;
                                            BGM_GAIN_FB__DOLLAR__ [ (((_SplusNVRAM.SV - 207) / 50) - _SplusNVRAM.OFFSET)]  .Value = (ushort) ( _SplusNVRAM.BGM_GAIN[ (((_SplusNVRAM.SV - 207) / 50) - _SplusNVRAM.OFFSET) ] ) ; 
                                            } 
                                        
                                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) ) ) ) 
                                            { 
                                            __context__.SourceCodeLine = 477;
                                            _SplusNVRAM.MASTERGAIN [ (((_SplusNVRAM.SV - 202) / 50) - _SplusNVRAM.OFFSET)] = (ushort) ( VOLUMEPERCENTTOI( __context__ , Functions.Mid( _SplusNVRAM.TEMPSTRING , (int)( 11 ) , (int)( 4 ) ) ) ) ; 
                                            __context__.SourceCodeLine = 478;
                                            MASTERGAIN_FB__DOLLAR__ [ (((_SplusNVRAM.SV - 202) / 50) - _SplusNVRAM.OFFSET)]  .Value = (ushort) ( _SplusNVRAM.MASTERGAIN[ (((_SplusNVRAM.SV - 202) / 50) - _SplusNVRAM.OFFSET) ] ) ; 
                                            } 
                                        
                                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 9) ) ) ) 
                                            { 
                                            __context__.SourceCodeLine = 482;
                                            BGM_INPUT_FB__DOLLAR__ [ (((_SplusNVRAM.SV - 209) / 50) - _SplusNVRAM.OFFSET)]  .Value = (ushort) ( Byte( _SplusNVRAM.TEMPSTRING , (int)( 14 ) ) ) ; 
                                            } 
                                        
                                        } 
                                        
                                    }
                                    
                                
                                } 
                            
                            }
                        
                        } 
                    
                    __context__.SourceCodeLine = 487;
                    Functions.ClearBuffer ( _SplusNVRAM.TEMPSTRING ) ; 
                    } 
                
                __context__.SourceCodeLine = 444;
                } 
            
            __context__.SourceCodeLine = 490;
            _SplusNVRAM.XOK = (ushort) ( 1 ) ; 
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
        
        __context__.SourceCodeLine = 510;
        _SplusNVRAM.FEEDBACK = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 512;
        _SplusNVRAM.XOK = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 513;
        _SplusNVRAM.OFFSET = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    _SplusNVRAM.SOURCEGAIN  = new ushort[ 9 ];
    _SplusNVRAM.BGM_GAIN  = new ushort[ 9 ];
    _SplusNVRAM.MASTERGAIN  = new ushort[ 9 ];
    _SplusNVRAM.RETURNSTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
    _SplusNVRAM.TEMPSTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 40, this );
    
    ENABLE_FEEDBACK__DOLLAR__ = new Crestron.Logos.SplusObjects.DigitalInput( ENABLE_FEEDBACK__DOLLAR____DigitalInput__, this );
    m_DigitalInputList.Add( ENABLE_FEEDBACK__DOLLAR____DigitalInput__, ENABLE_FEEDBACK__DOLLAR__ );
    
    SOURCEMUTE__DOLLAR__ = new InOutArray<DigitalInput>( 8, this );
    for( uint i = 0; i < 8; i++ )
    {
        SOURCEMUTE__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( SOURCEMUTE__DOLLAR____DigitalInput__ + i, SOURCEMUTE__DOLLAR____DigitalInput__, this );
        m_DigitalInputList.Add( SOURCEMUTE__DOLLAR____DigitalInput__ + i, SOURCEMUTE__DOLLAR__[i+1] );
    }
    
    BGM_MUTE__DOLLAR__ = new InOutArray<DigitalInput>( 8, this );
    for( uint i = 0; i < 8; i++ )
    {
        BGM_MUTE__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( BGM_MUTE__DOLLAR____DigitalInput__ + i, BGM_MUTE__DOLLAR____DigitalInput__, this );
        m_DigitalInputList.Add( BGM_MUTE__DOLLAR____DigitalInput__ + i, BGM_MUTE__DOLLAR__[i+1] );
    }
    
    MASTERMUTE__DOLLAR__ = new InOutArray<DigitalInput>( 8, this );
    for( uint i = 0; i < 8; i++ )
    {
        MASTERMUTE__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( MASTERMUTE__DOLLAR____DigitalInput__ + i, MASTERMUTE__DOLLAR____DigitalInput__, this );
        m_DigitalInputList.Add( MASTERMUTE__DOLLAR____DigitalInput__ + i, MASTERMUTE__DOLLAR__[i+1] );
    }
    
    PARTITION__DOLLAR__ = new InOutArray<DigitalInput>( 8, this );
    for( uint i = 0; i < 8; i++ )
    {
        PARTITION__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( PARTITION__DOLLAR____DigitalInput__ + i, PARTITION__DOLLAR____DigitalInput__, this );
        m_DigitalInputList.Add( PARTITION__DOLLAR____DigitalInput__ + i, PARTITION__DOLLAR__[i+1] );
    }
    
    SOURCE_GAINS_CHANGE = new InOutArray<DigitalInput>( 8, this );
    for( uint i = 0; i < 8; i++ )
    {
        SOURCE_GAINS_CHANGE[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( SOURCE_GAINS_CHANGE__DigitalInput__ + i, SOURCE_GAINS_CHANGE__DigitalInput__, this );
        m_DigitalInputList.Add( SOURCE_GAINS_CHANGE__DigitalInput__ + i, SOURCE_GAINS_CHANGE[i+1] );
    }
    
    BGM_GAINS_CHANGE = new InOutArray<DigitalInput>( 8, this );
    for( uint i = 0; i < 8; i++ )
    {
        BGM_GAINS_CHANGE[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( BGM_GAINS_CHANGE__DigitalInput__ + i, BGM_GAINS_CHANGE__DigitalInput__, this );
        m_DigitalInputList.Add( BGM_GAINS_CHANGE__DigitalInput__ + i, BGM_GAINS_CHANGE[i+1] );
    }
    
    MASTER_GAINS_CHANGE = new InOutArray<DigitalInput>( 8, this );
    for( uint i = 0; i < 8; i++ )
    {
        MASTER_GAINS_CHANGE[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( MASTER_GAINS_CHANGE__DigitalInput__ + i, MASTER_GAINS_CHANGE__DigitalInput__, this );
        m_DigitalInputList.Add( MASTER_GAINS_CHANGE__DigitalInput__ + i, MASTER_GAINS_CHANGE[i+1] );
    }
    
    SOURCEMUTE_FB__DOLLAR__ = new InOutArray<DigitalOutput>( 8, this );
    for( uint i = 0; i < 8; i++ )
    {
        SOURCEMUTE_FB__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( SOURCEMUTE_FB__DOLLAR____DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( SOURCEMUTE_FB__DOLLAR____DigitalOutput__ + i, SOURCEMUTE_FB__DOLLAR__[i+1] );
    }
    
    BGM_MUTE_FB__DOLLAR__ = new InOutArray<DigitalOutput>( 8, this );
    for( uint i = 0; i < 8; i++ )
    {
        BGM_MUTE_FB__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( BGM_MUTE_FB__DOLLAR____DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( BGM_MUTE_FB__DOLLAR____DigitalOutput__ + i, BGM_MUTE_FB__DOLLAR__[i+1] );
    }
    
    MASTERMUTE_FB__DOLLAR__ = new InOutArray<DigitalOutput>( 8, this );
    for( uint i = 0; i < 8; i++ )
    {
        MASTERMUTE_FB__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( MASTERMUTE_FB__DOLLAR____DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( MASTERMUTE_FB__DOLLAR____DigitalOutput__ + i, MASTERMUTE_FB__DOLLAR__[i+1] );
    }
    
    PARTITION_FB__DOLLAR__ = new InOutArray<DigitalOutput>( 8, this );
    for( uint i = 0; i < 8; i++ )
    {
        PARTITION_FB__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( PARTITION_FB__DOLLAR____DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( PARTITION_FB__DOLLAR____DigitalOutput__ + i, PARTITION_FB__DOLLAR__[i+1] );
    }
    
    CHAN_OFFSET__DOLLAR__ = new Crestron.Logos.SplusObjects.AnalogInput( CHAN_OFFSET__DOLLAR____AnalogSerialInput__, this );
    m_AnalogInputList.Add( CHAN_OFFSET__DOLLAR____AnalogSerialInput__, CHAN_OFFSET__DOLLAR__ );
    
    MAX_ROOMS__DOLLAR__ = new Crestron.Logos.SplusObjects.AnalogInput( MAX_ROOMS__DOLLAR____AnalogSerialInput__, this );
    m_AnalogInputList.Add( MAX_ROOMS__DOLLAR____AnalogSerialInput__, MAX_ROOMS__DOLLAR__ );
    
    SOURCEGAIN__DOLLAR__ = new InOutArray<AnalogInput>( 8, this );
    for( uint i = 0; i < 8; i++ )
    {
        SOURCEGAIN__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( SOURCEGAIN__DOLLAR____AnalogSerialInput__ + i, SOURCEGAIN__DOLLAR____AnalogSerialInput__, this );
        m_AnalogInputList.Add( SOURCEGAIN__DOLLAR____AnalogSerialInput__ + i, SOURCEGAIN__DOLLAR__[i+1] );
    }
    
    BGM_GAIN__DOLLAR__ = new InOutArray<AnalogInput>( 8, this );
    for( uint i = 0; i < 8; i++ )
    {
        BGM_GAIN__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( BGM_GAIN__DOLLAR____AnalogSerialInput__ + i, BGM_GAIN__DOLLAR____AnalogSerialInput__, this );
        m_AnalogInputList.Add( BGM_GAIN__DOLLAR____AnalogSerialInput__ + i, BGM_GAIN__DOLLAR__[i+1] );
    }
    
    MASTERGAIN__DOLLAR__ = new InOutArray<AnalogInput>( 8, this );
    for( uint i = 0; i < 8; i++ )
    {
        MASTERGAIN__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( MASTERGAIN__DOLLAR____AnalogSerialInput__ + i, MASTERGAIN__DOLLAR____AnalogSerialInput__, this );
        m_AnalogInputList.Add( MASTERGAIN__DOLLAR____AnalogSerialInput__ + i, MASTERGAIN__DOLLAR__[i+1] );
    }
    
    BGM_INPUT__DOLLAR__ = new InOutArray<AnalogInput>( 8, this );
    for( uint i = 0; i < 8; i++ )
    {
        BGM_INPUT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( BGM_INPUT__DOLLAR____AnalogSerialInput__ + i, BGM_INPUT__DOLLAR____AnalogSerialInput__, this );
        m_AnalogInputList.Add( BGM_INPUT__DOLLAR____AnalogSerialInput__ + i, BGM_INPUT__DOLLAR__[i+1] );
    }
    
    GROUP__DOLLAR__ = new InOutArray<AnalogInput>( 8, this );
    for( uint i = 0; i < 8; i++ )
    {
        GROUP__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( GROUP__DOLLAR____AnalogSerialInput__ + i, GROUP__DOLLAR____AnalogSerialInput__, this );
        m_AnalogInputList.Add( GROUP__DOLLAR____AnalogSerialInput__ + i, GROUP__DOLLAR__[i+1] );
    }
    
    SOURCEGAIN_FB__DOLLAR__ = new InOutArray<AnalogOutput>( 8, this );
    for( uint i = 0; i < 8; i++ )
    {
        SOURCEGAIN_FB__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( SOURCEGAIN_FB__DOLLAR____AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( SOURCEGAIN_FB__DOLLAR____AnalogSerialOutput__ + i, SOURCEGAIN_FB__DOLLAR__[i+1] );
    }
    
    BGM_GAIN_FB__DOLLAR__ = new InOutArray<AnalogOutput>( 8, this );
    for( uint i = 0; i < 8; i++ )
    {
        BGM_GAIN_FB__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( BGM_GAIN_FB__DOLLAR____AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( BGM_GAIN_FB__DOLLAR____AnalogSerialOutput__ + i, BGM_GAIN_FB__DOLLAR__[i+1] );
    }
    
    MASTERGAIN_FB__DOLLAR__ = new InOutArray<AnalogOutput>( 8, this );
    for( uint i = 0; i < 8; i++ )
    {
        MASTERGAIN_FB__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( MASTERGAIN_FB__DOLLAR____AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( MASTERGAIN_FB__DOLLAR____AnalogSerialOutput__ + i, MASTERGAIN_FB__DOLLAR__[i+1] );
    }
    
    BGM_INPUT_FB__DOLLAR__ = new InOutArray<AnalogOutput>( 8, this );
    for( uint i = 0; i < 8; i++ )
    {
        BGM_INPUT_FB__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( BGM_INPUT_FB__DOLLAR____AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( BGM_INPUT_FB__DOLLAR____AnalogSerialOutput__ + i, BGM_INPUT_FB__DOLLAR__[i+1] );
    }
    
    GROUP_FB__DOLLAR__ = new InOutArray<AnalogOutput>( 8, this );
    for( uint i = 0; i < 8; i++ )
    {
        GROUP_FB__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( GROUP_FB__DOLLAR____AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( GROUP_FB__DOLLAR____AnalogSerialOutput__ + i, GROUP_FB__DOLLAR__[i+1] );
    }
    
    OBJECTID__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( OBJECTID__DOLLAR____AnalogSerialInput__, 3, this );
    m_StringInputList.Add( OBJECTID__DOLLAR____AnalogSerialInput__, OBJECTID__DOLLAR__ );
    
    TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TX__DOLLAR____AnalogSerialOutput__, TX__DOLLAR__ );
    
    RX__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( RX__DOLLAR____AnalogSerialInput__, 4000, this );
    m_StringInputList.Add( RX__DOLLAR____AnalogSerialInput__, RX__DOLLAR__ );
    
    __SPLS_TMPVAR__WAITLABEL_12___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_12___CallbackFn );
    
    CHAN_OFFSET__DOLLAR__.OnAnalogChange.Add( new InputChangeHandlerWrapper( CHAN_OFFSET__DOLLAR___OnChange_0, false ) );
    ENABLE_FEEDBACK__DOLLAR__.OnDigitalPush.Add( new InputChangeHandlerWrapper( ENABLE_FEEDBACK__DOLLAR___OnPush_1, false ) );
    ENABLE_FEEDBACK__DOLLAR__.OnDigitalRelease.Add( new InputChangeHandlerWrapper( ENABLE_FEEDBACK__DOLLAR___OnRelease_2, false ) );
    for( uint i = 0; i < 8; i++ )
        SOURCEMUTE__DOLLAR__[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( SOURCEMUTE__DOLLAR___OnPush_3, false ) );
        
    for( uint i = 0; i < 8; i++ )
        BGM_MUTE__DOLLAR__[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( BGM_MUTE__DOLLAR___OnPush_4, false ) );
        
    for( uint i = 0; i < 8; i++ )
        MASTERMUTE__DOLLAR__[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( MASTERMUTE__DOLLAR___OnPush_5, false ) );
        
    for( uint i = 0; i < 8; i++ )
        SOURCEGAIN__DOLLAR__[i+1].OnAnalogChange.Add( new InputChangeHandlerWrapper( SOURCEGAIN__DOLLAR___OnChange_6, false ) );
        
    for( uint i = 0; i < 8; i++ )
        SOURCE_GAINS_CHANGE[i+1].OnDigitalRelease.Add( new InputChangeHandlerWrapper( SOURCE_GAINS_CHANGE_OnRelease_7, false ) );
        
    for( uint i = 0; i < 8; i++ )
        BGM_GAIN__DOLLAR__[i+1].OnAnalogChange.Add( new InputChangeHandlerWrapper( BGM_GAIN__DOLLAR___OnChange_8, false ) );
        
    for( uint i = 0; i < 8; i++ )
        BGM_GAINS_CHANGE[i+1].OnDigitalRelease.Add( new InputChangeHandlerWrapper( BGM_GAINS_CHANGE_OnRelease_9, false ) );
        
    for( uint i = 0; i < 8; i++ )
        MASTERGAIN__DOLLAR__[i+1].OnAnalogChange.Add( new InputChangeHandlerWrapper( MASTERGAIN__DOLLAR___OnChange_10, false ) );
        
    for( uint i = 0; i < 8; i++ )
        MASTER_GAINS_CHANGE[i+1].OnDigitalRelease.Add( new InputChangeHandlerWrapper( MASTER_GAINS_CHANGE_OnRelease_11, false ) );
        
    for( uint i = 0; i < 8; i++ )
        BGM_INPUT__DOLLAR__[i+1].OnAnalogChange.Add( new InputChangeHandlerWrapper( BGM_INPUT__DOLLAR___OnChange_12, false ) );
        
    for( uint i = 0; i < 8; i++ )
        PARTITION__DOLLAR__[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( PARTITION__DOLLAR___OnPush_13, false ) );
        
    for( uint i = 0; i < 8; i++ )
        GROUP__DOLLAR__[i+1].OnAnalogChange.Add( new InputChangeHandlerWrapper( GROUP__DOLLAR___OnChange_14, false ) );
        
    RX__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( RX__DOLLAR___OnChange_15, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_BSS_SOUNDWEB_LONDON_ROOM_COMBINE_V4_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction __SPLS_TMPVAR__WAITLABEL_12___Callback;


const uint ENABLE_FEEDBACK__DOLLAR____DigitalInput__ = 0;
const uint OBJECTID__DOLLAR____AnalogSerialInput__ = 0;
const uint RX__DOLLAR____AnalogSerialInput__ = 1;
const uint TX__DOLLAR____AnalogSerialOutput__ = 0;
const uint SOURCEMUTE__DOLLAR____DigitalInput__ = 1;
const uint BGM_MUTE__DOLLAR____DigitalInput__ = 9;
const uint MASTERMUTE__DOLLAR____DigitalInput__ = 17;
const uint PARTITION__DOLLAR____DigitalInput__ = 25;
const uint SOURCE_GAINS_CHANGE__DigitalInput__ = 33;
const uint BGM_GAINS_CHANGE__DigitalInput__ = 41;
const uint MASTER_GAINS_CHANGE__DigitalInput__ = 49;
const uint CHAN_OFFSET__DOLLAR____AnalogSerialInput__ = 2;
const uint MAX_ROOMS__DOLLAR____AnalogSerialInput__ = 3;
const uint SOURCEGAIN__DOLLAR____AnalogSerialInput__ = 4;
const uint BGM_GAIN__DOLLAR____AnalogSerialInput__ = 12;
const uint MASTERGAIN__DOLLAR____AnalogSerialInput__ = 20;
const uint BGM_INPUT__DOLLAR____AnalogSerialInput__ = 28;
const uint GROUP__DOLLAR____AnalogSerialInput__ = 36;
const uint SOURCEMUTE_FB__DOLLAR____DigitalOutput__ = 0;
const uint BGM_MUTE_FB__DOLLAR____DigitalOutput__ = 8;
const uint MASTERMUTE_FB__DOLLAR____DigitalOutput__ = 16;
const uint PARTITION_FB__DOLLAR____DigitalOutput__ = 24;
const uint SOURCEGAIN_FB__DOLLAR____AnalogSerialOutput__ = 1;
const uint BGM_GAIN_FB__DOLLAR____AnalogSerialOutput__ = 9;
const uint MASTERGAIN_FB__DOLLAR____AnalogSerialOutput__ = 17;
const uint BGM_INPUT_FB__DOLLAR____AnalogSerialOutput__ = 25;
const uint GROUP_FB__DOLLAR____AnalogSerialOutput__ = 33;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    [SplusStructAttribute(0, false, true)]
            public ushort OFFSET = 0;
            [SplusStructAttribute(1, false, true)]
            public ushort FEEDBACK = 0;
            [SplusStructAttribute(2, false, true)]
            public ushort STATEVAR = 0;
            [SplusStructAttribute(3, false, true)]
            public ushort SV = 0;
            [SplusStructAttribute(4, false, true)]
            public ushort SV_MOD = 0;
            [SplusStructAttribute(5, false, true)]
            public ushort STATEVARGAIN = 0;
            [SplusStructAttribute(6, false, true)]
            public ushort STATEVARSUB = 0;
            [SplusStructAttribute(7, false, true)]
            public ushort STATEVARUNSUB = 0;
            [SplusStructAttribute(8, false, true)]
            public ushort X = 0;
            [SplusStructAttribute(9, false, true)]
            public CrestronString RETURNSTRING;
            [SplusStructAttribute(10, false, true)]
            public ushort RETURNI = 0;
            [SplusStructAttribute(11, false, true)]
            public ushort [] SOURCEGAIN;
            [SplusStructAttribute(12, false, true)]
            public ushort [] BGM_GAIN;
            [SplusStructAttribute(13, false, true)]
            public ushort [] MASTERGAIN;
            [SplusStructAttribute(14, false, true)]
            public ushort XOK = 0;
            [SplusStructAttribute(15, false, true)]
            public ushort I = 0;
            [SplusStructAttribute(16, false, true)]
            public CrestronString TEMPSTRING;
            
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
