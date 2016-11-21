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

namespace UserModule_JAP_AVSWITCH_POE_CONTROL_V2_08
{
    public class UserModuleClass_JAP_AVSWITCH_POE_CONTROL_V2_08 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> SWITCH_ONE_ON;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> SWITCH_ONE_OFF;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> SWITCH_TWO_ON;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> SWITCH_TWO_OFF;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> SWITCH_THREE_ON;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> SWITCH_THREE_OFF;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> SWITCH_FOUR_ON;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> SWITCH_FOUR_OFF;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> SWITCH_FIVE_ON;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> SWITCH_FIVE_OFF;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> SWITCH_SIX_ON;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> SWITCH_SIX_OFF;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> SWITCH_SEVEN_ON;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> SWITCH_SEVEN_OFF;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> SWITCH_EIGHT_ON;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> SWITCH_EIGHT_OFF;
        Crestron.Logos.SplusObjects.StringOutput CMD;
        object SWITCH_ONE_ON_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort I = 0;
                
                
                __context__.SourceCodeLine = 2;
                I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
                __context__.SourceCodeLine = 2;
                CMD  .UpdateValue ( "POE 1," + Functions.ItoA (  (int) ( I ) ) + "=ON;"  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object SWITCH_TWO_ON_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 2;
            I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
            __context__.SourceCodeLine = 3;
            CMD  .UpdateValue ( "POE 2," + Functions.ItoA (  (int) ( I ) ) + "=ON;"  ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object SWITCH_THREE_ON_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 3;
        I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 3;
        CMD  .UpdateValue ( "POE 3," + Functions.ItoA (  (int) ( I ) ) + "=ON;"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SWITCH_FOUR_ON_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 3;
        I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 3;
        CMD  .UpdateValue ( "POE 4," + Functions.ItoA (  (int) ( I ) ) + "=ON;"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SWITCH_ONE_OFF_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 3;
        I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 3;
        CMD  .UpdateValue ( "POE 1," + Functions.ItoA (  (int) ( I ) ) + "=OFF;"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SWITCH_TWO_OFF_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 3;
        I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 3;
        CMD  .UpdateValue ( "POE 2," + Functions.ItoA (  (int) ( I ) ) + "=OFF;"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SWITCH_THREE_OFF_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 3;
        I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 3;
        CMD  .UpdateValue ( "POE 3," + Functions.ItoA (  (int) ( I ) ) + "=OFF;"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SWITCH_FOUR_OFF_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 4;
        I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 4;
        CMD  .UpdateValue ( "POE 4," + Functions.ItoA (  (int) ( I ) ) + "=OFF;"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SWITCH_FIVE_ON_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 4;
        I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 4;
        CMD  .UpdateValue ( "POE 5," + Functions.ItoA (  (int) ( I ) ) + "=ON;"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SWITCH_SIX_ON_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 4;
        I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 4;
        CMD  .UpdateValue ( "POE 6," + Functions.ItoA (  (int) ( I ) ) + "=ON;"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SWITCH_SEVEN_ON_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 4;
        I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 4;
        CMD  .UpdateValue ( "POE 7," + Functions.ItoA (  (int) ( I ) ) + "=ON;"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SWITCH_EIGHT_ON_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 4;
        I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 4;
        CMD  .UpdateValue ( "POE 8," + Functions.ItoA (  (int) ( I ) ) + "=ON;"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SWITCH_FIVE_OFF_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 4;
        I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 4;
        CMD  .UpdateValue ( "POE 5," + Functions.ItoA (  (int) ( I ) ) + "=OFF;"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SWITCH_SIX_OFF_OnPush_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 5;
        I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 5;
        CMD  .UpdateValue ( "POE 6," + Functions.ItoA (  (int) ( I ) ) + "=OFF;"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SWITCH_SEVEN_OFF_OnPush_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 5;
        I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 5;
        CMD  .UpdateValue ( "POE 7," + Functions.ItoA (  (int) ( I ) ) + "=OFF;"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SWITCH_EIGHT_OFF_OnPush_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 5;
        I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 5;
        CMD  .UpdateValue ( "POE 8," + Functions.ItoA (  (int) ( I ) ) + "=OFF;"  ) ; 
        
        
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
    
    SWITCH_ONE_ON = new InOutArray<DigitalInput>( 52, this );
    for( uint i = 0; i < 52; i++ )
    {
        SWITCH_ONE_ON[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( SWITCH_ONE_ON__DigitalInput__ + i, SWITCH_ONE_ON__DigitalInput__, this );
        m_DigitalInputList.Add( SWITCH_ONE_ON__DigitalInput__ + i, SWITCH_ONE_ON[i+1] );
    }
    
    SWITCH_ONE_OFF = new InOutArray<DigitalInput>( 52, this );
    for( uint i = 0; i < 52; i++ )
    {
        SWITCH_ONE_OFF[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( SWITCH_ONE_OFF__DigitalInput__ + i, SWITCH_ONE_OFF__DigitalInput__, this );
        m_DigitalInputList.Add( SWITCH_ONE_OFF__DigitalInput__ + i, SWITCH_ONE_OFF[i+1] );
    }
    
    SWITCH_TWO_ON = new InOutArray<DigitalInput>( 52, this );
    for( uint i = 0; i < 52; i++ )
    {
        SWITCH_TWO_ON[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( SWITCH_TWO_ON__DigitalInput__ + i, SWITCH_TWO_ON__DigitalInput__, this );
        m_DigitalInputList.Add( SWITCH_TWO_ON__DigitalInput__ + i, SWITCH_TWO_ON[i+1] );
    }
    
    SWITCH_TWO_OFF = new InOutArray<DigitalInput>( 52, this );
    for( uint i = 0; i < 52; i++ )
    {
        SWITCH_TWO_OFF[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( SWITCH_TWO_OFF__DigitalInput__ + i, SWITCH_TWO_OFF__DigitalInput__, this );
        m_DigitalInputList.Add( SWITCH_TWO_OFF__DigitalInput__ + i, SWITCH_TWO_OFF[i+1] );
    }
    
    SWITCH_THREE_ON = new InOutArray<DigitalInput>( 52, this );
    for( uint i = 0; i < 52; i++ )
    {
        SWITCH_THREE_ON[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( SWITCH_THREE_ON__DigitalInput__ + i, SWITCH_THREE_ON__DigitalInput__, this );
        m_DigitalInputList.Add( SWITCH_THREE_ON__DigitalInput__ + i, SWITCH_THREE_ON[i+1] );
    }
    
    SWITCH_THREE_OFF = new InOutArray<DigitalInput>( 52, this );
    for( uint i = 0; i < 52; i++ )
    {
        SWITCH_THREE_OFF[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( SWITCH_THREE_OFF__DigitalInput__ + i, SWITCH_THREE_OFF__DigitalInput__, this );
        m_DigitalInputList.Add( SWITCH_THREE_OFF__DigitalInput__ + i, SWITCH_THREE_OFF[i+1] );
    }
    
    SWITCH_FOUR_ON = new InOutArray<DigitalInput>( 52, this );
    for( uint i = 0; i < 52; i++ )
    {
        SWITCH_FOUR_ON[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( SWITCH_FOUR_ON__DigitalInput__ + i, SWITCH_FOUR_ON__DigitalInput__, this );
        m_DigitalInputList.Add( SWITCH_FOUR_ON__DigitalInput__ + i, SWITCH_FOUR_ON[i+1] );
    }
    
    SWITCH_FOUR_OFF = new InOutArray<DigitalInput>( 52, this );
    for( uint i = 0; i < 52; i++ )
    {
        SWITCH_FOUR_OFF[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( SWITCH_FOUR_OFF__DigitalInput__ + i, SWITCH_FOUR_OFF__DigitalInput__, this );
        m_DigitalInputList.Add( SWITCH_FOUR_OFF__DigitalInput__ + i, SWITCH_FOUR_OFF[i+1] );
    }
    
    SWITCH_FIVE_ON = new InOutArray<DigitalInput>( 52, this );
    for( uint i = 0; i < 52; i++ )
    {
        SWITCH_FIVE_ON[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( SWITCH_FIVE_ON__DigitalInput__ + i, SWITCH_FIVE_ON__DigitalInput__, this );
        m_DigitalInputList.Add( SWITCH_FIVE_ON__DigitalInput__ + i, SWITCH_FIVE_ON[i+1] );
    }
    
    SWITCH_FIVE_OFF = new InOutArray<DigitalInput>( 52, this );
    for( uint i = 0; i < 52; i++ )
    {
        SWITCH_FIVE_OFF[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( SWITCH_FIVE_OFF__DigitalInput__ + i, SWITCH_FIVE_OFF__DigitalInput__, this );
        m_DigitalInputList.Add( SWITCH_FIVE_OFF__DigitalInput__ + i, SWITCH_FIVE_OFF[i+1] );
    }
    
    SWITCH_SIX_ON = new InOutArray<DigitalInput>( 52, this );
    for( uint i = 0; i < 52; i++ )
    {
        SWITCH_SIX_ON[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( SWITCH_SIX_ON__DigitalInput__ + i, SWITCH_SIX_ON__DigitalInput__, this );
        m_DigitalInputList.Add( SWITCH_SIX_ON__DigitalInput__ + i, SWITCH_SIX_ON[i+1] );
    }
    
    SWITCH_SIX_OFF = new InOutArray<DigitalInput>( 52, this );
    for( uint i = 0; i < 52; i++ )
    {
        SWITCH_SIX_OFF[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( SWITCH_SIX_OFF__DigitalInput__ + i, SWITCH_SIX_OFF__DigitalInput__, this );
        m_DigitalInputList.Add( SWITCH_SIX_OFF__DigitalInput__ + i, SWITCH_SIX_OFF[i+1] );
    }
    
    SWITCH_SEVEN_ON = new InOutArray<DigitalInput>( 52, this );
    for( uint i = 0; i < 52; i++ )
    {
        SWITCH_SEVEN_ON[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( SWITCH_SEVEN_ON__DigitalInput__ + i, SWITCH_SEVEN_ON__DigitalInput__, this );
        m_DigitalInputList.Add( SWITCH_SEVEN_ON__DigitalInput__ + i, SWITCH_SEVEN_ON[i+1] );
    }
    
    SWITCH_SEVEN_OFF = new InOutArray<DigitalInput>( 52, this );
    for( uint i = 0; i < 52; i++ )
    {
        SWITCH_SEVEN_OFF[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( SWITCH_SEVEN_OFF__DigitalInput__ + i, SWITCH_SEVEN_OFF__DigitalInput__, this );
        m_DigitalInputList.Add( SWITCH_SEVEN_OFF__DigitalInput__ + i, SWITCH_SEVEN_OFF[i+1] );
    }
    
    SWITCH_EIGHT_ON = new InOutArray<DigitalInput>( 52, this );
    for( uint i = 0; i < 52; i++ )
    {
        SWITCH_EIGHT_ON[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( SWITCH_EIGHT_ON__DigitalInput__ + i, SWITCH_EIGHT_ON__DigitalInput__, this );
        m_DigitalInputList.Add( SWITCH_EIGHT_ON__DigitalInput__ + i, SWITCH_EIGHT_ON[i+1] );
    }
    
    SWITCH_EIGHT_OFF = new InOutArray<DigitalInput>( 52, this );
    for( uint i = 0; i < 52; i++ )
    {
        SWITCH_EIGHT_OFF[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( SWITCH_EIGHT_OFF__DigitalInput__ + i, SWITCH_EIGHT_OFF__DigitalInput__, this );
        m_DigitalInputList.Add( SWITCH_EIGHT_OFF__DigitalInput__ + i, SWITCH_EIGHT_OFF[i+1] );
    }
    
    CMD = new Crestron.Logos.SplusObjects.StringOutput( CMD__AnalogSerialOutput__, this );
    m_StringOutputList.Add( CMD__AnalogSerialOutput__, CMD );
    
    
    for( uint i = 0; i < 52; i++ )
        SWITCH_ONE_ON[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( SWITCH_ONE_ON_OnPush_0, false ) );
        
    for( uint i = 0; i < 52; i++ )
        SWITCH_TWO_ON[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( SWITCH_TWO_ON_OnPush_1, false ) );
        
    for( uint i = 0; i < 52; i++ )
        SWITCH_THREE_ON[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( SWITCH_THREE_ON_OnPush_2, false ) );
        
    for( uint i = 0; i < 52; i++ )
        SWITCH_FOUR_ON[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( SWITCH_FOUR_ON_OnPush_3, false ) );
        
    for( uint i = 0; i < 52; i++ )
        SWITCH_ONE_OFF[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( SWITCH_ONE_OFF_OnPush_4, false ) );
        
    for( uint i = 0; i < 52; i++ )
        SWITCH_TWO_OFF[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( SWITCH_TWO_OFF_OnPush_5, false ) );
        
    for( uint i = 0; i < 52; i++ )
        SWITCH_THREE_OFF[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( SWITCH_THREE_OFF_OnPush_6, false ) );
        
    for( uint i = 0; i < 52; i++ )
        SWITCH_FOUR_OFF[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( SWITCH_FOUR_OFF_OnPush_7, false ) );
        
    for( uint i = 0; i < 52; i++ )
        SWITCH_FIVE_ON[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( SWITCH_FIVE_ON_OnPush_8, false ) );
        
    for( uint i = 0; i < 52; i++ )
        SWITCH_SIX_ON[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( SWITCH_SIX_ON_OnPush_9, false ) );
        
    for( uint i = 0; i < 52; i++ )
        SWITCH_SEVEN_ON[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( SWITCH_SEVEN_ON_OnPush_10, false ) );
        
    for( uint i = 0; i < 52; i++ )
        SWITCH_EIGHT_ON[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( SWITCH_EIGHT_ON_OnPush_11, false ) );
        
    for( uint i = 0; i < 52; i++ )
        SWITCH_FIVE_OFF[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( SWITCH_FIVE_OFF_OnPush_12, false ) );
        
    for( uint i = 0; i < 52; i++ )
        SWITCH_SIX_OFF[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( SWITCH_SIX_OFF_OnPush_13, false ) );
        
    for( uint i = 0; i < 52; i++ )
        SWITCH_SEVEN_OFF[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( SWITCH_SEVEN_OFF_OnPush_14, false ) );
        
    for( uint i = 0; i < 52; i++ )
        SWITCH_EIGHT_OFF[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( SWITCH_EIGHT_OFF_OnPush_15, false ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_JAP_AVSWITCH_POE_CONTROL_V2_08 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint SWITCH_ONE_ON__DigitalInput__ = 0;
const uint SWITCH_ONE_OFF__DigitalInput__ = 52;
const uint SWITCH_TWO_ON__DigitalInput__ = 104;
const uint SWITCH_TWO_OFF__DigitalInput__ = 156;
const uint SWITCH_THREE_ON__DigitalInput__ = 208;
const uint SWITCH_THREE_OFF__DigitalInput__ = 260;
const uint SWITCH_FOUR_ON__DigitalInput__ = 312;
const uint SWITCH_FOUR_OFF__DigitalInput__ = 364;
const uint SWITCH_FIVE_ON__DigitalInput__ = 416;
const uint SWITCH_FIVE_OFF__DigitalInput__ = 468;
const uint SWITCH_SIX_ON__DigitalInput__ = 520;
const uint SWITCH_SIX_OFF__DigitalInput__ = 572;
const uint SWITCH_SEVEN_ON__DigitalInput__ = 624;
const uint SWITCH_SEVEN_OFF__DigitalInput__ = 676;
const uint SWITCH_EIGHT_ON__DigitalInput__ = 728;
const uint SWITCH_EIGHT_OFF__DigitalInput__ = 780;
const uint CMD__AnalogSerialOutput__ = 0;

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
