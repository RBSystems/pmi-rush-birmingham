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

namespace UserModule_JAP_AVSWITCH_CISCO_V2_08
{
    public class UserModuleClass_JAP_AVSWITCH_CISCO_V2_08 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        private ushort _12 (  SplusExecutionContext __context__, ushort _14 ) 
            { 
            
            __context__.SourceCodeLine = 3;
            return (ushort)( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _14 >= 64 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _14 <= 90 ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _14 >= 96 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _14 <= 122 ) )) ) )) )) ; 
            
            }
            
        private ushort _13 (  SplusExecutionContext __context__, ushort _15 ) 
            { 
            
            __context__.SourceCodeLine = 3;
            return (ushort)( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _15 < 32 ) ) || Functions.TestForTrue ( Functions.BoolToInt (_15 == 127) )) )) ; 
            
            }
            
        private ushort _14 (  SplusExecutionContext __context__, ushort _16 ) 
            { 
            
            __context__.SourceCodeLine = 3;
            return (ushort)( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _16 >= 48 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _16 <= 57 ) )) )) ; 
            
            }
            
        private ushort _15 (  SplusExecutionContext __context__, ushort _17 ) 
            { 
            
            __context__.SourceCodeLine = 3;
            return (ushort)( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _17 >= 96 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _17 <= 122 ) )) )) ; 
            
            }
            
        private ushort _16 (  SplusExecutionContext __context__, ushort _18 ) 
            { 
            
            __context__.SourceCodeLine = 4;
            return (ushort)( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _18 >= 33 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _18 <= 47 ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _18 >= 58 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _18 <= 64 ) )) ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _18 >= 91 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _18 <= 96 ) )) ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _18 >= 123 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _18 <= 126 ) )) ) )) )) ; 
            
            }
            
        private ushort _17 (  SplusExecutionContext __context__, ushort _19 ) 
            { 
            
            __context__.SourceCodeLine = 4;
            return (ushort)( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_19 == 9) ) || Functions.TestForTrue ( Functions.BoolToInt (_19 == 10) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (_19 == 13) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (_19 == 32) )) )) ; 
            
            }
            
        private ushort _18 (  SplusExecutionContext __context__, ushort _20 ) 
            { 
            
            __context__.SourceCodeLine = 4;
            return (ushort)( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _20 >= 64 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _20 <= 90 ) )) )) ; 
            
            }
            
        private ushort _19 (  SplusExecutionContext __context__, ushort _21 ) 
            { 
            
            __context__.SourceCodeLine = 4;
            return (ushort)( Functions.BoolToInt ( (Functions.TestForTrue ( _14( __context__ , (ushort)( _21 ) ) ) || Functions.TestForTrue ( _12( __context__ , (ushort)( _21 ) ) )) )) ; 
            
            }
            
        private ushort _20 (  SplusExecutionContext __context__, ushort _22 ) 
            { 
            
            __context__.SourceCodeLine = 4;
            return (ushort)( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( _14( __context__ , (ushort)( _22 ) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _22 >= 65 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _22 <= 70 ) )) ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _22 >= 97 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _22 <= 102 ) )) ) )) )) ; 
            
            }
            
        private ushort _21 (  SplusExecutionContext __context__, ref _0 _23 , ushort _24 , CrestronString _5 , ushort _25 ) 
            { 
            ushort _26 = 0;
            
            ushort _27 = 0;
            
            
            __context__.SourceCodeLine = 5;
            _23 . _5  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 5;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( _5 ) > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt (Byte( _5 , (int)( 1 ) ) == 94) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 5;
                _26 = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 5;
                _25 = (ushort) ( (_25 - 1) ) ; 
                __context__.SourceCodeLine = 5;
                _23 . _5  .UpdateValue ( Functions.Right ( _5 ,  (int) ( _25 ) )  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 5;
                _26 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 5;
                _23 . _5  .UpdateValue ( _5  ) ; 
                } 
            
            __context__.SourceCodeLine = 5;
            _23 . _1  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 5;
            _23 . _2 = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 5;
            _23 . _6 = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 5;
            _23 . _7 = (ushort) ( (_24 + 1) ) ; 
            __context__.SourceCodeLine = 5;
            _23 . _8 = (ushort) ( (_25 + 1) ) ; 
            __context__.SourceCodeLine = 5;
            _23 . _9 = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 5;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 0 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)(10 - 1); 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( _27  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_27  >= __FN_FORSTART_VAL__1) && (_27  <= __FN_FOREND_VAL__1) ) : ( (_27  <= __FN_FORSTART_VAL__1) && (_27  >= __FN_FOREND_VAL__1) ) ; _27  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 5;
                _23 . _3 [ _27] = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 5;
                _23 . _4 [ _27] = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 5;
                _23 . _10 [ _27] = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 5;
                _23 . _11 [ _27] = (short) ( 0 ) ; 
                __context__.SourceCodeLine = 5;
                } 
            
            __context__.SourceCodeLine = 5;
            return (ushort)( _26) ; 
            
            }
            
        private ushort _22 (  SplusExecutionContext __context__, ref _0 _24 , ushort _25 , CrestronString _26 ) 
            { 
            
            __context__.SourceCodeLine = 5;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (_24._2 + _25) > 10 ))  ) ) 
                { 
                __context__.SourceCodeLine = 5;
                _25 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 5;
                _24 . _1  .UpdateValue ( _26  ) ; 
                } 
            
            __context__.SourceCodeLine = 5;
            return (ushort)( _25) ; 
            
            }
            
        private ushort _23 (  SplusExecutionContext __context__, ref _0 _25 , ushort _26 , ushort _27 ) 
            { 
            ushort _28 = 0;
            
            ushort _3 = 0;
            
            
            __context__.SourceCodeLine = 5;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _25._2 >= 10 ))  ) ) 
                { 
                __context__.SourceCodeLine = 5;
                _25 . _1  .UpdateValue ( "stack overflow"  ) ; 
                __context__.SourceCodeLine = 5;
                _28 = (ushort) ( 0 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 6;
                _3 = (ushort) ( ((_26 - _25._6) + 1) ) ; 
                __context__.SourceCodeLine = 6;
                _25 . _3 [ _25._2] = (ushort) ( _3 ) ; 
                __context__.SourceCodeLine = 6;
                _25 . _4 [ _25._2] = (ushort) ( (_3 + (_27 - _26)) ) ; 
                __context__.SourceCodeLine = 6;
                _25 . _2 = (ushort) ( (_25._2 + 1) ) ; 
                __context__.SourceCodeLine = 6;
                _28 = (ushort) ( 1 ) ; 
                } 
            
            __context__.SourceCodeLine = 6;
            return (ushort)( _28) ; 
            
            }
            
        private ushort _24 (  SplusExecutionContext __context__, ref _0 _26 , ushort _27 ) 
            { 
            
            __context__.SourceCodeLine = 6;
            _27 = (ushort) ( (_27 - 49) ) ; 
            __context__.SourceCodeLine = 6;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _27 < 0 ) ) || Functions.TestForTrue ( Functions.BoolToInt ( _27 >= _26._9 ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (_26._11[ _27 ] == Functions.ToSignedLongInteger( -( 1 ) )) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 6;
                _26 . _1  .UpdateValue ( "invalid capture index"  ) ; 
                __context__.SourceCodeLine = 6;
                _27 = (ushort) ( 0 ) ; 
                } 
            
            __context__.SourceCodeLine = 6;
            return (ushort)( _27) ; 
            
            }
            
        private short _25 (  SplusExecutionContext __context__, ref _0 _27 ) 
            { 
            ushort _9 = 0;
            
            
            __context__.SourceCodeLine = 6;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( _27._9 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)0; 
            int __FN_FORSTEP_VAL__1 = (int)Functions.ToLongInteger( -( 1 ) ); 
            for ( _9  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_9  >= __FN_FORSTART_VAL__1) && (_9  <= __FN_FOREND_VAL__1) ) : ( (_9  <= __FN_FORSTART_VAL__1) && (_9  >= __FN_FOREND_VAL__1) ) ; _9  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 6;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_27._11[ _9 ] == Functions.ToSignedLongInteger( -( 1 ) )))  ) ) 
                    {
                    __context__.SourceCodeLine = 6;
                    return (short)( _9) ; 
                    }
                
                __context__.SourceCodeLine = 6;
                } 
            
            __context__.SourceCodeLine = 6;
            _27 . _1  .UpdateValue ( "invalid pattern capture"  ) ; 
            __context__.SourceCodeLine = 6;
            return (short)( Functions.ToSignedInteger( -( 1 ) )) ; 
            
            }
            
        private ushort _26 (  SplusExecutionContext __context__, ref _0 _28 , ushort _29 ) 
            { 
            
            __context__.SourceCodeLine = 6;
            _29 = (ushort) ( (_29 + 1) ) ; 
            __context__.SourceCodeLine = 6;
            
                {
                int __SPLS_TMPVAR__SWTCH_1__ = ((int)Byte( _28._5 , (int)( (_29 - 1) ) ));
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 37) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 7;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_29 == _28._8))  ) ) 
                            { 
                            __context__.SourceCodeLine = 7;
                            _28 . _1  .UpdateValue ( "malformed pattern (ends with %)"  ) ; 
                            __context__.SourceCodeLine = 7;
                            return (ushort)( _29) ; 
                            } 
                        
                        __context__.SourceCodeLine = 7;
                        return (ushort)( (_29 + 1)) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 91) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 7;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _29 < _28._8 ) ) && Functions.TestForTrue ( Functions.BoolToInt (Byte( _28._5 , (int)( _29 ) ) == 94) )) ))  ) ) 
                            {
                            __context__.SourceCodeLine = 7;
                            _29 = (ushort) ( (_29 + 1) ) ; 
                            }
                        
                        __context__.SourceCodeLine = 7;
                        do 
                            { 
                            __context__.SourceCodeLine = 7;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_29 == _28._8))  ) ) 
                                { 
                                __context__.SourceCodeLine = 7;
                                _28 . _1  .UpdateValue ( "malformed pattern (missing ])"  ) ; 
                                __context__.SourceCodeLine = 7;
                                return (ushort)( _29) ; 
                                } 
                            
                            __context__.SourceCodeLine = 7;
                            _29 = (ushort) ( (_29 + 1) ) ; 
                            __context__.SourceCodeLine = 7;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Byte( _28._5 , (int)( (_29 - 1) ) ) == 37) ) && Functions.TestForTrue ( Functions.BoolToInt ( _29 < _28._8 ) )) ))  ) ) 
                                {
                                __context__.SourceCodeLine = 7;
                                _29 = (ushort) ( (_29 + 1) ) ; 
                                }
                            
                            } 
                        while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (Byte( _28._5 , (int)( _29 ) ) == 93)) )); 
                        __context__.SourceCodeLine = 7;
                        return (ushort)( (_29 + 1)) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 7;
                        return (ushort)( _29) ; 
                        } 
                    
                    } 
                    
                }
                
            
            
            return 0; // default return value (none specified in module)
            }
            
        private ushort _27 (  SplusExecutionContext __context__, ushort _29 , ushort _30 ) 
            { 
            ushort _31 = 0;
            
            
            __context__.SourceCodeLine = 7;
            
                {
                int __SPLS_TMPVAR__SWTCH_2__ = ((int)Functions.LowerChar( (uint)( _30 ) ));
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == (  (uint) ( 97 ) ) ) ) ) 
                        {
                        __context__.SourceCodeLine = 7;
                        _31 = (ushort) ( _12( __context__ , (ushort)( _29 ) ) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 99) ) ) ) 
                        {
                        __context__.SourceCodeLine = 7;
                        _31 = (ushort) ( _13( __context__ , (ushort)( _29 ) ) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 100) ) ) ) 
                        {
                        __context__.SourceCodeLine = 7;
                        _31 = (ushort) ( _14( __context__ , (ushort)( _29 ) ) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 108) ) ) ) 
                        {
                        __context__.SourceCodeLine = 8;
                        _31 = (ushort) ( _15( __context__ , (ushort)( _29 ) ) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 112) ) ) ) 
                        {
                        __context__.SourceCodeLine = 8;
                        _31 = (ushort) ( _16( __context__ , (ushort)( _29 ) ) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 115) ) ) ) 
                        {
                        __context__.SourceCodeLine = 8;
                        _31 = (ushort) ( _17( __context__ , (ushort)( _29 ) ) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 117) ) ) ) 
                        {
                        __context__.SourceCodeLine = 8;
                        _31 = (ushort) ( _18( __context__ , (ushort)( _29 ) ) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 119) ) ) ) 
                        {
                        __context__.SourceCodeLine = 8;
                        _31 = (ushort) ( _19( __context__ , (ushort)( _29 ) ) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 120) ) ) ) 
                        {
                        __context__.SourceCodeLine = 8;
                        _31 = (ushort) ( _20( __context__ , (ushort)( _29 ) ) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 122) ) ) ) 
                        {
                        __context__.SourceCodeLine = 8;
                        return (ushort)( Functions.BoolToInt (_29 == 0)) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 8;
                        return (ushort)( Functions.BoolToInt (_30 == _29)) ; 
                        }
                    
                    } 
                    
                }
                
            
            __context__.SourceCodeLine = 8;
            if ( Functions.TestForTrue  ( ( _18( __context__ , (ushort)( _30 ) ))  ) ) 
                {
                __context__.SourceCodeLine = 8;
                _31 = (ushort) ( Functions.Not( _31 ) ) ; 
                }
            
            __context__.SourceCodeLine = 8;
            return (ushort)( _31) ; 
            
            }
            
        private ushort _28 (  SplusExecutionContext __context__, ref _0 _30 , ushort _31 , ushort _32 , ushort _33 ) 
            { 
            ushort _34 = 0;
            
            
            __context__.SourceCodeLine = 8;
            _34 = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 8;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (_32 + 1) < _30._8 ) ) && Functions.TestForTrue ( Functions.BoolToInt (Byte( _30._5 , (int)( (_32 + 1) ) ) == 94) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 8;
                _34 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 8;
                _32 = (ushort) ( (_32 + 1) ) ; 
                } 
            
            __context__.SourceCodeLine = 8;
            _32 = (ushort) ( (_32 + 1) ) ; 
            __context__.SourceCodeLine = 8;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _32 < _33 ))  ) ) 
                { 
                __context__.SourceCodeLine = 8;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( _30._5 , (int)( _32 ) ) == 37))  ) ) 
                    { 
                    __context__.SourceCodeLine = 8;
                    _32 = (ushort) ( (_32 + 1) ) ; 
                    __context__.SourceCodeLine = 8;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _32 < _30._8 ) ) && Functions.TestForTrue ( _27( __context__ , (ushort)( _31 ) , (ushort)( Byte( _30._5 , (int)( _32 ) ) ) ) )) ))  ) ) 
                        {
                        __context__.SourceCodeLine = 8;
                        return (ushort)( _34) ; 
                        }
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 9;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (_32 + 1) < _30._8 ) ) && Functions.TestForTrue ( Functions.BoolToInt (Byte( _30._5 , (int)( (_32 + 1) ) ) == 45) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( (_32 + 2) < _33 ) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 9;
                        _32 = (ushort) ( (_32 + 2) ) ; 
                        __context__.SourceCodeLine = 9;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Byte( _30._5 , (int)( (_32 - 2) ) ) <= _31 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _31 <= Byte( _30._5 , (int)( _32 ) ) ) )) ))  ) ) 
                            {
                            __context__.SourceCodeLine = 9;
                            return (ushort)( _34) ; 
                            }
                        
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 9;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( _30._5 , (int)( _32 ) ) == _31))  ) ) 
                            {
                            __context__.SourceCodeLine = 9;
                            return (ushort)( _34) ; 
                            }
                        
                        }
                    
                    }
                
                __context__.SourceCodeLine = 9;
                _32 = (ushort) ( (_32 + 1) ) ; 
                __context__.SourceCodeLine = 8;
                } 
            
            __context__.SourceCodeLine = 9;
            return (ushort)( Functions.Not( _34 )) ; 
            
            }
            
        private ushort _29 (  SplusExecutionContext __context__, ref _0 _31 , ushort _32 , ushort _33 , ushort _34 ) 
            { 
            
            __context__.SourceCodeLine = 9;
            
                {
                int __SPLS_TMPVAR__SWTCH_3__ = ((int)Byte( _31._5 , (int)( _33 ) ));
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 46) ) ) ) 
                        {
                        __context__.SourceCodeLine = 9;
                        return (ushort)( 1) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 37) ) ) ) 
                        {
                        __context__.SourceCodeLine = 9;
                        return (ushort)( _27( __context__ , (ushort)( _32 ) , (ushort)( Byte( _31._5 , (int)( (_33 + 1) ) ) ) )) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 91) ) ) ) 
                        {
                        __context__.SourceCodeLine = 9;
                        return (ushort)( _28( __context__ , ref _31 , (ushort)( _32 ) , (ushort)( _33 ) , (ushort)( (_34 - 1) ) )) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 9;
                        return (ushort)( Functions.BoolToInt (Byte( _31._5 , (int)( _33 ) ) == _32)) ; 
                        }
                    
                    } 
                    
                }
                
            
            
            return 0; // default return value (none specified in module)
            }
            
        private ushort _30 (  SplusExecutionContext __context__, ref _0 _32 , CrestronString _33 , ushort _34 , ushort _35 ) 
            { 
            ushort _36 = 0;
            
            ushort _37 = 0;
            
            ushort _38 = 0;
            
            
            __context__.SourceCodeLine = 10;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _35 >= (_32._8 - 1) ))  ) ) 
                { 
                __context__.SourceCodeLine = 10;
                _32 . _1  .UpdateValue ( "malformed pattern (missing arguments to %b)"  ) ; 
                __context__.SourceCodeLine = 10;
                return (ushort)( 0) ; 
                } 
            
            __context__.SourceCodeLine = 10;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( _33 , (int)( _34 ) ) != Byte( _32._5 , (int)( _35 ) )))  ) ) 
                {
                __context__.SourceCodeLine = 10;
                return (ushort)( 0) ; 
                }
            
            else 
                { 
                __context__.SourceCodeLine = 10;
                _36 = (ushort) ( Byte( _32._5 , (int)( _35 ) ) ) ; 
                __context__.SourceCodeLine = 10;
                _37 = (ushort) ( Byte( _32._5 , (int)( (_35 + 1) ) ) ) ; 
                __context__.SourceCodeLine = 10;
                _38 = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 10;
                _34 = (ushort) ( (_34 + 1) ) ; 
                __context__.SourceCodeLine = 10;
                while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _34 < _32._7 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 10;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( _33 , (int)( _34 ) ) == _37))  ) ) 
                        { 
                        __context__.SourceCodeLine = 10;
                        _38 = (ushort) ( (_38 - 1) ) ; 
                        __context__.SourceCodeLine = 10;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_38 == 0))  ) ) 
                            {
                            __context__.SourceCodeLine = 10;
                            return (ushort)( (_34 + 1)) ; 
                            }
                        
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 10;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( _33 , (int)( _34 ) ) == _36))  ) ) 
                            {
                            __context__.SourceCodeLine = 10;
                            _38 = (ushort) ( (_38 + 1) ) ; 
                            }
                        
                        }
                    
                    __context__.SourceCodeLine = 10;
                    _34 = (ushort) ( (_34 + 1) ) ; 
                    __context__.SourceCodeLine = 10;
                    } 
                
                } 
            
            __context__.SourceCodeLine = 10;
            return (ushort)( 0) ; 
            
            }
            
        private ushort _31 (  SplusExecutionContext __context__, ref _0 _33 , CrestronString _34 , ushort _35 , ushort _36 ) 
            { 
            ushort _11 = 0;
            
            
            __context__.SourceCodeLine = 11;
            _36 = (ushort) ( _24( __context__ , ref _33 , (ushort)( _36 ) ) ) ; 
            __context__.SourceCodeLine = 11;
            _11 = (ushort) ( _33._11[ _36 ] ) ; 
            __context__.SourceCodeLine = 11;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (_33._7 - _35) >= _11 ) ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Mid( _34 , (int)( _33._10[ _36 ] ) , (int)( _11 ) ) == Functions.Mid( _34 , (int)( _35 ) , (int)( _11 ) )) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 11;
                return (ushort)( (_35 + _11)) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 11;
                return (ushort)( 0) ; 
                }
            
            
            return 0; // default return value (none specified in module)
            }
            
        private ushort _32 (  SplusExecutionContext __context__, ref _0 _34 , CrestronString _35 , ushort _36 , ushort _37 ) 
            { 
            ushort _38 = 0;
            
            ushort _39 = 0;
            
            short _40 = 0;
            
            ushort _41 = 0;
            
            ushort _42 = 0;
            
            short _43 = 0;
            
            ushort _44 = 0;
            
            
            __context__.SourceCodeLine = 11;
            while ( Functions.TestForTrue  ( ( 1)  ) ) 
                { 
                __context__.SourceCodeLine = 11;
                _41 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 11;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_37 == _34._8))  ) ) 
                    { 
                    __context__.SourceCodeLine = 11;
                    return (ushort)( _36) ; 
                    } 
                
                __context__.SourceCodeLine = 11;
                
                    {
                    int __SPLS_TMPVAR__SWTCH_4__ = ((int)Byte( _34._5 , (int)( _37 ) ));
                    
                        { 
                        if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 40) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 11;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( _34._5 , (int)( (_37 + 1) ) ) == 41))  ) ) 
                                { 
                                __context__.SourceCodeLine = 11;
                                _40 = (short) ( Functions.ToSignedInteger( -( 2 ) ) ) ; 
                                __context__.SourceCodeLine = 11;
                                _37 = (ushort) ( (_37 + 2) ) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 11;
                                _40 = (short) ( Functions.ToSignedInteger( -( 1 ) ) ) ; 
                                __context__.SourceCodeLine = 11;
                                _37 = (ushort) ( (_37 + 1) ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 11;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _34._9 >= 10 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 11;
                                _34 . _1  .UpdateValue ( "too many captures"  ) ; 
                                __context__.SourceCodeLine = 11;
                                return (ushort)( 0) ; 
                                } 
                            
                            __context__.SourceCodeLine = 12;
                            _34 . _10 [ _34._9] = (ushort) ( _36 ) ; 
                            __context__.SourceCodeLine = 12;
                            _34 . _11 [ _34._9] = (short) ( _40 ) ; 
                            __context__.SourceCodeLine = 12;
                            _34 . _9 = (ushort) ( (_34._9 + 1) ) ; 
                            __context__.SourceCodeLine = 12;
                            _44 = (ushort) ( _32( __context__ , ref _34 , _35 , (ushort)( _36 ) , (ushort)( _37 ) ) ) ; 
                            __context__.SourceCodeLine = 12;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_44 == 0))  ) ) 
                                {
                                __context__.SourceCodeLine = 12;
                                _34 . _9 = (ushort) ( (_34._9 - 1) ) ; 
                                }
                            
                            __context__.SourceCodeLine = 12;
                            return (ushort)( _44) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 41) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 12;
                            _43 = (short) ( _25( __context__ , ref _34 ) ) ; 
                            __context__.SourceCodeLine = 12;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _43 < 0 ))  ) ) 
                                {
                                __context__.SourceCodeLine = 12;
                                return (ushort)( 0) ; 
                                }
                            
                            __context__.SourceCodeLine = 12;
                            _34 . _11 [ _43] = (short) ( (_36 - _34._10[ _43 ]) ) ; 
                            __context__.SourceCodeLine = 12;
                            _44 = (ushort) ( _32( __context__ , ref _34 , _35 , (ushort)( _36 ) , (ushort)( (_37 + 1) ) ) ) ; 
                            __context__.SourceCodeLine = 12;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_44 == 0))  ) ) 
                                {
                                __context__.SourceCodeLine = 12;
                                _34 . _11 [ _43] = (short) ( Functions.ToInteger( -( 1 ) ) ) ; 
                                }
                            
                            __context__.SourceCodeLine = 12;
                            return (ushort)( _44) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 36) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 12;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ((_37 + 1) == _34._8))  ) ) 
                                { 
                                __context__.SourceCodeLine = 12;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_36 == _34._7))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 12;
                                    return (ushort)( _36) ; 
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 12;
                                    return (ushort)( 0) ; 
                                    } 
                                
                                } 
                            
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 37) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 12;
                            
                                {
                                int __SPLS_TMPVAR__SWTCH_5__ = ((int)Byte( _34._5 , (int)( (_37 + 1) ) ));
                                
                                    { 
                                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 98) ) ) ) 
                                        { 
                                        __context__.SourceCodeLine = 12;
                                        _36 = (ushort) ( _30( __context__ , ref _34 , _35 , (ushort)( _36 ) , (ushort)( (_37 + 2) ) ) ) ; 
                                        __context__.SourceCodeLine = 12;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_36 == 0))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 12;
                                            return (ushort)( 0) ; 
                                            } 
                                        
                                        __context__.SourceCodeLine = 12;
                                        _37 = (ushort) ( (_37 + 4) ) ; 
                                        __context__.SourceCodeLine = 12;
                                        _41 = (ushort) ( 1 ) ; 
                                        } 
                                    
                                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 102) ) ) ) 
                                        { 
                                        __context__.SourceCodeLine = 12;
                                        _37 = (ushort) ( (_37 + 2) ) ; 
                                        __context__.SourceCodeLine = 12;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( _34._5 , (int)( _37 ) ) != 91))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 13;
                                            _34 . _1  .UpdateValue ( "missing [ after %f in pattern"  ) ; 
                                            __context__.SourceCodeLine = 13;
                                            return (ushort)( 0) ; 
                                            } 
                                        
                                        __context__.SourceCodeLine = 13;
                                        _38 = (ushort) ( _26( __context__ , ref _34 , (ushort)( _37 ) ) ) ; 
                                        __context__.SourceCodeLine = 13;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_36 == _34._6))  ) ) 
                                            {
                                            __context__.SourceCodeLine = 13;
                                            _39 = (ushort) ( 0 ) ; 
                                            }
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 13;
                                            _39 = (ushort) ( Byte( _35 , (int)( (_36 - 1) ) ) ) ; 
                                            }
                                        
                                        __context__.SourceCodeLine = 13;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( _28( __context__ , ref _34 , (ushort)( _39 ) , (ushort)( _37 ) , (ushort)( (_38 - 1) ) ) ) || Functions.TestForTrue ( Functions.Not( _28( __context__ , ref _34 , (ushort)( Byte( _35 , (int)( _36 ) ) ) , (ushort)( _37 ) , (ushort)( (_38 - 1) ) ) ) )) ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 13;
                                            return (ushort)( 0) ; 
                                            } 
                                        
                                        __context__.SourceCodeLine = 13;
                                        _37 = (ushort) ( _38 ) ; 
                                        __context__.SourceCodeLine = 13;
                                        _41 = (ushort) ( 1 ) ; 
                                        } 
                                    
                                    else 
                                        { 
                                        __context__.SourceCodeLine = 13;
                                        if ( Functions.TestForTrue  ( ( _14( __context__ , (ushort)( Byte( _34._5 , (int)( (_37 + 1) ) ) ) ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 13;
                                            _36 = (ushort) ( _31( __context__ , ref _34 , _35 , (ushort)( _36 ) , (ushort)( Byte( _34._5 , (int)( (_37 + 1) ) ) ) ) ) ; 
                                            __context__.SourceCodeLine = 13;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_36 == 0))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 13;
                                                return (ushort)( 0) ; 
                                                } 
                                            
                                            __context__.SourceCodeLine = 13;
                                            _37 = (ushort) ( (_37 + 2) ) ; 
                                            __context__.SourceCodeLine = 13;
                                            _41 = (ushort) ( 1 ) ; 
                                            } 
                                        
                                        } 
                                    
                                    } 
                                    
                                }
                                
                            
                            } 
                        
                        else 
                            { 
                            } 
                        
                        } 
                        
                    }
                    
                
                __context__.SourceCodeLine = 13;
                if ( Functions.TestForTrue  ( ( Functions.Not( _41 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 13;
                    _38 = (ushort) ( _26( __context__ , ref _34 , (ushort)( _37 ) ) ) ; 
                    __context__.SourceCodeLine = 13;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _36 < _34._7 ) ) && Functions.TestForTrue ( _29( __context__ , ref _34 , (ushort)( Byte( _35 , (int)( _36 ) ) ) , (ushort)( _37 ) , (ushort)( _38 ) ) )) ))  ) ) 
                        {
                        __context__.SourceCodeLine = 13;
                        _40 = (short) ( 1 ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 13;
                        _40 = (short) ( 0 ) ; 
                        }
                    
                    __context__.SourceCodeLine = 13;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _38 >= _34._8 ))  ) ) 
                        {
                        __context__.SourceCodeLine = 13;
                        _42 = (ushort) ( 0 ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 13;
                        _42 = (ushort) ( Byte( _34._5 , (int)( _38 ) ) ) ; 
                        }
                    
                    __context__.SourceCodeLine = 13;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_42 == 63))  ) ) 
                        { 
                        __context__.SourceCodeLine = 13;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_40 != 0))  ) ) 
                            { 
                            __context__.SourceCodeLine = 14;
                            _40 = (short) ( _32( __context__ , ref _34 , _35 , (ushort)( (_36 + 1) ) , (ushort)( (_38 + 1) ) ) ) ; 
                            __context__.SourceCodeLine = 14;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_40 != 0))  ) ) 
                                { 
                                __context__.SourceCodeLine = 14;
                                return (ushort)( _40) ; 
                                } 
                            
                            } 
                        
                        __context__.SourceCodeLine = 14;
                        _37 = (ushort) ( (_38 + 1) ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 14;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_42 == 42) ) || Functions.TestForTrue ( Functions.BoolToInt (_42 == 43) )) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 14;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_42 == 43))  ) ) 
                                { 
                                __context__.SourceCodeLine = 14;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_40 == 0))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 14;
                                    return (ushort)( 0) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 14;
                                    _36 = (ushort) ( (_36 + 1) ) ; 
                                    }
                                
                                } 
                            
                            __context__.SourceCodeLine = 14;
                            _43 = (short) ( 0 ) ; 
                            __context__.SourceCodeLine = 14;
                            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (_36 + _43) < _34._7 ) ) && Functions.TestForTrue ( _29( __context__ , ref _34 , (ushort)( Byte( _35 , (int)( (_36 + _43) ) ) ) , (ushort)( _37 ) , (ushort)( _38 ) ) )) ))  ) ) 
                                {
                                __context__.SourceCodeLine = 14;
                                _43 = (short) ( (_43 + 1) ) ; 
                                __context__.SourceCodeLine = 14;
                                }
                            
                            __context__.SourceCodeLine = 14;
                            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _43 >= 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 14;
                                _44 = (ushort) ( _32( __context__ , ref _34 , _35 , (ushort)( (_36 + _43) ) , (ushort)( (_38 + 1) ) ) ) ; 
                                __context__.SourceCodeLine = 14;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _44 > 0 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 14;
                                    return (ushort)( _44) ; 
                                    } 
                                
                                __context__.SourceCodeLine = 14;
                                _43 = (short) ( (_43 - 1) ) ; 
                                __context__.SourceCodeLine = 14;
                                } 
                            
                            __context__.SourceCodeLine = 14;
                            return (ushort)( 0) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 14;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_42 == 45))  ) ) 
                                { 
                                __context__.SourceCodeLine = 14;
                                while ( Functions.TestForTrue  ( ( 1)  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 14;
                                    _44 = (ushort) ( _32( __context__ , ref _34 , _35 , (ushort)( _36 ) , (ushort)( (_38 + 1) ) ) ) ; 
                                    __context__.SourceCodeLine = 14;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_44 != 0))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 14;
                                        return (ushort)( _44) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 14;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _36 < _34._7 ) ) && Functions.TestForTrue ( _29( __context__ , ref _34 , (ushort)( Byte( _35 , (int)( _36 ) ) ) , (ushort)( _37 ) , (ushort)( _38 ) ) )) ))  ) ) 
                                            {
                                            __context__.SourceCodeLine = 14;
                                            _36 = (ushort) ( (_36 + 1) ) ; 
                                            }
                                        
                                        else 
                                            { 
                                            __context__.SourceCodeLine = 14;
                                            return (ushort)( 0) ; 
                                            } 
                                        
                                        }
                                    
                                    __context__.SourceCodeLine = 14;
                                    } 
                                
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 14;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_40 == 0))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 14;
                                    return (ushort)( 0) ; 
                                    } 
                                
                                __context__.SourceCodeLine = 14;
                                _36 = (ushort) ( (_36 + 1) ) ; 
                                __context__.SourceCodeLine = 15;
                                _37 = (ushort) ( _38 ) ; 
                                } 
                            
                            }
                        
                        }
                    
                    } 
                
                __context__.SourceCodeLine = 11;
                } 
            
            
            return 0; // default return value (none specified in module)
            }
            
        private ushort _33 (  SplusExecutionContext __context__, ref _0 _35 , ushort _36 , ushort _37 , ushort _38 ) 
            { 
            ushort _39 = 0;
            
            short _40 = 0;
            
            
            __context__.SourceCodeLine = 15;
            _39 = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 15;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _36 >= _35._9 ))  ) ) 
                { 
                __context__.SourceCodeLine = 15;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_36 == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 15;
                    _39 = (ushort) ( _23( __context__ , ref _35 , (ushort)( _37 ) , (ushort)( _38 ) ) ) ; 
                    }
                
                else 
                    { 
                    __context__.SourceCodeLine = 15;
                    _35 . _1  .UpdateValue ( "invalid capture index"  ) ; 
                    __context__.SourceCodeLine = 15;
                    _39 = (ushort) ( 0 ) ; 
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 15;
                _40 = (short) ( _35._11[ _36 ] ) ; 
                __context__.SourceCodeLine = 15;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_40 == Functions.ToSignedLongInteger( -( 1 ) )))  ) ) 
                    { 
                    __context__.SourceCodeLine = 15;
                    _35 . _1  .UpdateValue ( "unfinished capture"  ) ; 
                    __context__.SourceCodeLine = 15;
                    _39 = (ushort) ( 0 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 15;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_40 == Functions.ToSignedLongInteger( -( 2 ) )))  ) ) 
                        {
                        __context__.SourceCodeLine = 15;
                        _40 = (short) ( 0 ) ; 
                        }
                    
                    __context__.SourceCodeLine = 15;
                    _39 = (ushort) ( _23( __context__ , ref _35 , (ushort)( _35._10[ _36 ] ) , (ushort)( (_35._10[ _36 ] + _40) ) ) ) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 15;
            return (ushort)( _39) ; 
            
            }
            
        private ushort _34 (  SplusExecutionContext __context__, ref _0 _36 , ushort _37 , ushort _38 ) 
            { 
            ushort _39 = 0;
            
            ushort _40 = 0;
            
            
            __context__.SourceCodeLine = 15;
            _39 = (ushort) ( _22( __context__ , ref _36 , (ushort)( (_36._9 + 1) ) , "too many captures" ) ) ; 
            __context__.SourceCodeLine = 15;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _39 > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 16;
                _23 (  __context__ ,   ref  _36 , (ushort)( _37 ), (ushort)( _38 )) ; 
                __context__.SourceCodeLine = 16;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 0 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)(_39 - 2); 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( _40  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_40  >= __FN_FORSTART_VAL__1) && (_40  <= __FN_FOREND_VAL__1) ) : ( (_40  <= __FN_FORSTART_VAL__1) && (_40  >= __FN_FOREND_VAL__1) ) ; _40  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 16;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_33( __context__ , ref _36 , (ushort)( _40 ) , (ushort)( _37 ) , (ushort)( _38 ) ) == 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 16;
                        _39 = (ushort) ( _40 ) ; 
                        __context__.SourceCodeLine = 16;
                        break ; 
                        } 
                    
                    __context__.SourceCodeLine = 16;
                    } 
                
                } 
            
            __context__.SourceCodeLine = 16;
            return (ushort)( _39) ; 
            
            }
            
        private short _35 (  SplusExecutionContext __context__, CrestronString _37 , ushort _38 , ushort _39 , CrestronString _40 , ushort _41 , ushort _42 ) 
            { 
            
            __context__.SourceCodeLine = 16;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (_39 + _42) <= _38 ))  ) ) 
                { 
                __context__.SourceCodeLine = 16;
                _37  .UpdateValue ( Functions.Left ( _37 ,  (int) ( _39 ) ) + Functions.Mid ( _40 ,  (int) ( _41 ) ,  (int) ( _42 ) )  ) ; 
                __context__.SourceCodeLine = 16;
                return (short)( (_39 + _42)) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 16;
                _37  .UpdateValue ( "buffer overflow"  ) ; 
                __context__.SourceCodeLine = 16;
                return (short)( Functions.ToSignedInteger( -( 15 ) )) ; 
                } 
            
            
            return 0; // default return value (none specified in module)
            }
            
        private short _36 (  SplusExecutionContext __context__, ref _0 _38 , CrestronString _39 , ushort _40 , ushort _41 , CrestronString _42 , ushort _43 , ushort _44 , CrestronString _45 , ushort _46 ) 
            { 
            short _47 = 0;
            
            ushort _48 = 0;
            
            ushort _49 = 0;
            
            
            __context__.SourceCodeLine = 16;
            _47 = (short) ( _41 ) ; 
            __context__.SourceCodeLine = 16;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)_46; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( _48  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_48  >= __FN_FORSTART_VAL__1) && (_48  <= __FN_FOREND_VAL__1) ) : ( (_48  <= __FN_FORSTART_VAL__1) && (_48  >= __FN_FOREND_VAL__1) ) ; _48  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 17;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( _45 , (int)( _48 ) ) != 37))  ) ) 
                    {
                    __context__.SourceCodeLine = 17;
                    _47 = (short) ( _35( __context__ , _39 , (ushort)( _40 ) , (ushort)( _41 ) , _45 , (ushort)( _48 ) , (ushort)( 1 ) ) ) ; 
                    }
                
                else 
                    { 
                    __context__.SourceCodeLine = 17;
                    _48 = (ushort) ( (_48 + 1) ) ; 
                    __context__.SourceCodeLine = 17;
                    _49 = (ushort) ( Byte( _45 , (int)( _48 ) ) ) ; 
                    __context__.SourceCodeLine = 17;
                    if ( Functions.TestForTrue  ( ( Functions.Not( _14( __context__ , (ushort)( _49 ) ) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 17;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_49 == 37))  ) ) 
                            {
                            __context__.SourceCodeLine = 17;
                            _47 = (short) ( _35( __context__ , _39 , (ushort)( _40 ) , (ushort)( _41 ) , _45 , (ushort)( _48 ) , (ushort)( 1 ) ) ) ; 
                            }
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 17;
                            _39  .UpdateValue ( "invalid use of %c in replacement string"  ) ; 
                            __context__.SourceCodeLine = 17;
                            _47 = (short) ( Functions.ToSignedInteger( -( Functions.Length( _39 ) ) ) ) ; 
                            } 
                        
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 17;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_49 == 48))  ) ) 
                            {
                            __context__.SourceCodeLine = 17;
                            _47 = (short) ( _35( __context__ , _39 , (ushort)( _40 ) , (ushort)( _41 ) , _42 , (ushort)( _43 ) , (ushort)( (_44 - _43) ) ) ) ; 
                            }
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 17;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_33( __context__ , ref _38 , (ushort)( (_49 - 49) ) , (ushort)( _43 ) , (ushort)( _44 ) ) == 0))  ) ) 
                                { 
                                __context__.SourceCodeLine = 17;
                                _39  .UpdateValue ( _38 . _1  ) ; 
                                __context__.SourceCodeLine = 17;
                                _47 = (short) ( Functions.ToSignedInteger( -( Functions.Length( _39 ) ) ) ) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 17;
                                _47 = (short) ( _35( __context__ , _39 , (ushort)( _40 ) , (ushort)( _41 ) , _42 , (ushort)( ((_38._6 + _38._3[ (_38._2 - 1) ]) - 1) ) , (ushort)( (_38._4[ (_38._2 - 1) ] - _38._3[ (_38._2 - 1) ]) ) ) ) ; 
                                __context__.SourceCodeLine = 17;
                                _38 . _2 = (ushort) ( (_38._2 - 1) ) ; 
                                } 
                            
                            } 
                        
                        }
                    
                    } 
                
                __context__.SourceCodeLine = 17;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _47 < 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 17;
                    break ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 17;
                    _41 = (ushort) ( _47 ) ; 
                    }
                
                __context__.SourceCodeLine = 16;
                } 
            
            __context__.SourceCodeLine = 17;
            return (short)( _47) ; 
            
            }
            
        private ushort _37 (  SplusExecutionContext __context__, CrestronString _39 , ushort _40 , short _41 , CrestronString _5 , ushort _42 , ref _0 _43 ) 
            { 
            ushort _44 = 0;
            
            ushort _45 = 0;
            
            ushort _46 = 0;
            
            
            __context__.SourceCodeLine = 18;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _41 < 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 18;
                _41 = (short) ( ((_40 + _41) + 1) ) ; 
                }
            
            __context__.SourceCodeLine = 18;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _41 < 1 ))  ) ) 
                {
                __context__.SourceCodeLine = 18;
                _41 = (short) ( 1 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 18;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _41 > (_40 + 1) ))  ) ) 
                    {
                    __context__.SourceCodeLine = 18;
                    _41 = (short) ( (_40 + 1) ) ; 
                    }
                
                }
            
            __context__.SourceCodeLine = 18;
            _45 = (ushort) ( _41 ) ; 
            __context__.SourceCodeLine = 18;
            _44 = (ushort) ( _21( __context__ , ref _43 , (ushort)( _40 ) , _5 , (ushort)( _42 ) ) ) ; 
            __context__.SourceCodeLine = 18;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _45 < _43._7 ))  ) ) 
                { 
                __context__.SourceCodeLine = 18;
                do 
                    { 
                    __context__.SourceCodeLine = 18;
                    _43 . _9 = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 18;
                    _46 = (ushort) ( _32( __context__ , ref _43 , _39 , (ushort)( _45 ) , (ushort)( 1 ) ) ) ; 
                    __context__.SourceCodeLine = 18;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_46 != 0))  ) ) 
                        {
                        __context__.SourceCodeLine = 18;
                        return (ushort)( _34( __context__ , ref _43 , (ushort)( _45 ) , (ushort)( _46 ) )) ; 
                        }
                    
                    __context__.SourceCodeLine = 18;
                    _45 = (ushort) ( (_45 + 1) ) ; 
                    } 
                while (false == ( Functions.TestForTrue  ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _45 >= _43._7 ) ) || Functions.TestForTrue ( _44 )) )) )); 
                } 
            
            __context__.SourceCodeLine = 18;
            return (ushort)( 0) ; 
            
            }
            
        private ushort _38 (  SplusExecutionContext __context__, CrestronString _40 , short _41 , CrestronString _5 , ref _0 _42 ) 
            { 
            
            __context__.SourceCodeLine = 18;
            return (ushort)( _37( __context__ , _40 , (ushort)( Functions.Length( _40 ) ) , (short)( _41 ) , _5 , (ushort)( Functions.Length( _5 ) ) , ref _42 )) ; 
            
            }
            
        private short _39 (  SplusExecutionContext __context__, CrestronString _41 , ushort _42 , short _43 , CrestronString _5 , ushort _44 , CrestronString _45 , ushort REPLEN , short REPCOUNT , CrestronString BUFFER , ref ushort BUFFERLEN ) 
            { 
            ushort _46 = 0;
            
            short _47 = 0;
            
            short _48 = 0;
            
            ushort _49 = 0;
            
            ushort _50 = 0;
            
            _0 _51;
            _51  = new _0( this, true );
            _51 .PopulateCustomAttributeList( false );
            
            
            __context__.SourceCodeLine = 19;
            _47 = (short) ( 0 ) ; 
            __context__.SourceCodeLine = 19;
            _48 = (short) ( 0 ) ; 
            __context__.SourceCodeLine = 19;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( REPCOUNT <= 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 19;
                REPCOUNT = (short) ( (_42 + 1) ) ; 
                }
            
            __context__.SourceCodeLine = 19;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _43 < 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 19;
                _43 = (short) ( ((_42 + _43) + 1) ) ; 
                }
            
            __context__.SourceCodeLine = 19;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _43 < 1 ))  ) ) 
                {
                __context__.SourceCodeLine = 19;
                _43 = (short) ( 1 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 19;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _43 > (_42 + 1) ))  ) ) 
                    {
                    __context__.SourceCodeLine = 19;
                    _43 = (short) ( (_42 + 1) ) ; 
                    }
                
                }
            
            __context__.SourceCodeLine = 19;
            BUFFER  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 19;
            _49 = (ushort) ( _43 ) ; 
            __context__.SourceCodeLine = 19;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _49 > 1 ))  ) ) 
                {
                __context__.SourceCodeLine = 19;
                _48 = (short) ( _35( __context__ , BUFFER , (ushort)( BUFFERLEN ) , (ushort)( _48 ) , _41 , (ushort)( 1 ) , (ushort)( (_49 - 1) ) ) ) ; 
                }
            
            __context__.SourceCodeLine = 19;
            _46 = (ushort) ( _21( __context__ , ref _51 , (ushort)( _42 ) , _5 , (ushort)( _44 ) ) ) ; 
            __context__.SourceCodeLine = 19;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _47 < REPCOUNT ))  ) ) 
                { 
                __context__.SourceCodeLine = 19;
                _51 . _9 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 19;
                _51 . _2 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 20;
                _50 = (ushort) ( _32( __context__ , ref _51 , _41 , (ushort)( _49 ) , (ushort)( 1 ) ) ) ; 
                __context__.SourceCodeLine = 20;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( _51._1 ) != 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 20;
                    _48 = (short) ( Functions.Length( _51._1 ) ) ; 
                    __context__.SourceCodeLine = 20;
                    BUFFER  .UpdateValue ( _51 . _1  ) ; 
                    __context__.SourceCodeLine = 20;
                    _47 = (short) ( Functions.ToSignedInteger( -( 1 ) ) ) ; 
                    __context__.SourceCodeLine = 20;
                    break ; 
                    } 
                
                __context__.SourceCodeLine = 20;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_50 != 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 20;
                    _47 = (short) ( (_47 + 1) ) ; 
                    __context__.SourceCodeLine = 20;
                    _48 = (short) ( _36( __context__ , ref _51 , BUFFER , (ushort)( BUFFERLEN ) , (ushort)( _48 ) , _41 , (ushort)( _49 ) , (ushort)( _50 ) , _45 , (ushort)( REPLEN ) ) ) ; 
                    __context__.SourceCodeLine = 20;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _48 < 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 20;
                        _47 = (short) ( Functions.ToSignedInteger( -( 1 ) ) ) ; 
                        __context__.SourceCodeLine = 20;
                        _48 = (short) ( Functions.ToSignedInteger( -( _48 ) ) ) ; 
                        __context__.SourceCodeLine = 20;
                        break ; 
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 20;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _50 > _49 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 20;
                    _49 = (ushort) ( _50 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 20;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _49 < _51._7 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 20;
                        _48 = (short) ( _35( __context__ , BUFFER , (ushort)( BUFFERLEN ) , (ushort)( _48 ) , _41 , (ushort)( _49 ) , (ushort)( 1 ) ) ) ; 
                        __context__.SourceCodeLine = 20;
                        _49 = (ushort) ( (_49 + 1) ) ; 
                        __context__.SourceCodeLine = 20;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _48 < 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 20;
                            _47 = (short) ( Functions.ToSignedInteger( -( 1 ) ) ) ; 
                            __context__.SourceCodeLine = 20;
                            _48 = (short) ( Functions.ToSignedInteger( -( _48 ) ) ) ; 
                            __context__.SourceCodeLine = 20;
                            break ; 
                            } 
                        
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 20;
                        break ; 
                        }
                    
                    }
                
                __context__.SourceCodeLine = 20;
                if ( Functions.TestForTrue  ( ( _46)  ) ) 
                    {
                    __context__.SourceCodeLine = 20;
                    break ; 
                    }
                
                __context__.SourceCodeLine = 19;
                } 
            
            __context__.SourceCodeLine = 20;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _47 >= 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 20;
                _48 = (short) ( _35( __context__ , BUFFER , (ushort)( BUFFERLEN ) , (ushort)( _48 ) , _41 , (ushort)( _49 ) , (ushort)( (_51._7 - _49) ) ) ) ; 
                __context__.SourceCodeLine = 20;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _48 < 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 20;
                    _47 = (short) ( Functions.ToSignedInteger( -( 1 ) ) ) ; 
                    __context__.SourceCodeLine = 20;
                    _48 = (short) ( Functions.ToSignedInteger( -( _48 ) ) ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 20;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _48 < BUFFERLEN ))  ) ) 
                        { 
                        } 
                    
                    }
                
                } 
            
            __context__.SourceCodeLine = 20;
            BUFFERLEN = (ushort) ( _48 ) ; 
            __context__.SourceCodeLine = 20;
            return (short)( _47) ; 
            
            }
            
        private short _40 (  SplusExecutionContext __context__, CrestronString _42 , short _43 , CrestronString _5 , CrestronString _44 , short _45 , CrestronString BUFFER , ref ushort BUFFERLEN ) 
            { 
            
            __context__.SourceCodeLine = 21;
            return (short)( _39( __context__ , _42 , (ushort)( Functions.Length( _42 ) ) , (short)( _43 ) , _5 , (ushort)( Functions.Length( _5 ) ) , _44 , (ushort)( Functions.Length( _44 ) ) , (short)( _45 ) , BUFFER , ref BUFFERLEN )) ; 
            
            }
            
        private ushort _45 (  SplusExecutionContext __context__, ref _41 _47 ) 
            { 
            ushort _48 = 0;
            
            
            __context__.SourceCodeLine = 21;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ((_47._43 + 1) - _47._42) < _47._44 ))  ) ) 
                { 
                __context__.SourceCodeLine = 21;
                _47 . _43 = (ushort) ( (_47._43 + 1) ) ; 
                __context__.SourceCodeLine = 21;
                _48 = (ushort) ( Mod( _47._43 , _47._44 ) ) ; 
                __context__.SourceCodeLine = 21;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _47._42 > _47._44 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _47._43 > _47._44 ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 21;
                    _47 . _42 = (ushort) ( (_47._42 - _47._44) ) ; 
                    __context__.SourceCodeLine = 21;
                    _47 . _43 = (ushort) ( (_47._43 - _47._44) ) ; 
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 21;
                _48 = (ushort) ( _47._44 ) ; 
                } 
            
            __context__.SourceCodeLine = 21;
            return (ushort)( _48) ; 
            
            }
            
        private ushort _46 (  SplusExecutionContext __context__, _41 _48 ) 
            { 
            ushort _49 = 0;
            
            
            __context__.SourceCodeLine = 22;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ((_48._43 + 1) - _48._42) < _48._44 ))  ) ) 
                { 
                __context__.SourceCodeLine = 22;
                _49 = (ushort) ( Mod( _48._42 , _48._44 ) ) ; 
                __context__.SourceCodeLine = 22;
                _48 . _42 = (ushort) ( (_48._42 + 1) ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 22;
                Print( "Queue - Queue:Error") ; 
                __context__.SourceCodeLine = 22;
                _49 = (ushort) ( _48._44 ) ; 
                } 
            
            __context__.SourceCodeLine = 22;
            return (ushort)( _49) ; 
            
            }
            
        private void _47 (  SplusExecutionContext __context__, ref _41 _49 , ushort _50 ) 
            { 
            
            __context__.SourceCodeLine = 22;
            _49 . _42 = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 22;
            _49 . _43 = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 22;
            _49 . _44 = (ushort) ( _50 ) ; 
            
            }
            
        private void _48 (  SplusExecutionContext __context__, ref _41 _50 ) 
            { 
            
            __context__.SourceCodeLine = 22;
            _50 . _42 = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 22;
            _50 . _43 = (ushort) ( 0 ) ; 
            
            }
            
        private ushort _49 (  SplusExecutionContext __context__, ref _41 _51 ) 
            { 
            
            __context__.SourceCodeLine = 22;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _51._42 > _51._43 ))  ) ) 
                { 
                __context__.SourceCodeLine = 22;
                _48 (  __context__ ,   ref  _51 ) ; 
                __context__.SourceCodeLine = 22;
                return (ushort)( 1) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 22;
                return (ushort)( 0) ; 
                } 
            
            
            return 0; // default return value (none specified in module)
            }
            
        private ushort _50 (  SplusExecutionContext __context__, ref _41 _52 ) 
            { 
            
            __context__.SourceCodeLine = 22;
            return (ushort)( _52._42) ; 
            
            }
            
        private ushort _51 (  SplusExecutionContext __context__, ref _41 _53 ) 
            { 
            
            __context__.SourceCodeLine = 22;
            return (ushort)( _53._43) ; 
            
            }
            
        private ushort _52 (  SplusExecutionContext __context__, ref _41 _54 ) 
            { 
            
            __context__.SourceCodeLine = 23;
            return (ushort)( _54._42) ; 
            
            }
            
        private ushort _53 (  SplusExecutionContext __context__, ref _41 _55 ) 
            { 
            
            __context__.SourceCodeLine = 23;
            return (ushort)( _55._43) ; 
            
            }
            
        private void _54 (  SplusExecutionContext __context__, ushort [] _56 , ushort [] _57 , ushort [] _58 ) 
            { 
            
            __context__.SourceCodeLine = 23;
            _56 [ 0] = (ushort) ( 254 ) ; 
            __context__.SourceCodeLine = 23;
            _56 [ 1] = (ushort) ( 126 ) ; 
            __context__.SourceCodeLine = 23;
            _56 [ 2] = (ushort) ( 62 ) ; 
            __context__.SourceCodeLine = 23;
            _56 [ 3] = (ushort) ( 30 ) ; 
            __context__.SourceCodeLine = 23;
            _56 [ 4] = (ushort) ( 14 ) ; 
            __context__.SourceCodeLine = 23;
            _56 [ 5] = (ushort) ( 6 ) ; 
            __context__.SourceCodeLine = 23;
            _56 [ 6] = (ushort) ( 2 ) ; 
            __context__.SourceCodeLine = 23;
            _57 [ 0] = (ushort) ( 128 ) ; 
            __context__.SourceCodeLine = 23;
            _57 [ 1] = (ushort) ( 192 ) ; 
            __context__.SourceCodeLine = 23;
            _57 [ 2] = (ushort) ( 224 ) ; 
            __context__.SourceCodeLine = 23;
            _57 [ 3] = (ushort) ( 240 ) ; 
            __context__.SourceCodeLine = 23;
            _57 [ 4] = (ushort) ( 248 ) ; 
            __context__.SourceCodeLine = 23;
            _57 [ 5] = (ushort) ( 252 ) ; 
            __context__.SourceCodeLine = 23;
            _57 [ 6] = (ushort) ( 254 ) ; 
            __context__.SourceCodeLine = 23;
            _58 [ 0] = (ushort) ( 9 ) ; 
            __context__.SourceCodeLine = 23;
            _58 [ 1] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 23;
            _58 [ 2] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 23;
            _58 [ 3] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 23;
            _58 [ 4] = (ushort) ( 44 ) ; 
            __context__.SourceCodeLine = 23;
            _58 [ 5] = (ushort) ( 3 ) ; 
            __context__.SourceCodeLine = 23;
            _58 [ 6] = (ushort) ( 55 ) ; 
            __context__.SourceCodeLine = 23;
            _58 [ 7] = (ushort) ( 18 ) ; 
            __context__.SourceCodeLine = 23;
            _58 [ 8] = (ushort) ( 58 ) ; 
            __context__.SourceCodeLine = 23;
            _58 [ 9] = (ushort) ( 33 ) ; 
            __context__.SourceCodeLine = 23;
            _58 [ 10] = (ushort) ( 43 ) ; 
            __context__.SourceCodeLine = 23;
            _58 [ 11] = (ushort) ( 24 ) ; 
            __context__.SourceCodeLine = 23;
            _58 [ 12] = (ushort) ( 60 ) ; 
            __context__.SourceCodeLine = 23;
            _58 [ 13] = (ushort) ( 51 ) ; 
            __context__.SourceCodeLine = 24;
            _58 [ 14] = (ushort) ( 7 ) ; 
            __context__.SourceCodeLine = 24;
            _58 [ 15] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 24;
            _58 [ 16] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 24;
            _58 [ 17] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 24;
            _58 [ 18] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 24;
            _58 [ 19] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 24;
            _58 [ 20] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 24;
            _58 [ 21] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 24;
            _58 [ 22] = (ushort) ( 61 ) ; 
            __context__.SourceCodeLine = 24;
            _58 [ 23] = (ushort) ( 48 ) ; 
            __context__.SourceCodeLine = 24;
            _58 [ 24] = (ushort) ( 56 ) ; 
            __context__.SourceCodeLine = 24;
            _58 [ 25] = (ushort) ( 46 ) ; 
            __context__.SourceCodeLine = 24;
            _58 [ 26] = (ushort) ( 52 ) ; 
            __context__.SourceCodeLine = 24;
            _58 [ 27] = (ushort) ( 38 ) ; 
            __context__.SourceCodeLine = 24;
            _58 [ 28] = (ushort) ( 39 ) ; 
            __context__.SourceCodeLine = 24;
            _58 [ 29] = (ushort) ( 36 ) ; 
            __context__.SourceCodeLine = 24;
            _58 [ 30] = (ushort) ( 31 ) ; 
            __context__.SourceCodeLine = 24;
            _58 [ 31] = (ushort) ( 59 ) ; 
            __context__.SourceCodeLine = 24;
            _58 [ 32] = (ushort) ( 30 ) ; 
            __context__.SourceCodeLine = 24;
            _58 [ 33] = (ushort) ( 20 ) ; 
            __context__.SourceCodeLine = 24;
            _58 [ 34] = (ushort) ( 45 ) ; 
            __context__.SourceCodeLine = 24;
            _58 [ 35] = (ushort) ( 37 ) ; 
            __context__.SourceCodeLine = 24;
            _58 [ 36] = (ushort) ( 62 ) ; 
            __context__.SourceCodeLine = 24;
            _58 [ 37] = (ushort) ( 14 ) ; 
            __context__.SourceCodeLine = 24;
            _58 [ 38] = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 24;
            _58 [ 39] = (ushort) ( 15 ) ; 
            __context__.SourceCodeLine = 24;
            _58 [ 40] = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 24;
            _58 [ 41] = (ushort) ( 23 ) ; 
            __context__.SourceCodeLine = 24;
            _58 [ 42] = (ushort) ( 5 ) ; 
            __context__.SourceCodeLine = 24;
            _58 [ 43] = (ushort) ( 50 ) ; 
            __context__.SourceCodeLine = 24;
            _58 [ 44] = (ushort) ( 13 ) ; 
            __context__.SourceCodeLine = 24;
            _58 [ 45] = (ushort) ( 19 ) ; 
            __context__.SourceCodeLine = 24;
            _58 [ 46] = (ushort) ( 10 ) ; 
            __context__.SourceCodeLine = 24;
            _58 [ 47] = (ushort) ( 27 ) ; 
            __context__.SourceCodeLine = 24;
            _58 [ 48] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 24;
            _58 [ 49] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 24;
            _58 [ 50] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 24;
            _58 [ 51] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 24;
            _58 [ 52] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 25;
            _58 [ 53] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 25;
            _58 [ 54] = (ushort) ( 28 ) ; 
            __context__.SourceCodeLine = 25;
            _58 [ 55] = (ushort) ( 49 ) ; 
            __context__.SourceCodeLine = 25;
            _58 [ 56] = (ushort) ( 63 ) ; 
            __context__.SourceCodeLine = 25;
            _58 [ 57] = (ushort) ( 57 ) ; 
            __context__.SourceCodeLine = 25;
            _58 [ 58] = (ushort) ( 22 ) ; 
            __context__.SourceCodeLine = 25;
            _58 [ 59] = (ushort) ( 40 ) ; 
            __context__.SourceCodeLine = 25;
            _58 [ 60] = (ushort) ( 41 ) ; 
            __context__.SourceCodeLine = 25;
            _58 [ 61] = (ushort) ( 12 ) ; 
            __context__.SourceCodeLine = 25;
            _58 [ 62] = (ushort) ( 47 ) ; 
            __context__.SourceCodeLine = 25;
            _58 [ 63] = (ushort) ( 34 ) ; 
            __context__.SourceCodeLine = 25;
            _58 [ 64] = (ushort) ( 2 ) ; 
            __context__.SourceCodeLine = 25;
            _58 [ 65] = (ushort) ( 16 ) ; 
            __context__.SourceCodeLine = 25;
            _58 [ 66] = (ushort) ( 6 ) ; 
            __context__.SourceCodeLine = 25;
            _58 [ 67] = (ushort) ( 11 ) ; 
            __context__.SourceCodeLine = 25;
            _58 [ 68] = (ushort) ( 32 ) ; 
            __context__.SourceCodeLine = 25;
            _58 [ 69] = (ushort) ( 21 ) ; 
            __context__.SourceCodeLine = 25;
            _58 [ 70] = (ushort) ( 8 ) ; 
            __context__.SourceCodeLine = 25;
            _58 [ 71] = (ushort) ( 4 ) ; 
            __context__.SourceCodeLine = 25;
            _58 [ 72] = (ushort) ( 26 ) ; 
            __context__.SourceCodeLine = 25;
            _58 [ 73] = (ushort) ( 29 ) ; 
            __context__.SourceCodeLine = 25;
            _58 [ 74] = (ushort) ( 17 ) ; 
            __context__.SourceCodeLine = 25;
            _58 [ 75] = (ushort) ( 42 ) ; 
            __context__.SourceCodeLine = 25;
            _58 [ 76] = (ushort) ( 53 ) ; 
            __context__.SourceCodeLine = 25;
            _58 [ 77] = (ushort) ( 54 ) ; 
            __context__.SourceCodeLine = 25;
            _58 [ 78] = (ushort) ( 35 ) ; 
            __context__.SourceCodeLine = 25;
            _58 [ 79] = (ushort) ( 25 ) ; 
            
            }
            
        private void _55 (  SplusExecutionContext __context__, CrestronString _57 , ushort [] _58 , ushort _59 ) 
            { 
            CrestronString _60;
            _60  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 512, this );
            
            ushort _61 = 0;
            ushort _62 = 0;
            
            
            __context__.SourceCodeLine = 25;
            _62 = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 25;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)_59; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( _61  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_61  >= __FN_FORSTART_VAL__1) && (_61  <= __FN_FOREND_VAL__1) ) : ( (_61  <= __FN_FORSTART_VAL__1) && (_61  >= __FN_FOREND_VAL__1) ) ; _61  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 25;
                _60  .UpdateValue ( _60 + Functions.ItoHex (  (int) ( _58[ (_61 - 1) ] ) ) + " "  ) ; 
                __context__.SourceCodeLine = 26;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Mod( _61 , 16 ) == 0) ) || Functions.TestForTrue ( Functions.BoolToInt (_61 == _59) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 26;
                    _60  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 26;
                    _62 = (ushort) ( (_62 + 1) ) ; 
                    } 
                
                __context__.SourceCodeLine = 25;
                } 
            
            
            }
            
        private uint _56 (  SplusExecutionContext __context__, uint [] _58 , ref ushort _59 ) 
            { 
            uint _60 = 0;
            uint _61 = 0;
            uint _62 = 0;
            uint _63 = 0;
            
            
            __context__.SourceCodeLine = 26;
            _60 = (uint) ( _58[ _59 ] ) ; 
            __context__.SourceCodeLine = 26;
            _61 = (uint) ( _58[ ((_59 + 13) & 15) ] ) ; 
            __context__.SourceCodeLine = 26;
            _62 = (uint) ( (((_60 ^ _61) ^ (_60 << 16)) ^ (_61 << 15)) ) ; 
            __context__.SourceCodeLine = 26;
            _61 = (uint) ( _58[ ((_59 + 9) & 15) ] ) ; 
            __context__.SourceCodeLine = 26;
            _61 = (uint) ( (_61 ^ (_61 >> 11)) ) ; 
            __context__.SourceCodeLine = 26;
            _58 [ _59] = (uint) ( (_62 ^ _61) ) ; 
            __context__.SourceCodeLine = 26;
            _60 = (uint) ( _58[ _59 ] ) ; 
            __context__.SourceCodeLine = 26;
            _63 = (uint) ( (_60 ^ ((_60 << 5) & 3661901088)) ) ; 
            __context__.SourceCodeLine = 26;
            _59 = (ushort) ( ((_59 + 15) & 15) ) ; 
            __context__.SourceCodeLine = 26;
            _60 = (uint) ( _58[ _59 ] ) ; 
            __context__.SourceCodeLine = 26;
            _58 [ _59] = (uint) ( (((((_60 ^ _62) ^ _63) ^ (_60 << 2)) ^ (_62 << 18)) ^ (_61 << 28)) ) ; 
            __context__.SourceCodeLine = 26;
            return (uint)( _58[ _59 ]) ; 
            
            }
            
        private void _57 (  SplusExecutionContext __context__, uint _59 , ref uint [] _60 , ref ushort _61 ) 
            { 
            ushort _62 = 0;
            
            uint _63 = 0;
            
            
            __context__.SourceCodeLine = 27;
            _63 = (uint) ( 0 ) ; 
            __context__.SourceCodeLine = 27;
            _61 = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 27;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 0 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)15; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( _62  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_62  >= __FN_FORSTART_VAL__1) && (_62  <= __FN_FOREND_VAL__1) ) : ( (_62  <= __FN_FORSTART_VAL__1) && (_62  >= __FN_FOREND_VAL__1) ) ; _62  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 27;
                _60 [ _62] = (uint) ( ((_59 + _63) ^ (1431655765 >> _62)) ) ; 
                __context__.SourceCodeLine = 27;
                _63 = (uint) ( (_63 + 7623293) ) ; 
                __context__.SourceCodeLine = 27;
                } 
            
            
            }
            
        private ushort _58 (  SplusExecutionContext __context__, CrestronString _60 , ushort _61 , ref ushort [] _62 , ref CrestronString [] _63 ) 
            { 
            ushort _64 = 0;
            
            ushort _65 = 0;
            
            ushort [] _66;
            _66  = new ushort[ 257 ];
            
            uint [] _67;
            _67  = new uint[ 257 ];
            
            uint _68 = 0;
            
            ushort _69 = 0;
            
            ushort [] _70;
            _70  = new ushort[ 4 ];
            
            short _71 = 0;
            short _72 = 0;
            
            ushort _73 = 0;
            ushort _74 = 0;
            
            ushort _75 = 0;
            
            uint _76 = 0;
            
            ushort _77 = 0;
            
            ushort _78 = 0;
            
            ushort [] _79;
            _79  = new ushort[ 7 ];
            
            ushort [] _80;
            _80  = new ushort[ 7 ];
            
            ushort [] _81;
            _81  = new ushort[ 80 ];
            
            uint [] _82;
            _82  = new uint[ 17 ];
            
            ushort _83 = 0;
            
            uint _84 = 0;
            
            
            __context__.SourceCodeLine = 27;
            _54 (  __context__ , (ushort[])( _79 ), (ushort[])( _80 ), (ushort[])( _81 )) ; 
            __context__.SourceCodeLine = 27;
            _65 = (ushort) ( Functions.Length( _60 ) ) ; 
            __context__.SourceCodeLine = 28;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _65 < 44 ) ) || Functions.TestForTrue ( Functions.BoolToInt (Mod( _65 , 4 ) != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( ((_65 * 3) / 4) > 256 ) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 28;
                _64 = (ushort) ( 0 ) ; 
                }
            
            else 
                { 
                __context__.SourceCodeLine = 28;
                _68 = (uint) ( 0 ) ; 
                __context__.SourceCodeLine = 28;
                _69 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 28;
                short __FN_FORSTART_VAL__1 = (short) ( 0 ) ;
                short __FN_FOREND_VAL__1 = (short)(_65 - 1); 
                int __FN_FORSTEP_VAL__1 = (int)4; 
                for ( _71  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_71  >= __FN_FORSTART_VAL__1) && (_71  <= __FN_FOREND_VAL__1) ) : ( (_71  <= __FN_FORSTART_VAL__1) && (_71  >= __FN_FOREND_VAL__1) ) ; _71  += (short)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 28;
                    short __FN_FORSTART_VAL__2 = (short) ( 0 ) ;
                    short __FN_FOREND_VAL__2 = (short)3; 
                    int __FN_FORSTEP_VAL__2 = (int)1; 
                    for ( _72  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (_72  >= __FN_FORSTART_VAL__2) && (_72  <= __FN_FOREND_VAL__2) ) : ( (_72  <= __FN_FORSTART_VAL__2) && (_72  >= __FN_FOREND_VAL__2) ) ; _72  += (short)__FN_FORSTEP_VAL__2) 
                        { 
                        __context__.SourceCodeLine = 28;
                        _75 = (ushort) ( Byte( _60 , (int)( ((_71 + _72) + 1) ) ) ) ; 
                        __context__.SourceCodeLine = 28;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _75 >= 43 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _75 <= 122 ) )) ))  ) ) 
                            {
                            __context__.SourceCodeLine = 28;
                            _70 [ _72] = (ushort) ( _81[ (_75 - 43) ] ) ; 
                            }
                        
                        else 
                            {
                            __context__.SourceCodeLine = 28;
                            _70 [ _72] = (ushort) ( 255 ) ; 
                            }
                        
                        __context__.SourceCodeLine = 28;
                        } 
                    
                    __context__.SourceCodeLine = 28;
                    _66 [ _69] = (ushort) ( (((_70[ 0 ] << 2) | (_70[ 1 ] >> 4)) & 255) ) ; 
                    __context__.SourceCodeLine = 28;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_70[ 2 ] != 255))  ) ) 
                        { 
                        __context__.SourceCodeLine = 28;
                        _69 = (ushort) ( (_69 + 1) ) ; 
                        __context__.SourceCodeLine = 28;
                        _66 [ _69] = (ushort) ( (((_70[ 1 ] << 4) | (_70[ 2 ] >> 2)) & 255) ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 28;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_70[ 3 ] != 255))  ) ) 
                        { 
                        __context__.SourceCodeLine = 28;
                        _69 = (ushort) ( (_69 + 1) ) ; 
                        __context__.SourceCodeLine = 28;
                        _66 [ _69] = (ushort) ( ((((_70[ 2 ] << 6) & 192) | _70[ 3 ]) & 255) ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 28;
                    _69 = (ushort) ( (_69 + 1) ) ; 
                    __context__.SourceCodeLine = 28;
                    } 
                
                __context__.SourceCodeLine = 28;
                short __FN_FORSTART_VAL__3 = (short) ( 0 ) ;
                short __FN_FOREND_VAL__3 = (short)27; 
                int __FN_FORSTEP_VAL__3 = (int)1; 
                for ( _71  = __FN_FORSTART_VAL__3; (__FN_FORSTEP_VAL__3 > 0)  ? ( (_71  >= __FN_FORSTART_VAL__3) && (_71  <= __FN_FOREND_VAL__3) ) : ( (_71  <= __FN_FORSTART_VAL__3) && (_71  >= __FN_FOREND_VAL__3) ) ; _71  += (short)__FN_FORSTEP_VAL__3) 
                    { 
                    __context__.SourceCodeLine = 28;
                    _73 = (ushort) ( Mod( _71 , 7 ) ) ; 
                    __context__.SourceCodeLine = 28;
                    _74 = (ushort) ( (_71 / 7) ) ; 
                    __context__.SourceCodeLine = 28;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ((_66[ _71 ] & 1) != 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 28;
                        _68 = (uint) ( (_68 | (1 << _71)) ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 28;
                    _66 [ _71] = (ushort) ( ((((_66[ (_71 + _74) ] & _79[ _73 ]) << _73) | ((_66[ ((_71 + _74) + 1) ] & _80[ _73 ]) >> (7 - _73))) & 255) ) ; 
                    __context__.SourceCodeLine = 28;
                    } 
                
                __context__.SourceCodeLine = 29;
                short __FN_FORSTART_VAL__4 = (short) ( 28 ) ;
                short __FN_FOREND_VAL__4 = (short)31; 
                int __FN_FORSTEP_VAL__4 = (int)1; 
                for ( _71  = __FN_FORSTART_VAL__4; (__FN_FORSTEP_VAL__4 > 0)  ? ( (_71  >= __FN_FORSTART_VAL__4) && (_71  <= __FN_FOREND_VAL__4) ) : ( (_71  <= __FN_FORSTART_VAL__4) && (_71  >= __FN_FOREND_VAL__4) ) ; _71  += (short)__FN_FORSTEP_VAL__4) 
                    { 
                    __context__.SourceCodeLine = 29;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ((_66[ _71 ] & 1) != 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 29;
                        _68 = (uint) ( (_68 ^ (1 << _71)) ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 29;
                    } 
                
                __context__.SourceCodeLine = 29;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _69 > 32 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 29;
                    short __FN_FORSTART_VAL__5 = (short) ( 32 ) ;
                    short __FN_FOREND_VAL__5 = (short)(_69 - 1); 
                    int __FN_FORSTEP_VAL__5 = (int)1; 
                    for ( _71  = __FN_FORSTART_VAL__5; (__FN_FORSTEP_VAL__5 > 0)  ? ( (_71  >= __FN_FORSTART_VAL__5) && (_71  <= __FN_FOREND_VAL__5) ) : ( (_71  <= __FN_FORSTART_VAL__5) && (_71  >= __FN_FOREND_VAL__5) ) ; _71  += (short)__FN_FORSTEP_VAL__5) 
                        { 
                        __context__.SourceCodeLine = 29;
                        _66 [ (_71 - 4)] = (ushort) ( _66[ _71 ] ) ; 
                        __context__.SourceCodeLine = 29;
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 29;
                _69 = (ushort) ( (_69 - 4) ) ; 
                __context__.SourceCodeLine = 29;
                _57 (  __context__ , (uint)( _68 ),   ref  _82 ,   ref  _83 ) ; 
                __context__.SourceCodeLine = 29;
                short __FN_FORSTART_VAL__6 = (short) ( 0 ) ;
                short __FN_FOREND_VAL__6 = (short)(_69 - 1); 
                int __FN_FORSTEP_VAL__6 = (int)1; 
                for ( _71  = __FN_FORSTART_VAL__6; (__FN_FORSTEP_VAL__6 > 0)  ? ( (_71  >= __FN_FORSTART_VAL__6) && (_71  <= __FN_FOREND_VAL__6) ) : ( (_71  <= __FN_FORSTART_VAL__6) && (_71  >= __FN_FOREND_VAL__6) ) ; _71  += (short)__FN_FORSTEP_VAL__6) 
                    { 
                    __context__.SourceCodeLine = 29;
                    _84 = (uint) ( (_69 - _71) ) ; 
                    __context__.SourceCodeLine = 29;
                    _67 [ _71] = (uint) ( (_56( __context__ , (uint[])( _82 ) , ref _83 ) >> 1) ) ; 
                    __context__.SourceCodeLine = 29;
                    _67 [ _71] = (uint) ( (Mod( _67[ _71 ] , _84 ) + _71) ) ; 
                    __context__.SourceCodeLine = 29;
                    _84 = (uint) ( _56( __context__ , (uint[])( _82 ) , ref _83 ) ) ; 
                    __context__.SourceCodeLine = 29;
                    _66 [ _71] = (ushort) ( (_66[ _71 ] ^ (_84 & 255)) ) ; 
                    __context__.SourceCodeLine = 29;
                    } 
                
                __context__.SourceCodeLine = 29;
                short __FN_FORSTART_VAL__7 = (short) ( (_69 - 1) ) ;
                short __FN_FOREND_VAL__7 = (short)0; 
                int __FN_FORSTEP_VAL__7 = (int)Functions.ToLongInteger( -( 1 ) ); 
                for ( _71  = __FN_FORSTART_VAL__7; (__FN_FORSTEP_VAL__7 > 0)  ? ( (_71  >= __FN_FORSTART_VAL__7) && (_71  <= __FN_FOREND_VAL__7) ) : ( (_71  <= __FN_FORSTART_VAL__7) && (_71  >= __FN_FOREND_VAL__7) ) ; _71  += (short)__FN_FORSTEP_VAL__7) 
                    { 
                    __context__.SourceCodeLine = 29;
                    _76 = (uint) ( _67[ _71 ] ) ; 
                    __context__.SourceCodeLine = 29;
                    _77 = (ushort) ( _66[ _76 ] ) ; 
                    __context__.SourceCodeLine = 29;
                    _66 [ _76] = (ushort) ( _66[ _71 ] ) ; 
                    __context__.SourceCodeLine = 29;
                    _66 [ _71] = (ushort) ( _77 ) ; 
                    __context__.SourceCodeLine = 29;
                    } 
                
                __context__.SourceCodeLine = 29;
                _71 = (short) ( 0 ) ; 
                __context__.SourceCodeLine = 29;
                _64 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 29;
                while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _71 < _69 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _64 < _61 ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 29;
                    _78 = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 29;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (_71 + 3) <= _69 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 29;
                        _62 [ _64] = (ushort) ( ((_66[ _71 ] << 8) | _66[ (_71 + 1) ]) ) ; 
                        __context__.SourceCodeLine = 29;
                        _78 = (ushort) ( _66[ (_71 + 2) ] ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 30;
                    _71 = (short) ( (_71 + 3) ) ; 
                    __context__.SourceCodeLine = 30;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (_71 + _78) > _69 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 30;
                        _64 = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 30;
                        break ; 
                        } 
                    
                    __context__.SourceCodeLine = 30;
                    _63 [ _64]  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 30;
                    short __FN_FORSTART_VAL__8 = (short) ( 0 ) ;
                    short __FN_FOREND_VAL__8 = (short)(_78 - 1); 
                    int __FN_FORSTEP_VAL__8 = (int)1; 
                    for ( _72  = __FN_FORSTART_VAL__8; (__FN_FORSTEP_VAL__8 > 0)  ? ( (_72  >= __FN_FORSTART_VAL__8) && (_72  <= __FN_FOREND_VAL__8) ) : ( (_72  <= __FN_FORSTART_VAL__8) && (_72  >= __FN_FOREND_VAL__8) ) ; _72  += (short)__FN_FORSTEP_VAL__8) 
                        { 
                        __context__.SourceCodeLine = 30;
                        _63 [ _64]  .UpdateValue ( _63 [ _64] + Functions.Chr (  (int) ( _66[ (_71 + _72) ] ) )  ) ; 
                        __context__.SourceCodeLine = 30;
                        } 
                    
                    __context__.SourceCodeLine = 30;
                    _64 = (ushort) ( (_64 + 1) ) ; 
                    __context__.SourceCodeLine = 30;
                    _71 = (short) ( (_71 + _78) ) ; 
                    __context__.SourceCodeLine = 29;
                    } 
                
                } 
            
            __context__.SourceCodeLine = 30;
            return (ushort)( _64) ; 
            
            }
            
        private CrestronString _59 (  SplusExecutionContext __context__, CrestronString _61 ) 
            { 
            CrestronString _62;
            CrestronString _63;
            _62  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
            _63  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
            
            ushort _64 = 0;
            ushort _65 = 0;
            
            
            __context__.SourceCodeLine = 30;
            _63  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 30;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( _61 ); 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( _64  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_64  >= __FN_FORSTART_VAL__1) && (_64  <= __FN_FOREND_VAL__1) ) : ( (_64  <= __FN_FORSTART_VAL__1) && (_64  >= __FN_FOREND_VAL__1) ) ; _64  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 30;
                _64 = (ushort) ( Functions.Find( ":" , _61 ) ) ; 
                __context__.SourceCodeLine = 30;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _64 > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 30;
                    _62  .UpdateValue ( Functions.Remove ( ":" , _61 )  ) ; 
                    __context__.SourceCodeLine = 30;
                    _62  .UpdateValue ( Functions.Left ( _62 ,  (int) ( (Functions.Length( _62 ) - 1) ) )  ) ; 
                    __context__.SourceCodeLine = 30;
                    _63  .UpdateValue ( _63 + _62  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 30;
                    _63  .UpdateValue ( _63 + _61  ) ; 
                    __context__.SourceCodeLine = 30;
                    break ; 
                    } 
                
                __context__.SourceCodeLine = 30;
                } 
            
            __context__.SourceCodeLine = 30;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( _63 , (int)( 1 ) ) == " "))  ) ) 
                {
                __context__.SourceCodeLine = 30;
                _63  .UpdateValue ( Functions.Right ( _63 ,  (int) ( (Functions.Length( _63 ) - 1) ) )  ) ; 
                __context__.SourceCodeLine = 30;
                }
            
            __context__.SourceCodeLine = 30;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Right( _63 , (int)( 1 ) ) == " "))  ) ) 
                {
                __context__.SourceCodeLine = 30;
                _63  .UpdateValue ( Functions.Left ( _63 ,  (int) ( (Functions.Length( _63 ) - 1) ) )  ) ; 
                __context__.SourceCodeLine = 30;
                }
            
            __context__.SourceCodeLine = 30;
            return ( Functions.Lower ( _63 ) ) ; 
            
            }
            
        private ushort _60 (  SplusExecutionContext __context__, CrestronString _62 , CrestronString _63 , CrestronString _64 , ushort _65 ) 
            { 
            ushort _66 = 0;
            ushort _67 = 0;
            ushort _68 = 0;
            
            CrestronString _69;
            CrestronString _70;
            _69  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
            _70  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
            
            ushort [] _71;
            _71  = new ushort[ 17 ];
            
            CrestronString [] _72;
            _72  = new CrestronString[ 17 ];
            for( uint i = 0; i < 17; i++ )
                _72 [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
            
            CrestronString _73;
            _73  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
            
            CrestronString _74;
            _74  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            
            ushort _75 = 0;
            
            
            __context__.SourceCodeLine = 31;
            _75 = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 31;
            _66 = (ushort) ( 16 ) ; 
            __context__.SourceCodeLine = 31;
            while ( Functions.TestForTrue  ( ( Functions.Find( "License Activation is :" , _64 ))  ) ) 
                { 
                __context__.SourceCodeLine = 31;
                _73  .UpdateValue ( Functions.Remove ( "License Activation is :" , _64 )  ) ; 
                __context__.SourceCodeLine = 31;
                } 
            
            __context__.SourceCodeLine = 31;
            _64  .UpdateValue ( Functions.Remove ( "\u000D" , _64 )  ) ; 
            __context__.SourceCodeLine = 31;
            _74  .UpdateValue ( Functions.Left ( _64 ,  (int) ( (Functions.Length( _64 ) - 1) ) )  ) ; 
            __context__.SourceCodeLine = 31;
            _67 = (ushort) ( _58( __context__ , _62 , (ushort)( _66 ) , ref _71 , ref _72 ) ) ; 
            __context__.SourceCodeLine = 31;
            Print( "JanusLicenceDecoder_checkLicense   result  {0:d}\r\n", (short)_67) ; 
            __context__.SourceCodeLine = 31;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)_67; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( _68  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_68  >= __FN_FORSTART_VAL__1) && (_68  <= __FN_FOREND_VAL__1) ) : ( (_68  <= __FN_FORSTART_VAL__1) && (_68  >= __FN_FOREND_VAL__1) ) ; _68  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 31;
                Print( "key[{0:d}]  {1}\r\n", (short)_71[ _68 ], _72 [ _68 ] ) ; 
                __context__.SourceCodeLine = 31;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_71[ _68 ] == 6) ) || Functions.TestForTrue ( Functions.BoolToInt (_71[ _68 ] == 2) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 32;
                    _69  .UpdateValue ( _59 (  __context__ , _72[ _68 ])  ) ; 
                    __context__.SourceCodeLine = 32;
                    _70  .UpdateValue ( _59 (  __context__ , _74)  ) ; 
                    __context__.SourceCodeLine = 32;
                    Print( "licenceValueClean  {0}\r\n", _69 ) ; 
                    __context__.SourceCodeLine = 32;
                    Print( "switchValueClean  {0}\r\n", _70 ) ; 
                    __context__.SourceCodeLine = 32;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_70 == _69))  ) ) 
                        { 
                        __context__.SourceCodeLine = 32;
                        _75 = (ushort) ( 1 ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 32;
                        _75 = (ushort) ( 0 ) ; 
                        } 
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 32;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_71[ _68 ] == 4))  ) ) 
                        { 
                        __context__.SourceCodeLine = 32;
                        Print( "licenceType  {0}\r\n", _72 [ _68 ] ) ; 
                        __context__.SourceCodeLine = 32;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_63 == _72[ _68 ]))  ) ) 
                            { 
                            __context__.SourceCodeLine = 32;
                            _75 = (ushort) ( 1 ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 32;
                            _75 = (ushort) ( 0 ) ; 
                            } 
                        
                        } 
                    
                    }
                
                __context__.SourceCodeLine = 31;
                } 
            
            __context__.SourceCodeLine = 32;
            return (ushort)( _75) ; 
            
            }
            
        private ushort _61 (  SplusExecutionContext __context__, ushort _63 ) 
            { 
            ushort _64 = 0;
            ushort _65 = 0;
            
            
            __context__.SourceCodeLine = 32;
            _64 = (ushort) ( ((Functions.GetHSeconds() - _63) / 100) ) ; 
            __context__.SourceCodeLine = 32;
            _65 = (ushort) ( (1800 - _64) ) ; 
            __context__.SourceCodeLine = 32;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _65 < 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 32;
                _65 = (ushort) ( 0 ) ; 
                } 
            
            __context__.SourceCodeLine = 32;
            return (ushort)( _65) ; 
            
            }
            
        private CrestronString _62 (  SplusExecutionContext __context__, ushort _64 , ushort _65 ) 
            { 
            CrestronString _66;
            _66  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            
            
            __context__.SourceCodeLine = 32;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_64 == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 32;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_65 == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 32;
                    _66  .UpdateValue ( "Invalid licence / Demo Expired"  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 33;
                    MakeString ( _66 , "Demo mode ({0:d} seconds remaining)", (short)_65) ; 
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 33;
                _66  .UpdateValue ( "Licence OK"  ) ; 
                } 
            
            __context__.SourceCodeLine = 33;
            return ( _66 ) ; 
            
            }
            
        Crestron.Logos.SplusObjects.DigitalInput __TRIGGER_SEND_NEXT_CMD;
        Crestron.Logos.SplusObjects.DigitalInput __TRIGGER_HEARTBEAT;
        Crestron.Logos.SplusObjects.DigitalInput __TRIGGER_PROCESS_SOCKET_RECEIVE;
        Crestron.Logos.SplusObjects.DigitalInput REFRESH_STATUS;
        Crestron.Logos.SplusObjects.DigitalInput START_MODULE;
        Crestron.Logos.SplusObjects.DigitalInput SEND_SAVE;
        Crestron.Logos.SplusObjects.StringInput FAVOUTITE_CMD;
        Crestron.Logos.SplusObjects.StringInput POE_CMD;
        Crestron.Logos.SplusObjects.StringInput DEBUGENABLE;
        Crestron.Logos.SplusObjects.StringInput CRESTRON_MAC;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> OUTPUT;
        Crestron.Logos.SplusObjects.DigitalOutput __TRIGGER_SEND_NEXT_CMD_OUT;
        Crestron.Logos.SplusObjects.DigitalOutput __TRIGGER_START_HEARTBEAT_OUT;
        Crestron.Logos.SplusObjects.DigitalOutput __SOCKET_RECEIVE_BUSY;
        Crestron.Logos.SplusObjects.DigitalOutput REBOOTINGINPROGRESS;
        Crestron.Logos.SplusObjects.StringOutput OPERATIONFB__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CRESTRONID__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput VERSION__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput ERRORMSG__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogOutput NUMOFOUTPUTS;
        Crestron.Logos.SplusObjects.AnalogOutput NUMOFINPUTS;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> OUTPUTFB;
        SplusTcpClient SWITCH_CLIENT;
        StringParameter P_SWITCHIP;
        StringParameter P_SWITCHUSERNAME;
        StringParameter P_SWITCHPASSWORD;
        StringParameter P_SWITCHLICENCEKEY;
        _63 _71;
        _72 _77;
        _78 [] _85;
        _78 _86;
        _41 _87;
        ushort _88 = 0;
        ushort _89 = 0;
        ushort _90 = 0;
        ushort _91 = 0;
        ushort _92 = 0;
        CrestronString _93;
        ushort [] _94;
        CrestronString _95;
        ushort _96 = 0;
        CrestronString _97;
        ushort _98 = 0;
        CrestronString _99;
        CrestronString [] _100;
        CrestronString _101;
        ushort _102 = 0;
        ushort _103 = 0;
        ushort _104 = 0;
        ushort _105 = 0;
        CrestronString [] _106;
        CrestronString [] _107;
        ushort _108 = 0;
        ushort _109 = 0;
        ushort _110 = 0;
        ushort _111 = 0;
        ushort _112 = 0;
        ushort _113 = 0;
        ushort _114 = 0;
        private void _115 (  SplusExecutionContext __context__, CrestronString _117 , CrestronString _118 ) 
            { 
            
            __context__.SourceCodeLine = 36;
            if ( Functions.TestForTrue  ( ( _92)  ) ) 
                {
                __context__.SourceCodeLine = 36;
                Print( "\r\n {0}: {1} \r\n", _117 , _118 ) ; 
                }
            
            
            }
            
        private CrestronString _116 (  SplusExecutionContext __context__, CrestronString _118 , ushort _3 , ushort _4 ) 
            { 
            ushort _119 = 0;
            
            CrestronString _120;
            _120  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 254, this );
            
            
            __context__.SourceCodeLine = 36;
            _119 = (ushort) ( (_4 - _3) ) ; 
            __context__.SourceCodeLine = 36;
            _120  .UpdateValue ( Functions.Mid ( _118 ,  (int) ( _3 ) ,  (int) ( _119 ) )  ) ; 
            __context__.SourceCodeLine = 36;
            return ( _120 ) ; 
            
            }
            
        private void _117 (  SplusExecutionContext __context__, ushort _69 ) 
            { 
            CrestronString _119;
            _119  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 128, this );
            
            ushort _120 = 0;
            
            
            __context__.SourceCodeLine = 36;
            _120 = (ushort) ( Functions.BoolToInt (_71._69 != _69) ) ; 
            __context__.SourceCodeLine = 36;
            _71 . _69 = (ushort) ( _69 ) ; 
            __context__.SourceCodeLine = 36;
            
                {
                int __SPLS_TMPVAR__SWTCH_6__ = ((int)_69);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 0) ) ) ) 
                        {
                        __context__.SourceCodeLine = 37;
                        _119  .UpdateValue ( "Not connected"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 1) ) ) ) 
                        {
                        __context__.SourceCodeLine = 37;
                        _119  .UpdateValue ( "Connecting"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 2) ) ) ) 
                        {
                        __context__.SourceCodeLine = 37;
                        _119  .UpdateValue ( "Logging in"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 3) ) ) ) 
                        {
                        __context__.SourceCodeLine = 37;
                        _119  .UpdateValue ( "Invalid username or password"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 4) ) ) ) 
                        {
                        __context__.SourceCodeLine = 37;
                        _119  .UpdateValue ( "Invalid privileged password"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 6) ) ) ) 
                        {
                        __context__.SourceCodeLine = 37;
                        _119  .UpdateValue ( "Configuring"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 5) ) ) ) 
                        {
                        __context__.SourceCodeLine = 37;
                        _119  .UpdateValue ( _71 . _70 + Functions.ItoA (  (int) ( _77._74 ) ) + " x " + Functions.ItoA (  (int) ( _77._75 ) )  ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 37;
                        _119  .UpdateValue ( "Unknown"  ) ; 
                        }
                    
                    } 
                    
                }
                
            
            __context__.SourceCodeLine = 37;
            OPERATIONFB__DOLLAR__  .UpdateValue ( _119  ) ; 
            
            }
            
        private void _118 (  SplusExecutionContext __context__, _78 _120 ) 
            { 
            ushort _121 = 0;
            
            
            __context__.SourceCodeLine = 37;
            _121 = (ushort) ( _45( __context__ , ref _87 ) ) ; 
            __context__.SourceCodeLine = 37;
            _115 (  __context__ , "MsgQueue_enqueue iAddIndex = ", Functions.ItoA( (int)( _121 ) )) ; 
            __context__.SourceCodeLine = 37;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_121 != _87._44))  ) ) 
                { 
                __context__.SourceCodeLine = 37;
                _85 [ _121] . _79  .UpdateValue ( _120 . _79  ) ; 
                __context__.SourceCodeLine = 37;
                _85 [ _121] . _80  .UpdateValue ( _120 . _80  ) ; 
                __context__.SourceCodeLine = 37;
                _85 [ _121] . _81 = (ushort) ( _120._81 ) ; 
                __context__.SourceCodeLine = 37;
                _85 [ _121] . _82  .UpdateValue ( _120 . _82  ) ; 
                __context__.SourceCodeLine = 38;
                _85 [ _121] . _83 = (ushort) ( _120._83 ) ; 
                } 
            
            
            }
            
        private void _119 (  SplusExecutionContext __context__, ushort _121 , _78 _122 ) 
            { 
            
            __context__.SourceCodeLine = 38;
            _122 . _79  .UpdateValue ( _85 [ _121] . _79  ) ; 
            __context__.SourceCodeLine = 38;
            _122 . _80  .UpdateValue ( _85 [ _121] . _80  ) ; 
            __context__.SourceCodeLine = 38;
            _122 . _81 = (ushort) ( _85[ _121 ]._81 ) ; 
            __context__.SourceCodeLine = 38;
            _122 . _82  .UpdateValue ( _85 [ _121] . _82  ) ; 
            __context__.SourceCodeLine = 38;
            _122 . _83 = (ushort) ( _85[ _121 ]._83 ) ; 
            
            }
            
        private void _120 (  SplusExecutionContext __context__, ref _78 _122 ) 
            { 
            ushort _123 = 0;
            
            
            __context__.SourceCodeLine = 38;
            _123 = (ushort) ( _46( __context__ , _87 ) ) ; 
            __context__.SourceCodeLine = 38;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _123 < _87._44 ))  ) ) 
                { 
                __context__.SourceCodeLine = 38;
                _119 (  __context__ , (ushort)( _123 ), _122) ; 
                __context__.SourceCodeLine = 38;
                _85 [ _123] . _79  .UpdateValue ( "NULL STRING"  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 38;
                _115 (  __context__ , "Queue", "Queue:Error") ; 
                } 
            
            
            }
            
        private ushort _121 (  SplusExecutionContext __context__, CrestronString _123 ) 
            { 
            ushort _124 = 0;
            ushort _125 = 0;
            ushort _126 = 0;
            
            
            __context__.SourceCodeLine = 38;
            _126 = (ushort) ( 65535 ) ; 
            __context__.SourceCodeLine = 38;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( _123 ); 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( _124  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_124  >= __FN_FORSTART_VAL__1) && (_124  <= __FN_FOREND_VAL__1) ) : ( (_124  <= __FN_FORSTART_VAL__1) && (_124  >= __FN_FOREND_VAL__1) ) ; _124  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 38;
                _125 = (ushort) ( Byte( _123 , (int)( _124 ) ) ) ; 
                __context__.SourceCodeLine = 38;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _125 >= 48 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _125 <= 57 ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (_125 == 46) )) ))  ) ) 
                    { 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 38;
                    _126 = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 39;
                    break ; 
                    } 
                
                __context__.SourceCodeLine = 38;
                } 
            
            __context__.SourceCodeLine = 39;
            return (ushort)( _126) ; 
            
            }
            
        private ushort _122 (  SplusExecutionContext __context__, CrestronString _124 ) 
            { 
            ushort [] _125;
            _125  = new ushort[ 4 ];
            
            ushort [] _126;
            _126  = new ushort[ 5 ];
            
            CrestronString _127;
            _127  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
            
            
            __context__.SourceCodeLine = 39;
            _125 [ 1] = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 39;
            _125 [ 2] = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 39;
            _125 [ 3] = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 39;
            _126 [ 1] = (ushort) ( 256 ) ; 
            __context__.SourceCodeLine = 39;
            _126 [ 2] = (ushort) ( 256 ) ; 
            __context__.SourceCodeLine = 39;
            _126 [ 3] = (ushort) ( 256 ) ; 
            __context__.SourceCodeLine = 39;
            _126 [ 4] = (ushort) ( 256 ) ; 
            __context__.SourceCodeLine = 39;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( _124 ) <= 15 ) ) && Functions.TestForTrue ( _121( __context__ , _124 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 39;
                _125 [ 1] = (ushort) ( Functions.Find( "." , _124 , 1 ) ) ; 
                __context__.SourceCodeLine = 39;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _125[ 1 ] > 1 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 39;
                    _126 [ 1] = (ushort) ( Functions.Atoi( Functions.Left( _124 , (int)( (_125[ 1 ] - 1) ) ) ) ) ; 
                    __context__.SourceCodeLine = 39;
                    _125 [ 2] = (ushort) ( Functions.Find( "." , _124 , (_125[ 1 ] + 1) ) ) ; 
                    __context__.SourceCodeLine = 39;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (_125[ 2 ] + 1) > _125[ 1 ] ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 39;
                        _126 [ 2] = (ushort) ( Functions.Atoi( Functions.Mid( _124 , (int)( (_125[ 1 ] + 1) ) , (int)( ((_125[ 2 ] - _125[ 1 ]) - 1) ) ) ) ) ; 
                        __context__.SourceCodeLine = 39;
                        _125 [ 3] = (ushort) ( Functions.Find( "." , _124 , (_125[ 2 ] + 1) ) ) ; 
                        __context__.SourceCodeLine = 39;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (_125[ 3 ] + 1) > _125[ 2 ] ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 39;
                            _126 [ 3] = (ushort) ( Functions.Atoi( Functions.Mid( _124 , (int)( (_125[ 2 ] + 1) ) , (int)( ((_125[ 3 ] - _125[ 2 ]) - 1) ) ) ) ) ; 
                            __context__.SourceCodeLine = 40;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( _124 ) > _125[ 3 ] ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( _124 ) < (_125[ 3 ] + 4) ) )) ))  ) ) 
                                {
                                __context__.SourceCodeLine = 40;
                                _126 [ 4] = (ushort) ( Functions.Atoi( Functions.Right( _124 , (int)( (Functions.Length( _124 ) - _125[ 3 ]) ) ) ) ) ; 
                                }
                            
                            } 
                        
                        } 
                    
                    } 
                
                } 
            
            __context__.SourceCodeLine = 40;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _126[ 1 ] < 256 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _126[ 2 ] < 256 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _126[ 3 ] < 256 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _126[ 4 ] < 256 ) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 40;
                return (ushort)( 65535) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 40;
                return (ushort)( 0) ; 
                }
            
            
            return 0; // default return value (none specified in module)
            }
            
        private void _123 (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 40;
            _71 . _64  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 40;
            _71 . _65 = (ushort) ( 0 ) ; 
            
            }
            
        private void _124 (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 40;
            _115 (  __context__ , "MessageHandler g_MessageHandlerComms.connectState", Functions.ItoA( (int)( _71._69 ) )) ; 
            __context__.SourceCodeLine = 40;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _71._69 > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 40;
                _48 (  __context__ ,   ref  _87 ) ; 
                __context__.SourceCodeLine = 40;
                Functions.SocketDisconnectClient ( SWITCH_CLIENT ) ; 
                __context__.SourceCodeLine = 40;
                _117 (  __context__ , (ushort)( 0 )) ; 
                } 
            
            
            }
            
        private void _125 (  SplusExecutionContext __context__ ) 
            { 
            CrestronString _127;
            _127  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
            
            short _128 = 0;
            short _129 = 0;
            
            
            __context__.SourceCodeLine = 40;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_71._69 == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 40;
                _86 . _79  .UpdateValue ( "NULL STRING"  ) ; 
                __context__.SourceCodeLine = 40;
                _86 . _80  .UpdateValue ( "NULL STRING"  ) ; 
                __context__.SourceCodeLine = 40;
                _86 . _81 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 41;
                _86 . _82  .UpdateValue ( "NULL STRING"  ) ; 
                __context__.SourceCodeLine = 41;
                _86 . _83 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 41;
                _117 (  __context__ , (ushort)( 1 )) ; 
                __context__.SourceCodeLine = 41;
                _71 . _64  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 41;
                _71 . _65 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 41;
                if ( Functions.TestForTrue  ( ( _122( __context__ , P_SWITCHIP  ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 41;
                    _115 (  __context__ , "MessageHandler", "SocketConnectClient") ; 
                    __context__.SourceCodeLine = 41;
                    _128 = (short) ( Functions.SocketConnectClient( SWITCH_CLIENT , P_SWITCHIP  , (ushort)( 23 ) , (ushort)( 1 ) ) ) ; 
                    __context__.SourceCodeLine = 41;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_128 == -7) ) || Functions.TestForTrue ( Functions.BoolToInt (_128 == -8) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 41;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_128 == -7))  ) ) 
                            {
                            __context__.SourceCodeLine = 41;
                            _115 (  __context__ , "MessageHandler", "Switch - Connected") ; 
                            }
                        
                        else 
                            {
                            __context__.SourceCodeLine = 41;
                            _115 (  __context__ , "MessageHandler", "Switch - Connection attempt in progress") ; 
                            }
                        
                        __context__.SourceCodeLine = 41;
                        return ; 
                        } 
                    
                    __context__.SourceCodeLine = 41;
                    Functions.Delay (  (int) ( 1000 ) ) ; 
                    __context__.SourceCodeLine = 41;
                    _129 = (short) ( Functions.SocketGetAddressAsRequested( SWITCH_CLIENT , ref _127 ) ) ; 
                    __context__.SourceCodeLine = 42;
                    _95  .UpdateValue ( "Switch - Attempting to Connect to device at" + P_SWITCHIP + ":" + Functions.ItoA (  (int) ( 23 ) )  ) ; 
                    __context__.SourceCodeLine = 42;
                    _115 (  __context__ , "MessageHandler", _95) ; 
                    __context__.SourceCodeLine = 42;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_128 != 0) ) || Functions.TestForTrue ( Functions.BoolToInt (_129 != 0) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 42;
                        _95  .UpdateValue ( "Switch - IP Client Connect Error: " + Functions.ItoA (  (int) ( _128 ) ) + " , " + Functions.ItoA (  (int) ( _129 ) ) + " Address: " + _127  ) ; 
                        __context__.SourceCodeLine = 42;
                        _115 (  __context__ , "MessageHandler", _95) ; 
                        } 
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 42;
                    _95  .UpdateValue ( "Switch - Stored IP Address is Invalid: " + P_SWITCHIP  ) ; 
                    __context__.SourceCodeLine = 42;
                    _115 (  __context__ , "MessageHandler", _95) ; 
                    } 
                
                } 
            
            
            }
            
        private void _126 (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 42;
            _115 (  __context__ , "MessageHandler", "queueTimeOut") ; 
            __context__.SourceCodeLine = 42;
            _124 (  __context__  ) ; 
            __context__.SourceCodeLine = 42;
            _125 (  __context__  ) ; 
            
            }
            
        private void _127 (  SplusExecutionContext __context__, CrestronString _129 ) 
            { 
            CrestronString _130;
            _130  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5000, this );
            
            ushort _131 = 0;
            
            
            __context__.SourceCodeLine = 42;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_129 != "NULL STRING"))  ) ) 
                { 
                __context__.SourceCodeLine = 42;
                _131 = (ushort) ( Functions.Find( "#NULL#" , _129 ) ) ; 
                __context__.SourceCodeLine = 43;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _131 > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 43;
                    _130  .UpdateValue ( Functions.Left ( _129 ,  (int) ( (_131 - 1) ) )  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 43;
                    _130  .UpdateValue ( _129 + "\r\n"  ) ; 
                    } 
                
                __context__.SourceCodeLine = 43;
                _115 (  __context__ , "fnMessageHandler_sendCiscoCommand command ", _130) ; 
                __context__.SourceCodeLine = 43;
                Functions.SocketSend ( SWITCH_CLIENT , _130 ) ; 
                } 
            
            
            }
            
        private void _128 (  SplusExecutionContext __context__, _78 _130 ) 
            { 
            
            __context__.SourceCodeLine = 43;
            _86 . _79  .UpdateValue ( _130 . _79  ) ; 
            __context__.SourceCodeLine = 43;
            _86 . _80  .UpdateValue ( _130 . _80  ) ; 
            __context__.SourceCodeLine = 43;
            _86 . _81 = (ushort) ( _130._81 ) ; 
            __context__.SourceCodeLine = 43;
            _86 . _82  .UpdateValue ( _130 . _82  ) ; 
            __context__.SourceCodeLine = 43;
            _86 . _83 = (ushort) ( _130._83 ) ; 
            __context__.SourceCodeLine = 43;
            _91 = (ushort) ( (_91 + 1) ) ; 
            __context__.SourceCodeLine = 43;
            _113 = (ushort) ( 65535 ) ; 
            __context__.SourceCodeLine = 43;
            CreateWait ( "WAIT_FOR_RX_SEND" , 10000 , WAIT_FOR_RX_SEND_Callback ) ;
            __context__.SourceCodeLine = 43;
            _127 (  __context__ , _86._79) ; 
            
            }
            
        public void WAIT_FOR_RX_SEND_CallbackFn( object stateInfo )
        {
        
            try
            {
                Wait __LocalWait__ = (Wait)stateInfo;
                SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
                __LocalWait__.RemoveFromList();
                
            
            __context__.SourceCodeLine = 43;
            _126 (  __context__  ) ; 
            
        
        
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler(); }
            
        }
        
    private void _129 (  SplusExecutionContext __context__, CrestronString _131 ) 
        { 
        
        __context__.SourceCodeLine = 43;
        _117 (  __context__ , (ushort)( 3 )) ; 
        
        }
        
    private void _130 (  SplusExecutionContext __context__, CrestronString _132 ) 
        { 
        _78 _133;
        _133  = new _78( this, true );
        _133 .PopulateCustomAttributeList( false );
        
        
        __context__.SourceCodeLine = 43;
        _115 (  __context__ , "MessageHandler_sendPassword", "MessageHandler_sendPassword") ; 
        __context__.SourceCodeLine = 43;
        _133 . _79  .UpdateValue ( P_SWITCHPASSWORD  ) ; 
        __context__.SourceCodeLine = 43;
        _133 . _80  .UpdateValue ( "#"  ) ; 
        __context__.SourceCodeLine = 44;
        _133 . _81 = (ushort) ( 14 ) ; 
        __context__.SourceCodeLine = 44;
        _133 . _82  .UpdateValue ( "User Name:"  ) ; 
        __context__.SourceCodeLine = 44;
        _133 . _83 = (ushort) ( 14 ) ; 
        __context__.SourceCodeLine = 44;
        _128 (  __context__ , _133) ; 
        
        }
        
    private void _131 (  SplusExecutionContext __context__, CrestronString _133 ) 
        { 
        _78 _134;
        _134  = new _78( this, true );
        _134 .PopulateCustomAttributeList( false );
        
        
        __context__.SourceCodeLine = 44;
        _115 (  __context__ , "MessageHandler_sendUsername", "MessageHandler_sendUsername") ; 
        __context__.SourceCodeLine = 44;
        _134 . _79  .UpdateValue ( P_SWITCHUSERNAME  ) ; 
        __context__.SourceCodeLine = 44;
        _134 . _80  .UpdateValue ( "Password:"  ) ; 
        __context__.SourceCodeLine = 44;
        _134 . _81 = (ushort) ( 2 ) ; 
        __context__.SourceCodeLine = 44;
        _134 . _82  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 44;
        _134 . _83 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 44;
        _128 (  __context__ , _134) ; 
        
        }
        
    private void _132 (  SplusExecutionContext __context__ ) 
        { 
        _78 _134;
        _134  = new _78( this, true );
        _134 .PopulateCustomAttributeList( false );
        
        
        __context__.SourceCodeLine = 44;
        _115 (  __context__ , "MessageHandler_beginLoginSequence", "MessageHandler_beginLoginSequence") ; 
        __context__.SourceCodeLine = 44;
        _134 . _79  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 44;
        _134 . _80  .UpdateValue ( "User Name:"  ) ; 
        __context__.SourceCodeLine = 44;
        _134 . _81 = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 44;
        _134 . _82  .UpdateValue ( "#"  ) ; 
        __context__.SourceCodeLine = 44;
        _134 . _83 = (ushort) ( 14 ) ; 
        
        }
        
    private void _133 (  SplusExecutionContext __context__, ushort _135 ) 
        { 
        
        __context__.SourceCodeLine = 44;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _135 > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 44;
            _117 (  __context__ , (ushort)( 2 )) ; 
            __context__.SourceCodeLine = 44;
            _132 (  __context__  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 44;
            _117 (  __context__ , (ushort)( 0 )) ; 
            __context__.SourceCodeLine = 44;
            _48 (  __context__ ,   ref  _87 ) ; 
            } 
        
        
        }
        
    private void _134 (  SplusExecutionContext __context__, CrestronString _136 , ushort _137 , CrestronString _138 , ushort _139 , CrestronString _140 ) 
        { 
        ushort _141 = 0;
        
        _78 _142;
        _142  = new _78( this, true );
        _142 .PopulateCustomAttributeList( false );
        
        
        __context__.SourceCodeLine = 45;
        _142 . _79  .UpdateValue ( _136  ) ; 
        __context__.SourceCodeLine = 45;
        _142 . _80  .UpdateValue ( _138  ) ; 
        __context__.SourceCodeLine = 45;
        _142 . _81 = (ushort) ( _137 ) ; 
        __context__.SourceCodeLine = 45;
        _142 . _82  .UpdateValue ( _140  ) ; 
        __context__.SourceCodeLine = 45;
        _142 . _83 = (ushort) ( _137 ) ; 
        __context__.SourceCodeLine = 45;
        _115 (  __context__ , "MessageHandler_sendMessage", _136) ; 
        __context__.SourceCodeLine = 45;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _71._69 >= 5 ) ) && Functions.TestForTrue ( Functions.BoolToInt (_86._79 == "NULL STRING") )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 45;
            _128 (  __context__ , _142) ; 
            __context__.SourceCodeLine = 45;
            _115 (  __context__ , "MessageHandler_sendMessage", "MessageHandler_sendNow") ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 45;
            _118 (  __context__ , _142) ; 
            __context__.SourceCodeLine = 45;
            _115 (  __context__ , "MessageHandler_sendMessage", "queue_enqueue") ; 
            __context__.SourceCodeLine = 45;
            _125 (  __context__  ) ; 
            } 
        
        
        }
        
    private void _135 (  SplusExecutionContext __context__, CrestronString _137 , ushort _138 , CrestronString _139 , ushort _140 , CrestronString _141 ) 
        { 
        ushort _142 = 0;
        
        _78 _143;
        _143  = new _78( this, true );
        _143 .PopulateCustomAttributeList( false );
        
        
        __context__.SourceCodeLine = 45;
        _143 . _79  .UpdateValue ( _137  ) ; 
        __context__.SourceCodeLine = 46;
        _143 . _80  .UpdateValue ( _139  ) ; 
        __context__.SourceCodeLine = 46;
        _143 . _81 = (ushort) ( _138 ) ; 
        __context__.SourceCodeLine = 46;
        _143 . _82  .UpdateValue ( _141  ) ; 
        __context__.SourceCodeLine = 46;
        _143 . _83 = (ushort) ( _138 ) ; 
        __context__.SourceCodeLine = 46;
        _118 (  __context__ , _143) ; 
        __context__.SourceCodeLine = 46;
        _115 (  __context__ , "MessageHandler_sendMessage", "queue_enqueue") ; 
        
        }
        
    private void _136 (  SplusExecutionContext __context__ ) 
        { 
        _78 _138;
        _138  = new _78( this, true );
        _138 .PopulateCustomAttributeList( false );
        
        
        __context__.SourceCodeLine = 46;
        _120 (  __context__ ,   ref  _138 ) ; 
        __context__.SourceCodeLine = 46;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_138._79 == "NULL STRING"))  ) ) 
            { 
            __context__.SourceCodeLine = 46;
            CreateWait ( "__SPLS_TMPVAR__WAITLABEL_0__" , 10 , __SPLS_TMPVAR__WAITLABEL_0___Callback ) ;
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 46;
            _128 (  __context__ , _138) ; 
            } 
        
        
        }
        
    public void __SPLS_TMPVAR__WAITLABEL_0___CallbackFn( object stateInfo )
    {
    
        try
        {
            Wait __LocalWait__ = (Wait)stateInfo;
            SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
            __LocalWait__.RemoveFromList();
            
            
            __context__.SourceCodeLine = 46;
            _115 (  __context__ , "Wait 10 - NULL_MESSAGE", "") ; 
            __context__.SourceCodeLine = 46;
            _136 (  __context__  ) ; 
            
        
        
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        
    }
    
private void _137 (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 46;
    _115 (  __context__ , "MessageHandler", "Closing TCP connection comms") ; 
    __context__.SourceCodeLine = 46;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_71._67 != ""))  ) ) 
        { 
        __context__.SourceCodeLine = 46;
        _71 . _67  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 46;
        _71 . _68 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 46;
        _48 (  __context__ ,   ref  _87 ) ; 
        __context__.SourceCodeLine = 46;
        _124 (  __context__  ) ; 
        __context__.SourceCodeLine = 46;
        _117 (  __context__ , (ushort)( 0 )) ; 
        } 
    
    
    }
    
private void _138 (  SplusExecutionContext __context__, CrestronString _67 , ushort _68 ) 
    { 
    
    __context__.SourceCodeLine = 46;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_71._69 != 0))  ) ) 
        { 
        __context__.SourceCodeLine = 46;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_71._67 != "") ) && Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_71._67 != _67) ) || Functions.TestForTrue ( Functions.BoolToInt (_71._68 != _68) )) ) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 46;
            _137 (  __context__  ) ; 
            }
        
        } 
    
    __context__.SourceCodeLine = 46;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_71._69 == 0))  ) ) 
        { 
        __context__.SourceCodeLine = 47;
        _71 . _67  .UpdateValue ( _67  ) ; 
        __context__.SourceCodeLine = 47;
        _71 . _68 = (ushort) ( _68 ) ; 
        __context__.SourceCodeLine = 47;
        _125 (  __context__  ) ; 
        } 
    
    
    }
    
private void _139 (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 47;
    _134 (  __context__ , " ", (ushort)( 0 ), "#", (ushort)( 0 ), "") ; 
    
    }
    
private void _140 (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 47;
    _71 . _64  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 47;
    _71 . _65 = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 47;
    _71 . _66 = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 47;
    _71 . _67  .UpdateValue ( P_SWITCHIP  ) ; 
    __context__.SourceCodeLine = 47;
    _71 . _68 = (ushort) ( 23 ) ; 
    __context__.SourceCodeLine = 47;
    _71 . _69 = (ushort) ( Functions.ToInteger( -( 1 ) ) ) ; 
    __context__.SourceCodeLine = 47;
    _117 (  __context__ , (ushort)( 0 )) ; 
    
    }
    
private void _141 (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 47;
    _138 (  __context__ , P_SWITCHIP , (ushort)( 23 )) ; 
    
    }
    
private CrestronString _142 (  SplusExecutionContext __context__, ushort _144 ) 
    { 
    CrestronString _145;
    _145  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    
    ushort _146 = 0;
    ushort _147 = 0;
    ushort _148 = 0;
    
    
    __context__.SourceCodeLine = 47;
    _146 = (ushort) ( ((_89 + 11) - 1) ) ; 
    __context__.SourceCodeLine = 47;
    _147 = (ushort) ( (_144 + 11) ) ; 
    __context__.SourceCodeLine = 47;
    _148 = (ushort) ( (10 - 1) ) ; 
    __context__.SourceCodeLine = 47;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_144 == (_89 - 1)))  ) ) 
        { 
        __context__.SourceCodeLine = 47;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_89 == 1))  ) ) 
            {
            __context__.SourceCodeLine = 47;
            MakeString ( _145 , "1-{0:d}", (short)_148) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 47;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_89 == 2))  ) ) 
                {
                __context__.SourceCodeLine = 47;
                MakeString ( _145 , "1-{0:d},{1:d}", (short)_148, (short)11) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 47;
                MakeString ( _145 , "1-{0:d},{1:d}-{2:d}", (short)_148, (short)11, (short)(_146 - 1)) ; 
                }
            
            }
        
        } 
    
    else 
        {
        __context__.SourceCodeLine = 47;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_144 == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 47;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_89 == 2))  ) ) 
                {
                __context__.SourceCodeLine = 48;
                MakeString ( _145 , "1-{0:d},{1:d}", (short)_148, (short)(11 + 1)) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 48;
                MakeString ( _145 , "1-{0:d},{1:d}-{2:d}", (short)_148, (short)(11 + 1), (short)_146) ; 
                }
            
            } 
        
        else 
            {
            __context__.SourceCodeLine = 48;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_144 == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 48;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_89 == 3))  ) ) 
                    {
                    __context__.SourceCodeLine = 48;
                    MakeString ( _145 , "1-{0:d},{1:d},{2:d}", (short)_148, (short)11, (short)(11 + 2)) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 48;
                    MakeString ( _145 , "1-{0:d},{1:d},{2:d}-{3:d}", (short)_148, (short)11, (short)(_147 + 1), (short)_146) ; 
                    }
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 48;
                MakeString ( _145 , "1-{0:d},{1:d}-{2:d},{3:d}-{4:d}", (short)_148, (short)11, (short)(_147 - 1), (short)(_147 + 1), (short)_146) ; 
                } 
            
            }
        
        }
    
    __context__.SourceCodeLine = 48;
    return ( _145 ) ; 
    
    }
    
private void _143 (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 48;
    _115 (  __context__ , " fnCiscoSwitch_handleSaveStatus", "") ; 
    __context__.SourceCodeLine = 48;
    _134 (  __context__ , "copy running-config startup-config", (ushort)( 15 ), "Overwrite file [startup-config].... (Y/N)", (ushort)( 0 ), "") ; 
    
    }
    
private ushort _144 (  SplusExecutionContext __context__, CrestronString _146 , short _147 , short [,] _148 , ref CrestronString [] _149 ) 
    { 
    short _150 = 0;
    
    ushort _151 = 0;
    ushort _152 = 0;
    ushort _153 = 0;
    ushort _154 = 0;
    ushort _155 = 0;
    ushort _156 = 0;
    ushort _157 = 0;
    ushort _158 = 0;
    ushort POS = 0;
    
    CrestronString _159;
    CrestronString _160;
    CrestronString _161;
    _159  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    _160  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 254, this );
    _161  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    
    _0 _162;
    _162  = new _0( this, true );
    _162 .PopulateCustomAttributeList( false );
    
    
    __context__.SourceCodeLine = 49;
    _150 = (short) ( 0 ) ; 
    __context__.SourceCodeLine = 49;
    _151 = (ushort) ( 1 ) ; 
    __context__.SourceCodeLine = 49;
    _152 = (ushort) ( Functions.Length( _146 ) ) ; 
    __context__.SourceCodeLine = 49;
    do 
        { 
        __context__.SourceCodeLine = 49;
        POS = (ushort) ( Functions.Find( "," , _146 , _151 ) ) ; 
        __context__.SourceCodeLine = 49;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (POS == 0))  ) ) 
            {
            __context__.SourceCodeLine = 49;
            _153 = (ushort) ( _152 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 49;
            _153 = (ushort) ( POS ) ; 
            }
        
        __context__.SourceCodeLine = 49;
        _160  .UpdateValue ( "gi(%d*)/?(%d*)/?(%d*)-?(%d*)"  ) ; 
        __context__.SourceCodeLine = 49;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _37( __context__ , _146 , (ushort)( _153 ) , (short)( _151 ) , _160 , (ushort)( Functions.Length( _160 ) ) , ref _162 ) > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 49;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _162._4[ 3 ] > _162._3[ 3 ] ))  ) ) 
                { 
                __context__.SourceCodeLine = 49;
                _155 = (ushort) ( (Functions.Atoi( _116( __context__ , _146 , (ushort)( _162._3[ 1 ] ) , (ushort)( _162._4[ 1 ] ) ) ) - 1) ) ; 
                __context__.SourceCodeLine = 49;
                _156 = (ushort) ( 3 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 49;
                _155 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 49;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _162._4[ 2 ] > _162._3[ 2 ] ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 49;
                    _156 = (ushort) ( 2 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 49;
                    _156 = (ushort) ( 1 ) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 49;
            _157 = (ushort) ( Functions.Atoi( _116( __context__ , _146 , (ushort)( _162._3[ _156 ] ) , (ushort)( _162._4[ _156 ] ) ) ) ) ; 
            __context__.SourceCodeLine = 50;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _162._4[ 4 ] > _162._3[ 4 ] ))  ) ) 
                {
                __context__.SourceCodeLine = 50;
                _158 = (ushort) ( Functions.Atoi( _116( __context__ , _146 , (ushort)( _162._3[ 4 ] ) , (ushort)( _162._4[ 4 ] ) ) ) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 50;
                _158 = (ushort) ( _157 ) ; 
                }
            
            __context__.SourceCodeLine = 50;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _157 < 1 ) ) || Functions.TestForTrue ( Functions.BoolToInt ( _158 > 52 ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( _157 > _158 ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( _155 < 0 ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( _155 >= 8 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 50;
                _115 (  __context__ , "_recordPortsInMap", "Invalid port name in VLAN port list") ; 
                __context__.SourceCodeLine = 50;
                _150 = (short) ( Functions.ToSignedInteger( -( 1000 ) ) ) ; 
                __context__.SourceCodeLine = 50;
                break ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 50;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( _149[ _155 ] ) == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 50;
                    _149 [ _155]  .UpdateValue ( _146  ) ; 
                    __context__.SourceCodeLine = 50;
                    _149 [ _155]  .UpdateValue ( Functions.Mid ( _149 [ _155] ,  (int) ( _151 ) ,  (int) ( (_162._3[ _156 ] - _151) ) )  ) ; 
                    } 
                
                __context__.SourceCodeLine = 50;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( _157 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)_158; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( _154  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_154  >= __FN_FORSTART_VAL__1) && (_154  <= __FN_FOREND_VAL__1) ) : ( (_154  <= __FN_FORSTART_VAL__1) && (_154  >= __FN_FOREND_VAL__1) ) ; _154  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 50;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_148[ _155 , _154 ] == 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 50;
                        _148 [ _155 , _154] = (short) ( _147 ) ; 
                        __context__.SourceCodeLine = 50;
                        _150 = (short) ( (_150 + 1) ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 50;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_148[ _155 , _154 ] != Functions.ToSignedLongInteger( -( _147 ) )))  ) ) 
                            { 
                            __context__.SourceCodeLine = 50;
                            _115 (  __context__ , "_recordPortsInMap", "Port appears on more than one TX VLAN") ; 
                            __context__.SourceCodeLine = 51;
                            _150 = (short) ( Functions.ToSignedInteger( -( 1000 ) ) ) ; 
                            } 
                        
                        }
                    
                    __context__.SourceCodeLine = 50;
                    } 
                
                __context__.SourceCodeLine = 51;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _158 > _148[ _155 , 0 ] ))  ) ) 
                    {
                    __context__.SourceCodeLine = 51;
                    _148 [ _155 , 0] = (short) ( _158 ) ; 
                    }
                
                } 
            
            } 
        
        else 
            {
            __context__.SourceCodeLine = 51;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_153 != _151))  ) ) 
                { 
                __context__.SourceCodeLine = 51;
                _115 (  __context__ , "_recordPortsInMap", "Unexpected port list format") ; 
                __context__.SourceCodeLine = 51;
                _150 = (short) ( Functions.ToSignedInteger( -( 1000 ) ) ) ; 
                __context__.SourceCodeLine = 51;
                break ; 
                } 
            
            }
        
        __context__.SourceCodeLine = 51;
        _151 = (ushort) ( (_153 + 1) ) ; 
        } 
    while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (_153 == _152)) )); 
    __context__.SourceCodeLine = 51;
    return (ushort)( _150) ; 
    
    }
    
private void _145 (  SplusExecutionContext __context__, ushort _147 , CrestronString _148 ) 
    { 
    CrestronString _149;
    CrestronString _150;
    CrestronString _151;
    _149  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    _150  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    _151  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
    
    
    __context__.SourceCodeLine = 51;
    _149  .UpdateValue ( "10," + Functions.ItoA (  (int) ( (_147 + 10) ) )  ) ; 
    __context__.SourceCodeLine = 51;
    _150  .UpdateValue ( _142 (  __context__ , (ushort)( (_147 - 1) ))  ) ; 
    __context__.SourceCodeLine = 51;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_148 != ""))  ) ) 
        { 
        __context__.SourceCodeLine = 51;
        _135 (  __context__ , "configure", (ushort)( 0 ), "(config)#", (ushort)( 0 ), "") ; 
        __context__.SourceCodeLine = 51;
        MakeString ( _151 , "interface range {0}", _148 ) ; 
        __context__.SourceCodeLine = 51;
        _135 (  __context__ , _151, (ushort)( 0 ), "#", (ushort)( 15 ), "Do you wish to continue") ; 
        __context__.SourceCodeLine = 52;
        MakeString ( _151 , "switchport general allowed vlan add {0} untagged", _149 ) ; 
        __context__.SourceCodeLine = 52;
        _135 (  __context__ , _151, (ushort)( 0 ), "#", (ushort)( 0 ), "") ; 
        __context__.SourceCodeLine = 52;
        MakeString ( _151 , "switchport general allowed vlan remove {0}", _150 ) ; 
        __context__.SourceCodeLine = 52;
        _135 (  __context__ , _151, (ushort)( 0 ), "#", (ushort)( 0 ), "") ; 
        __context__.SourceCodeLine = 52;
        _135 (  __context__ , "exit", (ushort)( 0 ), "#", (ushort)( 0 ), "") ; 
        __context__.SourceCodeLine = 52;
        _135 (  __context__ , "exit", (ushort)( 0 ), "#", (ushort)( 0 ), "") ; 
        __context__.SourceCodeLine = 52;
        _136 (  __context__  ) ; 
        } 
    
    
    }
    
private ushort _146 (  SplusExecutionContext __context__, ushort _148 , CrestronString [] _149 ) 
    { 
    CrestronString _150;
    CrestronString _151;
    CrestronString _152;
    _150  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5000, this );
    _151  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    _152  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    
    ushort _153 = 0;
    ushort _154 = 0;
    
    
    __context__.SourceCodeLine = 52;
    _154 = (ushort) ( 1 ) ; 
    __context__.SourceCodeLine = 52;
    while ( Functions.TestForTrue  ( ( Functions.BoolToInt (_149[ _154 ] != ""))  ) ) 
        { 
        __context__.SourceCodeLine = 52;
        MakeString ( _151 , "physicalRange[{0:d}]= {1}", (short)_154, _149 [ _154] ) ; 
        __context__.SourceCodeLine = 52;
        _115 (  __context__ , "CiscoComms", _151) ; 
        __context__.SourceCodeLine = 52;
        _154 = (ushort) ( (_154 + 1) ) ; 
        __context__.SourceCodeLine = 52;
        } 
    
    __context__.SourceCodeLine = 52;
    _154 = (ushort) ( (_154 - 1) ) ; 
    __context__.SourceCodeLine = 53;
    MakeString ( _151 , "switchPhysicalRange rangeLength = {0:d}", (short)_154) ; 
    __context__.SourceCodeLine = 53;
    _115 (  __context__ , "CiscoComms", _151) ; 
    __context__.SourceCodeLine = 53;
    ushort __FN_FORSTART_VAL__1 = (ushort) ( 0 ) ;
    ushort __FN_FOREND_VAL__1 = (ushort)_154; 
    int __FN_FORSTEP_VAL__1 = (int)1; 
    for ( _153  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_153  >= __FN_FORSTART_VAL__1) && (_153  <= __FN_FOREND_VAL__1) ) : ( (_153  <= __FN_FORSTART_VAL__1) && (_153  >= __FN_FOREND_VAL__1) ) ; _153  += (ushort)__FN_FORSTEP_VAL__1) 
        { 
        __context__.SourceCodeLine = 53;
        MakeString ( _151 , " switchPhysicalRange physicalRange[{0:d}] = {1}", (short)_153, _149 [ _153] ) ; 
        __context__.SourceCodeLine = 53;
        _115 (  __context__ , "CiscoComms", _151) ; 
        __context__.SourceCodeLine = 53;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_150 != "") ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( _150 ) < 80 ) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 53;
            _150  .UpdateValue ( _150 + ","  ) ; 
            }
        
        __context__.SourceCodeLine = 53;
        _150  .UpdateValue ( _150 + _149 [ _153]  ) ; 
        __context__.SourceCodeLine = 53;
        MakeString ( _151 , " switchPhysicalRange range = {0}", _150 ) ; 
        __context__.SourceCodeLine = 53;
        _115 (  __context__ , "CiscoComms", _151) ; 
        __context__.SourceCodeLine = 53;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( _150 ) > 80 ))  ) ) 
            { 
            __context__.SourceCodeLine = 53;
            _145 (  __context__ , (ushort)( _148 ), _150) ; 
            __context__.SourceCodeLine = 53;
            _150  .UpdateValue ( ""  ) ; 
            } 
        
        __context__.SourceCodeLine = 53;
        } 
    
    __context__.SourceCodeLine = 53;
    _145 (  __context__ , (ushort)( _148 ), _150) ; 
    
    return 0; // default return value (none specified in module)
    }
    
private void _147 (  SplusExecutionContext __context__, CrestronString _149 , CrestronString _68 , CrestronString _150 ) 
    { 
    ushort _151 = 0;
    
    CrestronString _152;
    CrestronString _153;
    _152  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    _153  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 25, this );
    
    CrestronString _154;
    CrestronString _155;
    CrestronString _156;
    _154  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    _155  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    _156  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    
    
    __context__.SourceCodeLine = 54;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_101 == "SG300"))  ) ) 
        {
        __context__.SourceCodeLine = 54;
        MakeString ( _154 , "gi{0}", _68 ) ; 
        }
    
    else 
        {
        __context__.SourceCodeLine = 54;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_101 == "SG500-Standalone"))  ) ) 
            {
            __context__.SourceCodeLine = 54;
            MakeString ( _154 , "gi{0}/{1}", _149 , _68 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 54;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_101 == "SG500-Stack"))  ) ) 
                {
                __context__.SourceCodeLine = 54;
                MakeString ( _154 , "gi{0}/1/{1}", _149 , _68 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 54;
                _101  .UpdateValue ( "null"  ) ; 
                }
            
            }
        
        }
    
    __context__.SourceCodeLine = 54;
    _115 (  __context__ , "fnCiscoSwitch_ChangePOE() g_stackForPOE = ", _101) ; 
    __context__.SourceCodeLine = 54;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_101 != "null"))  ) ) 
        { 
        __context__.SourceCodeLine = 54;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_150 == "ON"))  ) ) 
            { 
            __context__.SourceCodeLine = 54;
            _153  .UpdateValue ( "auto"  ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 54;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_150 == "OFF"))  ) ) 
                { 
                __context__.SourceCodeLine = 54;
                _153  .UpdateValue ( "never"  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 54;
                _153  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 54;
                _115 (  __context__ , "CiscoSwitch_ChangePOE", "UNKNOWN ACTION") ; 
                } 
            
            }
        
        __context__.SourceCodeLine = 54;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_153 != ""))  ) ) 
            { 
            __context__.SourceCodeLine = 54;
            _135 (  __context__ , "configure", (ushort)( 0 ), "(config)#", (ushort)( 0 ), "") ; 
            __context__.SourceCodeLine = 55;
            MakeString ( _152 , "interface {0}\r\npower inline {1}\r\nexit", _154 , _153 ) ; 
            __context__.SourceCodeLine = 55;
            _135 (  __context__ , _152, (ushort)( 0 ), "(config)#", (ushort)( 0 ), "") ; 
            __context__.SourceCodeLine = 55;
            _135 (  __context__ , "exit", (ushort)( 0 ), "#", (ushort)( 0 ), "") ; 
            __context__.SourceCodeLine = 55;
            _136 (  __context__  ) ; 
            } 
        
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 55;
        _115 (  __context__ , "CiscoSwitch_ChangePOE", "SWITCH DOESN'T SUPPORT POE") ; 
        } 
    
    
    }
    
private void _148 (  SplusExecutionContext __context__, ushort _150 , CrestronString _151 ) 
    { 
    ushort [] _152;
    ushort _153 = 0;
    ushort _154 = 0;
    ushort _155 = 0;
    _152  = new ushort[ 405 ];
    
    CrestronString _156;
    _156  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 404, this );
    
    CrestronString _157;
    _157  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 404, this );
    
    CrestronString _158;
    CrestronString [] _159;
    _158  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    _159  = new CrestronString[ 256 ];
    for( uint i = 0; i < 256; i++ )
        _159 [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    
    CrestronString _3;
    _3  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    
    CrestronString _4;
    _4  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
    
    ushort _160 = 0;
    
    ushort _161 = 0;
    
    CrestronString _162;
    _162  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    
    ushort _163 = 0;
    
    CrestronString [] _164;
    _164  = new CrestronString[ 101 ];
    for( uint i = 0; i < 101; i++ )
        _164 [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    
    CrestronString _165;
    _165  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    
    _0 _166;
    _166  = new _0( this, true );
    _166 .PopulateCustomAttributeList( false );
    
    
    __context__.SourceCodeLine = 55;
    _155 = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 55;
    _156  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 55;
    _157  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 55;
    _158  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 55;
    _3  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 55;
    _4  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 55;
    _160 = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 56;
    ushort __FN_FORSTART_VAL__1 = (ushort) ( 0 ) ;
    ushort __FN_FOREND_VAL__1 = (ushort)404; 
    int __FN_FORSTEP_VAL__1 = (int)1; 
    for ( _161  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_161  >= __FN_FORSTART_VAL__1) && (_161  <= __FN_FOREND_VAL__1) ) : ( (_161  <= __FN_FORSTART_VAL__1) && (_161  >= __FN_FOREND_VAL__1) ) ; _161  += (ushort)__FN_FORSTEP_VAL__1) 
        {
        __context__.SourceCodeLine = 56;
        _152 [ _161] = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 56;
        }
    
    __context__.SourceCodeLine = 56;
    MakeString ( _165 , " Input: {0:d} Output: {1}", (short)_150, _151 ) ; 
    __context__.SourceCodeLine = 56;
    _115 (  __context__ , "createRangeInterface()", _165) ; 
    __context__.SourceCodeLine = 56;
    do 
        { 
        __context__.SourceCodeLine = 56;
        _153 = (ushort) ( Functions.Find( "," , _151 , 1 ) ) ; 
        __context__.SourceCodeLine = 56;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _153 > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 56;
            _162  .UpdateValue ( Functions.Remove ( "," , _151 , 1)  ) ; 
            __context__.SourceCodeLine = 56;
            _162  .UpdateValue ( Functions.Left ( _162 ,  (int) ( (Functions.Length( _162 ) - 1) ) )  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 56;
            _162  .UpdateValue ( _151  ) ; 
            } 
        
        __context__.SourceCodeLine = 56;
        _161 = (ushort) ( Functions.Atoi( _162 ) ) ; 
        __context__.SourceCodeLine = 56;
        _152 [ _161] = (ushort) ( 1 ) ; 
        } 
    while (false == ( Functions.TestForTrue  ( Functions.BoolToInt ( _153 < 1 )) )); 
    __context__.SourceCodeLine = 56;
    MakeString ( _165 , " g_CiscoSwitch.readyForCommands = {0:d}", (short)_77._76) ; 
    __context__.SourceCodeLine = 56;
    _115 (  __context__ , "createRangeInterface()", _165) ; 
    __context__.SourceCodeLine = 56;
    ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
    ushort __FN_FOREND_VAL__2 = (ushort)(_90 + 1); 
    int __FN_FORSTEP_VAL__2 = (int)1; 
    for ( _161  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (_161  >= __FN_FORSTART_VAL__2) && (_161  <= __FN_FOREND_VAL__2) ) : ( (_161  <= __FN_FORSTART_VAL__2) && (_161  >= __FN_FOREND_VAL__2) ) ; _161  += (ushort)__FN_FORSTEP_VAL__2) 
        { 
        __context__.SourceCodeLine = 56;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( _152[ _161 ] ) && Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _161 <= _90 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _161 > 0 ) )) ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _150 <= _89 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _150 > 0 ) )) ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 56;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_77._73 == 0) ) && Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _150 > 3 ) ) || Functions.TestForTrue ( Functions.BoolToInt ( _161 > 3 ) )) ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 57;
                MakeString ( _165 , " DEMO Invalid port Number Input = {0:d} Output: {1:d}", (short)_150, (short)_161) ; 
                __context__.SourceCodeLine = 57;
                _115 (  __context__ , "createRangeInterface", _165) ; 
                __context__.SourceCodeLine = 57;
                _152 [ _161] = (ushort) ( 0 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 57;
                OUTPUTFB [ _161]  .Value = (ushort) ( _150 ) ; 
                __context__.SourceCodeLine = 57;
                MakeString ( _165 , " g_rxPositionOnStack[{0:d}] = : {1}", (short)_161, _100 [ _161 ] ) ; 
                __context__.SourceCodeLine = 57;
                _115 (  __context__ , "createRangeInterface  ", _165) ; 
                __context__.SourceCodeLine = 57;
                _162  .UpdateValue ( _100 [ _161 ]  ) ; 
                __context__.SourceCodeLine = 57;
                _163 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 57;
                do 
                    { 
                    __context__.SourceCodeLine = 57;
                    _153 = (ushort) ( Functions.Find( "/" , _162 , 1 ) ) ; 
                    __context__.SourceCodeLine = 57;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _153 > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 57;
                        _163 = (ushort) ( (_163 + 1) ) ; 
                        __context__.SourceCodeLine = 57;
                        _164 [ _163 ]  .UpdateValue ( Functions.Remove ( "/" , _162 , 1)  ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 57;
                        _163 = (ushort) ( (_163 + 1) ) ; 
                        __context__.SourceCodeLine = 57;
                        _164 [ _163 ]  .UpdateValue ( _162  ) ; 
                        } 
                    
                    } 
                while (false == ( Functions.TestForTrue  ( Functions.BoolToInt ( _153 < 1 )) )); 
                __context__.SourceCodeLine = 57;
                MakeString ( _165 , " createRangeInterface()  - split2length {0:d}", (short)_163) ; 
                __context__.SourceCodeLine = 57;
                _115 (  __context__ , "createRangeInterface", _165) ; 
                __context__.SourceCodeLine = 58;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _163 > 1 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 58;
                    _158  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 58;
                    _156  .UpdateValue ( _164 [ _163 ]  ) ; 
                    __context__.SourceCodeLine = 58;
                    ushort __FN_FORSTART_VAL__3 = (ushort) ( 1 ) ;
                    ushort __FN_FOREND_VAL__3 = (ushort)(_163 - 1); 
                    int __FN_FORSTEP_VAL__3 = (int)1; 
                    for ( _154  = __FN_FORSTART_VAL__3; (__FN_FORSTEP_VAL__3 > 0)  ? ( (_154  >= __FN_FORSTART_VAL__3) && (_154  <= __FN_FOREND_VAL__3) ) : ( (_154  <= __FN_FORSTART_VAL__3) && (_154  >= __FN_FOREND_VAL__3) ) ; _154  += (ushort)__FN_FORSTEP_VAL__3) 
                        {
                        __context__.SourceCodeLine = 58;
                        _158  .UpdateValue ( _158 + _164 [ _154 ]  ) ; 
                        __context__.SourceCodeLine = 58;
                        }
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 58;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _38( __context__ , _100[ _161 ] , (short)( 1 ) , "gi(%d+)" , ref _166 ) > Functions.ToSignedLongInteger( -( 1 ) ) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 58;
                        _156  .UpdateValue ( _116 (  __context__ , _100[ _161 ], (ushort)( _166._3[ 1 ] ), (ushort)( _166._4[ 1 ] ))  ) ; 
                        __context__.SourceCodeLine = 58;
                        _158  .UpdateValue ( "gi"  ) ; 
                        } 
                    
                    }
                
                __context__.SourceCodeLine = 58;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_3 != ""))  ) ) 
                    {
                    __context__.SourceCodeLine = 58;
                    _160 = (ushort) ( _38( __context__ , _3 , (short)( 1 ) , _158 , ref _166 ) ) ; 
                    }
                
                __context__.SourceCodeLine = 58;
                MakeString ( _165 , "switchLogicalRange() - previousposOnSwitch: {0} posOnSwitch: {1} checkPrefix: {2:d} Prefix: {3} start:{4} ", _157 , _156 , (short)_160, _158 , _3 ) ; 
                __context__.SourceCodeLine = 58;
                _115 (  __context__ , "createRangeInterface", _165) ; 
                __context__.SourceCodeLine = 58;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ((Functions.Atoi( _157 ) + 1) == Functions.Atoi( _156 )) ) && Functions.TestForTrue ( Functions.BoolToInt (_160 != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (_3 == "") )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 58;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_3 == ""))  ) ) 
                        { 
                        __context__.SourceCodeLine = 58;
                        _3  .UpdateValue ( _100 [ _161 ]  ) ; 
                        __context__.SourceCodeLine = 58;
                        _4  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 58;
                        _157  .UpdateValue ( _156  ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 58;
                        _4  .UpdateValue ( _156  ) ; 
                        __context__.SourceCodeLine = 58;
                        _157  .UpdateValue ( _156  ) ; 
                        } 
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 59;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_3 != ""))  ) ) 
                        { 
                        __context__.SourceCodeLine = 59;
                        _155 = (ushort) ( (_155 + 1) ) ; 
                        __context__.SourceCodeLine = 59;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_4 == ""))  ) ) 
                            {
                            __context__.SourceCodeLine = 59;
                            _159 [ _155 ]  .UpdateValue ( _3  ) ; 
                            }
                        
                        else 
                            {
                            __context__.SourceCodeLine = 59;
                            _159 [ _155 ]  .UpdateValue ( _3 + "-" + _4  ) ; 
                            }
                        
                        __context__.SourceCodeLine = 59;
                        _3  .UpdateValue ( _100 [ _161 ]  ) ; 
                        __context__.SourceCodeLine = 59;
                        _4  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 59;
                        _157  .UpdateValue ( _156  ) ; 
                        } 
                    
                    }
                
                } 
            
            } 
        
        else 
            {
            __context__.SourceCodeLine = 59;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_3 != ""))  ) ) 
                { 
                __context__.SourceCodeLine = 59;
                _155 = (ushort) ( (_155 + 1) ) ; 
                __context__.SourceCodeLine = 59;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_4 == ""))  ) ) 
                    {
                    __context__.SourceCodeLine = 59;
                    _159 [ _155 ]  .UpdateValue ( _3  ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 59;
                    _159 [ _155 ]  .UpdateValue ( _3 + "-" + _4  ) ; 
                    }
                
                __context__.SourceCodeLine = 59;
                _3  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 59;
                _4  .UpdateValue ( ""  ) ; 
                } 
            
            }
        
        __context__.SourceCodeLine = 56;
        } 
    
    __context__.SourceCodeLine = 59;
    if ( Functions.TestForTrue  ( ( _146( __context__ , (ushort)( _150 ) , _159 ))  ) ) 
        { 
        } 
    
    
    }
    
private void _149 (  SplusExecutionContext __context__ ) 
    { 
    _78 _151;
    _151  = new _78( this, true );
    _151 .PopulateCustomAttributeList( false );
    
    
    __context__.SourceCodeLine = 59;
    _115 (  __context__ , "fnCiscoSwitch_Send_Y()", "") ; 
    __context__.SourceCodeLine = 59;
    _151 . _79  .UpdateValue ( "y#NULL#"  ) ; 
    __context__.SourceCodeLine = 59;
    _151 . _80  .UpdateValue ( "#"  ) ; 
    __context__.SourceCodeLine = 59;
    _151 . _81 = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 59;
    _151 . _82  .UpdateValue ( "Do you want to continue ? (Y/N)"  ) ; 
    __context__.SourceCodeLine = 59;
    _151 . _83 = (ushort) ( 17 ) ; 
    __context__.SourceCodeLine = 59;
    _128 (  __context__ , _151) ; 
    
    }
    
private void _150 (  SplusExecutionContext __context__ ) 
    { 
    _78 _152;
    _152  = new _78( this, true );
    _152 .PopulateCustomAttributeList( false );
    
    
    __context__.SourceCodeLine = 59;
    _115 (  __context__ , "fnCiscoSwitch_Send_Y()", "") ; 
    __context__.SourceCodeLine = 59;
    _152 . _79  .UpdateValue ( "y#NULL#"  ) ; 
    __context__.SourceCodeLine = 59;
    _152 . _80  .UpdateValue ( "Shutting down ..."  ) ; 
    __context__.SourceCodeLine = 60;
    _152 . _81 = (ushort) ( 18 ) ; 
    __context__.SourceCodeLine = 60;
    _152 . _82  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 60;
    _152 . _83 = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 60;
    _128 (  __context__ , _152) ; 
    __context__.SourceCodeLine = 60;
    _98 = (ushort) ( 65535 ) ; 
    
    }
    
private void _151 (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 60;
    CreateWait ( "__SPLS_TMPVAR__WAITLABEL_1__" , 200 , __SPLS_TMPVAR__WAITLABEL_1___Callback ) ;
    
    }
    
public void __SPLS_TMPVAR__WAITLABEL_1___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 60;
            REBOOTINGINPROGRESS  .Value = (ushort) ( 0 ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

private void _152 (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 60;
    _137 (  __context__  ) ; 
    __context__.SourceCodeLine = 60;
    _77 . _76 = (ushort) ( 0 ) ; 
    
    }
    
private void _153 (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 60;
    _115 (  __context__ , "startUp", "startUp") ; 
    __context__.SourceCodeLine = 60;
    _140 (  __context__  ) ; 
    __context__.SourceCodeLine = 60;
    _77 . _76 = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 60;
    _138 (  __context__ , P_SWITCHIP , (ushort)( 23 )) ; 
    
    }
    
private void _154 (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 60;
    _77 . _73 = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 60;
    _77 . _74 = (ushort) ( 3 ) ; 
    __context__.SourceCodeLine = 60;
    _77 . _75 = (ushort) ( 3 ) ; 
    
    }
    
private ushort _155 (  SplusExecutionContext __context__, ushort _157 ) 
    { 
    ushort _158 = 0;
    ushort _159 = 0;
    ushort _160 = 0;
    ushort _161 = 0;
    ushort _162 = 0;
    
    CrestronString _163;
    CrestronString _164;
    _163  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
    _164  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
    
    
    __context__.SourceCodeLine = 60;
    _115 (  __context__ , "fnCiscoSwitch_CreateCmdfromTables startFrom", Functions.ItoA( (int)( _157 ) )) ; 
    __context__.SourceCodeLine = 60;
    _115 (  __context__ , "fnCiscoSwitch_CreateCmdfromTables g_MessageHandlerComms.connectState", Functions.ItoA( (int)( _71._69 ) )) ; 
    __context__.SourceCodeLine = 61;
    _108 = (ushort) ( 65535 ) ; 
    __context__.SourceCodeLine = 61;
    _161 = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 61;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _71._69 >= 5 ))  ) ) 
        { 
        __context__.SourceCodeLine = 61;
        _158 = (ushort) ( _157 ) ; 
        __context__.SourceCodeLine = 61;
        while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _158 <= 1500 ))  ) ) 
            { 
            __context__.SourceCodeLine = 61;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_107[ _158 ] != _106[ _158 ]))  ) ) 
                { 
                __context__.SourceCodeLine = 61;
                _161 = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 61;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _158 < 404 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 61;
                    ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                    ushort __FN_FOREND_VAL__1 = (ushort)404; 
                    int __FN_FORSTEP_VAL__1 = (int)1; 
                    for ( _159  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_159  >= __FN_FORSTART_VAL__1) && (_159  <= __FN_FOREND_VAL__1) ) : ( (_159  <= __FN_FORSTART_VAL__1) && (_159  >= __FN_FOREND_VAL__1) ) ; _159  += (ushort)__FN_FORSTEP_VAL__1) 
                        { 
                        __context__.SourceCodeLine = 61;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_107[ _159 ] != _106[ _159 ]) ) && Functions.TestForTrue ( Functions.BoolToInt (_106[ _158 ] == _106[ _159 ]) )) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 61;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_163 != ""))  ) ) 
                                {
                                __context__.SourceCodeLine = 61;
                                _163  .UpdateValue ( _163 + "," + Functions.ItoA (  (int) ( _159 ) )  ) ; 
                                }
                            
                            else 
                                {
                                __context__.SourceCodeLine = 61;
                                _163  .UpdateValue ( Functions.ItoA (  (int) ( _159 ) )  ) ; 
                                }
                            
                            __context__.SourceCodeLine = 61;
                            _107 [ _159 ]  .UpdateValue ( _106 [ _159 ]  ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 61;
                        } 
                    
                    __context__.SourceCodeLine = 61;
                    _148 (  __context__ , (ushort)( Functions.Atoi( _107[ _158 ] ) ), _163) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 61;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _158 > (404 + 1) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _158 < 1380 ) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 61;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _158 >= 500 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _158 < 610 ) )) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 61;
                            _162 = (ushort) ( 1 ) ; 
                            __context__.SourceCodeLine = 61;
                            _160 = (ushort) ( (_158 - 500) ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 61;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _158 >= 610 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _158 < 720 ) )) ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 61;
                                _162 = (ushort) ( 2 ) ; 
                                __context__.SourceCodeLine = 61;
                                _160 = (ushort) ( (_158 - 610) ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 61;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _158 >= 720 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _158 < 830 ) )) ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 61;
                                    _162 = (ushort) ( 3 ) ; 
                                    __context__.SourceCodeLine = 61;
                                    _160 = (ushort) ( (_158 - 720) ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 62;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _158 >= 830 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _158 < 940 ) )) ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 62;
                                        _162 = (ushort) ( 4 ) ; 
                                        __context__.SourceCodeLine = 62;
                                        _160 = (ushort) ( (_158 - 830) ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 62;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _158 >= 940 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _158 < 1050 ) )) ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 62;
                                            _162 = (ushort) ( 5 ) ; 
                                            __context__.SourceCodeLine = 62;
                                            _160 = (ushort) ( (_158 - 940) ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 62;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _158 >= 1050 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _158 < 1160 ) )) ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 62;
                                                _162 = (ushort) ( 6 ) ; 
                                                __context__.SourceCodeLine = 62;
                                                _160 = (ushort) ( (_158 - 1050) ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 62;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _158 >= 1160 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _158 < 1270 ) )) ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 62;
                                                    _162 = (ushort) ( 7 ) ; 
                                                    __context__.SourceCodeLine = 62;
                                                    _160 = (ushort) ( (_158 - 1160) ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 62;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _158 >= 1270 ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 62;
                                                        _162 = (ushort) ( 8 ) ; 
                                                        __context__.SourceCodeLine = 62;
                                                        _160 = (ushort) ( (_158 - 1270) ) ; 
                                                        } 
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        __context__.SourceCodeLine = 62;
                        _115 (  __context__ , "fnCiscoSwitch_CreateCmdfromTables index", Functions.ItoA( (int)( _160 ) )) ; 
                        __context__.SourceCodeLine = 62;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _160 > 52 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 62;
                            _160 = (ushort) ( (_160 - 52) ) ; 
                            __context__.SourceCodeLine = 62;
                            _164  .UpdateValue ( "OFF"  ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 62;
                            _164  .UpdateValue ( "ON"  ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 62;
                        _106 [ _158 ]  .UpdateValue ( "0"  ) ; 
                        __context__.SourceCodeLine = 62;
                        _147 (  __context__ , Functions.ItoA( (int)( _162 ) ), Functions.ItoA( (int)( _160 ) ), _164) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 62;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_158 == 1381))  ) ) 
                            { 
                            __context__.SourceCodeLine = 62;
                            _103 = (ushort) ( 65535 ) ; 
                            __context__.SourceCodeLine = 62;
                            _134 (  __context__ , "show vlan", (ushort)( 12 ), "#", (ushort)( 0 ), "") ; 
                            __context__.SourceCodeLine = 62;
                            _106 [ _158 ]  .UpdateValue ( "0"  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 62;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_158 == 1382))  ) ) 
                                { 
                                __context__.SourceCodeLine = 63;
                                _134 (  __context__ , "show vlan", (ushort)( 12 ), "#", (ushort)( 0 ), "") ; 
                                __context__.SourceCodeLine = 63;
                                _106 [ _158 ]  .UpdateValue ( "0"  ) ; 
                                } 
                            
                            }
                        
                        }
                    
                    }
                
                __context__.SourceCodeLine = 63;
                break ; 
                } 
            
            __context__.SourceCodeLine = 63;
            _158 = (ushort) ( (_158 + 1) ) ; 
            __context__.SourceCodeLine = 63;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _158 > 1500 ))  ) ) 
                { 
                __context__.SourceCodeLine = 63;
                if ( Functions.TestForTrue  ( ( _111)  ) ) 
                    { 
                    __context__.SourceCodeLine = 63;
                    _111 = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 63;
                    _158 = (ushort) ( 1 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 63;
                    _98 = (ushort) ( 65535 ) ; 
                    __context__.SourceCodeLine = 63;
                    _108 = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 63;
                    _158 = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 63;
                    break ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 61;
            } 
        
        } 
    
    __context__.SourceCodeLine = 63;
    _115 (  __context__ , "fnCiscoSwitch_CreateCmdfromTables return i", Functions.ItoA( (int)( _158 ) )) ; 
    __context__.SourceCodeLine = 63;
    return (ushort)( _158) ; 
    
    }
    
private void _156 (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 63;
    _115 (  __context__ , "fnTriggerChangedStatus g_processingCmdTable", Functions.ItoA( (int)( _108 ) )) ; 
    __context__.SourceCodeLine = 63;
    if ( Functions.TestForTrue  ( ( _108)  ) ) 
        { 
        __context__.SourceCodeLine = 63;
        _111 = (ushort) ( 65535 ) ; 
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 63;
        _98 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 63;
        if ( Functions.TestForTrue  ( ( _77._76)  ) ) 
            {
            __context__.SourceCodeLine = 63;
            _109 = (ushort) ( _155( __context__ , (ushort)( 1 ) ) ) ; 
            }
        
        } 
    
    
    }
    
private void _157 (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 63;
    _115 (  __context__ , "fnCiscoSwitch_beginOperations ", "fnCiscoSwitch_beginOperations") ; 
    __context__.SourceCodeLine = 63;
    _117 (  __context__ , (ushort)( 6 )) ; 
    __context__.SourceCodeLine = 63;
    _115 (  __context__ , "fnCiscoSwitch_loggedOn", "fnCiscoSwitch_loggedOn") ; 
    __context__.SourceCodeLine = 64;
    _134 (  __context__ , "terminal datadump", (ushort)( 0 ), "#", (ushort)( 0 ), "") ; 
    __context__.SourceCodeLine = 64;
    _134 (  __context__ , "terminal width 512", (ushort)( 0 ), "#", (ushort)( 0 ), "") ; 
    __context__.SourceCodeLine = 64;
    _134 (  __context__ , "configure", (ushort)( 0 ), "#", (ushort)( 0 ), "") ; 
    __context__.SourceCodeLine = 64;
    _134 (  __context__ , "no logging console", (ushort)( 0 ), "#", (ushort)( 0 ), "") ; 
    __context__.SourceCodeLine = 64;
    _134 (  __context__ , "exit", (ushort)( 0 ), "#", (ushort)( 0 ), "") ; 
    __context__.SourceCodeLine = 64;
    if ( Functions.TestForTrue  ( ( _110)  ) ) 
        { 
        __context__.SourceCodeLine = 64;
        _112 = (ushort) ( 65535 ) ; 
        __context__.SourceCodeLine = 64;
        _134 (  __context__ , "show vlan", (ushort)( 12 ), "#", (ushort)( 0 ), "") ; 
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 64;
        _134 (  __context__ , "show vlan", (ushort)( 10 ), "#", (ushort)( 0 ), "") ; 
        } 
    
    
    }
    
private void _158 (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 64;
    if ( Functions.TestForTrue  ( ( _77._73)  ) ) 
        {
        __context__.SourceCodeLine = 64;
        _71 . _70  .UpdateValue ( ""  ) ; 
        }
    
    else 
        {
        __context__.SourceCodeLine = 64;
        _71 . _70  .UpdateValue ( "DEMO "  ) ; 
        }
    
    __context__.SourceCodeLine = 64;
    _77 . _76 = (ushort) ( 65535 ) ; 
    __context__.SourceCodeLine = 64;
    _98 = (ushort) ( 65535 ) ; 
    __context__.SourceCodeLine = 64;
    _117 (  __context__ , (ushort)( 5 )) ; 
    __context__.SourceCodeLine = 64;
    _108 = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 64;
    _109 = (ushort) ( _155( __context__ , (ushort)( 1 ) ) ) ; 
    
    }
    
private void _159 (  SplusExecutionContext __context__ ) 
    { 
    ushort _161 = 0;
    ushort _162 = 0;
    
    CrestronString _163;
    CrestronString _164;
    CrestronString _165;
    CrestronString _166;
    _163  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    _164  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    _165  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5000, this );
    _166  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5000, this );
    
    CrestronString _167;
    CrestronString _168;
    _167  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
    _168  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    
    ushort _169 = 0;
    
    ushort _170 = 0;
    
    ushort [] _171;
    _171  = new ushort[ 17 ];
    
    CrestronString [] _172;
    _172  = new CrestronString[ 17 ];
    for( uint i = 0; i < 17; i++ )
        _172 [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    
    
    __context__.SourceCodeLine = 65;
    _165  .UpdateValue ( _99  ) ; 
    __context__.SourceCodeLine = 65;
    _115 (  __context__ , "checkLicence rxDataMac ", _165) ; 
    __context__.SourceCodeLine = 65;
    while ( Functions.TestForTrue  ( ( Functions.Find( "License Activation is :" , _165 ))  ) ) 
        {
        __context__.SourceCodeLine = 65;
        _166  .UpdateValue ( Functions.Remove ( "License Activation is :" , _165 )  ) ; 
        __context__.SourceCodeLine = 65;
        }
    
    __context__.SourceCodeLine = 65;
    _115 (  __context__ , "checkLicence rxDataMac1 ", _165) ; 
    __context__.SourceCodeLine = 65;
    _165  .UpdateValue ( Functions.Remove ( "\u000D" , _165 )  ) ; 
    __context__.SourceCodeLine = 65;
    _115 (  __context__ , "checkLicence rxDataMac2 ", _165) ; 
    __context__.SourceCodeLine = 65;
    _167  .UpdateValue ( Functions.Left ( _165 ,  (int) ( (Functions.Length( _165 ) - 1) ) )  ) ; 
    __context__.SourceCodeLine = 65;
    CRESTRONID__DOLLAR__  .UpdateValue ( _165  ) ; 
    __context__.SourceCodeLine = 65;
    _170 = (ushort) ( 16 ) ; 
    __context__.SourceCodeLine = 65;
    _169 = (ushort) ( _58( __context__ , P_SWITCHLICENCEKEY  , (ushort)( _170 ) , ref _171 , ref _172 ) ) ; 
    __context__.SourceCodeLine = 65;
    ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
    ushort __FN_FOREND_VAL__1 = (ushort)_169; 
    int __FN_FORSTEP_VAL__1 = (int)1; 
    for ( _162  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_162  >= __FN_FORSTART_VAL__1) && (_162  <= __FN_FOREND_VAL__1) ) : ( (_162  <= __FN_FORSTART_VAL__1) && (_162  >= __FN_FOREND_VAL__1) ) ; _162  += (ushort)__FN_FORSTEP_VAL__1) 
        { 
        __context__.SourceCodeLine = 65;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_171[ _162 ] == 6))  ) ) 
            { 
            __context__.SourceCodeLine = 65;
            _163  .UpdateValue ( _59 (  __context__ , _172[ _162 ])  ) ; 
            __context__.SourceCodeLine = 65;
            _164  .UpdateValue ( _59 (  __context__ , _167)  ) ; 
            __context__.SourceCodeLine = 65;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_164 == _163))  ) ) 
                {
                __context__.SourceCodeLine = 65;
                _77 . _73 = (ushort) ( 65535 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 65;
                _77 . _73 = (ushort) ( 0 ) ; 
                }
            
            __context__.SourceCodeLine = 65;
            break ; 
            } 
        
        __context__.SourceCodeLine = 65;
        } 
    
    __context__.SourceCodeLine = 65;
    if ( Functions.TestForTrue  ( ( _77._73)  ) ) 
        { 
        __context__.SourceCodeLine = 66;
        _77 . _73 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 66;
        ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__2 = (ushort)_169; 
        int __FN_FORSTEP_VAL__2 = (int)1; 
        for ( _162  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (_162  >= __FN_FORSTART_VAL__2) && (_162  <= __FN_FOREND_VAL__2) ) : ( (_162  <= __FN_FORSTART_VAL__2) && (_162  >= __FN_FOREND_VAL__2) ) ; _162  += (ushort)__FN_FORSTEP_VAL__2) 
            { 
            __context__.SourceCodeLine = 66;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_171[ _162 ] == 4))  ) ) 
                { 
                __context__.SourceCodeLine = 66;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_172[ _162 ] == "JADDriver"))  ) ) 
                    {
                    __context__.SourceCodeLine = 66;
                    _77 . _73 = (ushort) ( 65535 ) ; 
                    }
                
                __context__.SourceCodeLine = 66;
                break ; 
                } 
            
            __context__.SourceCodeLine = 66;
            } 
        
        } 
    
    __context__.SourceCodeLine = 66;
    if ( Functions.TestForTrue  ( ( _77._73)  ) ) 
        {
        __context__.SourceCodeLine = 66;
        _97  .UpdateValue ( ""  ) ; 
        }
    
    else 
        {
        __context__.SourceCodeLine = 66;
        _97  .UpdateValue ( "Demo"  ) ; 
        }
    
    __context__.SourceCodeLine = 66;
    MakeString ( _168 , "numberOfRX={0:d} g_numberOfTX= {1:d}", (short)_90, (short)_89) ; 
    __context__.SourceCodeLine = 66;
    _115 (  __context__ , "checkLicence", _168) ; 
    __context__.SourceCodeLine = 66;
    _77 . _74 = (ushort) ( _89 ) ; 
    __context__.SourceCodeLine = 66;
    _77 . _75 = (ushort) ( _90 ) ; 
    __context__.SourceCodeLine = 66;
    _96 = (ushort) ( (_89 + _90) ) ; 
    __context__.SourceCodeLine = 66;
    NUMOFINPUTS  .Value = (ushort) ( _77._74 ) ; 
    __context__.SourceCodeLine = 66;
    NUMOFOUTPUTS  .Value = (ushort) ( _77._75 ) ; 
    __context__.SourceCodeLine = 66;
    _157 (  __context__  ) ; 
    
    }
    
private ushort _160 (  SplusExecutionContext __context__, CrestronString _162 ) 
    { 
    ushort _163 = 0;
    ushort _164 = 0;
    ushort _165 = 0;
    ushort _166 = 0;
    ushort IPORT = 0;
    ushort IOUTPUT = 0;
    ushort ISWITCH = 0;
    ushort _2 = 0;
    ushort IEXPECTEDINPUTS = 0;
    ushort IEXPECTEDOUTPUTS = 0;
    ushort IPROCESSINGVLANID = 0;
    ushort I = 0;
    ushort J = 0;
    ushort CONFIGOK = 0;
    
    short _167 = 0;
    short _168 = 0;
    short _169 = 0;
    short _170 = 0;
    short _171 = 0;
    short [,] IPORTSTATUS;
    short IVLANID = 0;
    IPORTSTATUS  = new short[ 9,53 ];
    
    CrestronString _172;
    CrestronString [] _173;
    CrestronString _174;
    CrestronString _175;
    CrestronString TEMP;
    CrestronString TRASH;
    CrestronString [] SPREFIXES;
    _172  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64000, this );
    _174  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
    _175  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    TEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
    TRASH  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
    _173  = new CrestronString[ 101 ];
    for( uint i = 0; i < 101; i++ )
        _173 [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    SPREFIXES  = new CrestronString[ 501 ];
    for( uint i = 0; i < 501; i++ )
        SPREFIXES [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
    
    _0 _176;
    _176  = new _0( this, true );
    _176 .PopulateCustomAttributeList( false );
    
    
    __context__.SourceCodeLine = 67;
    _170 = (short) ( 0 ) ; 
    __context__.SourceCodeLine = 67;
    _171 = (short) ( 0 ) ; 
    __context__.SourceCodeLine = 67;
    short __FN_FORSTART_VAL__1 = (short) ( 0 ) ;
    short __FN_FOREND_VAL__1 = (short)8; 
    int __FN_FORSTEP_VAL__1 = (int)1; 
    for ( _169  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_169  >= __FN_FORSTART_VAL__1) && (_169  <= __FN_FOREND_VAL__1) ) : ( (_169  <= __FN_FORSTART_VAL__1) && (_169  >= __FN_FOREND_VAL__1) ) ; _169  += (short)__FN_FORSTEP_VAL__1) 
        { 
        __context__.SourceCodeLine = 67;
        ushort __FN_FORSTART_VAL__2 = (ushort) ( 0 ) ;
        ushort __FN_FOREND_VAL__2 = (ushort)52; 
        int __FN_FORSTEP_VAL__2 = (int)1; 
        for ( J  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (J  >= __FN_FORSTART_VAL__2) && (J  <= __FN_FOREND_VAL__2) ) : ( (J  <= __FN_FORSTART_VAL__2) && (J  >= __FN_FOREND_VAL__2) ) ; J  += (ushort)__FN_FORSTEP_VAL__2) 
            {
            __context__.SourceCodeLine = 67;
            IPORTSTATUS [ _169 , J] = (short) ( 0 ) ; 
            __context__.SourceCodeLine = 67;
            }
        
        __context__.SourceCodeLine = 67;
        } 
    
    __context__.SourceCodeLine = 67;
    _169 = (short) ( 1 ) ; 
    __context__.SourceCodeLine = 67;
    IPROCESSINGVLANID = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 67;
    _166 = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 67;
    _115 (  __context__ , "CiscoSwitch__parseShowVlan - vlanMessage", _162) ; 
    __context__.SourceCodeLine = 67;
    while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\r\n" , _162 , 1 ) > 0 ))  ) ) 
        { 
        __context__.SourceCodeLine = 67;
        _174  .UpdateValue ( Functions.Remove ( "\r\n" , _162 , 1)  ) ; 
        __context__.SourceCodeLine = 67;
        _115 (  __context__ , "CiscoSwitch__parseShowVlan row ", _174) ; 
        __context__.SourceCodeLine = 67;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_174 != ""))  ) ) 
            { 
            __context__.SourceCodeLine = 67;
            _167 = (short) ( Functions.ToSignedInteger( -( 1 ) ) ) ; 
            __context__.SourceCodeLine = 67;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _167 < 2 ))  ) ) 
                { 
                __context__.SourceCodeLine = 67;
                while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( _174 ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 67;
                    _164 = (ushort) ( Byte( _174 , (int)( 1 ) ) ) ; 
                    __context__.SourceCodeLine = 67;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_164 == 32))  ) ) 
                        {
                        __context__.SourceCodeLine = 67;
                        TRASH  .UpdateValue ( Functions.Remove ( " " , _174 , 1)  ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 67;
                        break ; 
                        }
                    
                    __context__.SourceCodeLine = 67;
                    } 
                
                __context__.SourceCodeLine = 68;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( _174 ) == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 68;
                    break ; 
                    }
                
                __context__.SourceCodeLine = 68;
                _167 = (short) ( (_167 + 1) ) ; 
                __context__.SourceCodeLine = 68;
                _165 = (ushort) ( Functions.Find( " " , _174 , 1 ) ) ; 
                __context__.SourceCodeLine = 68;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_165 == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 68;
                    _165 = (ushort) ( Functions.Length( _174 ) ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 68;
                    _165 = (ushort) ( (_165 - 1) ) ; 
                    }
                
                __context__.SourceCodeLine = 68;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_165 == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 68;
                    _173 [ _167 ]  .UpdateValue ( ""  ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 68;
                    _173 [ _167 ]  .UpdateValue ( Functions.Remove ( _165, _174 )  ) ; 
                    }
                
                __context__.SourceCodeLine = 67;
                } 
            
            __context__.SourceCodeLine = 68;
            _115 (  __context__ , "CiscoSwitch__parseShowVlan icol ", Functions.ItoA( (int)( _167 ) )) ; 
            __context__.SourceCodeLine = 68;
            _115 (  __context__ , "CiscoSwitch__parseShowVlan col[0] ", _173[ 0 ]) ; 
            __context__.SourceCodeLine = 68;
            _115 (  __context__ , "CiscoSwitch__parseShowVlan col[1] ", _173[ 1 ]) ; 
            __context__.SourceCodeLine = 68;
            _115 (  __context__ , "CiscoSwitch__parseShowVlan col[2] ", _173[ 2 ]) ; 
            __context__.SourceCodeLine = 68;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_167 == 2))  ) ) 
                { 
                __context__.SourceCodeLine = 68;
                IVLANID = (short) ( Functions.Atoi( _173[ 0 ] ) ) ; 
                __context__.SourceCodeLine = 68;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (IVLANID == 2) ) && Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Left( _173[ 1 ] , (int)( 1 ) ) == "2") ) || Functions.TestForTrue ( Functions.BoolToInt (_173[ 1 ] == "CONTROL") )) ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 68;
                    _166 = (ushort) ( (_166 | 1) ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 69;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (IVLANID == 10) ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Left( _173[ 1 ] , (int)( 4 ) ) == "JAP_") )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 69;
                        _2 = (ushort) ( _38( __context__ , _173[ 1 ] , (short)( 1 ) , "JAP_(%d+)x(%d+)" , ref _176 ) ) ; 
                        __context__.SourceCodeLine = 69;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _2 <= 1 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 69;
                            _115 (  __context__ , "CiscoSwitch__parseShowVlan", "Failed to find JAP inter-VLAN routing VLAN") ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 69;
                            IEXPECTEDINPUTS = (ushort) ( Functions.Atoi( _116( __context__ , _173[ 1 ] , (ushort)( _176._3[ 1 ] ) , (ushort)( _176._4[ 1 ] ) ) ) ) ; 
                            __context__.SourceCodeLine = 69;
                            IEXPECTEDOUTPUTS = (ushort) ( Functions.Atoi( _116( __context__ , _173[ 1 ] , (ushort)( _176._3[ 2 ] ) , (ushort)( _176._4[ 2 ] ) ) ) ) ; 
                            __context__.SourceCodeLine = 69;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( IEXPECTEDINPUTS > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( IEXPECTEDOUTPUTS > 0 ) )) ))  ) ) 
                                {
                                __context__.SourceCodeLine = 69;
                                _166 = (ushort) ( (_166 | 2) ) ; 
                                }
                            
                            else 
                                {
                                __context__.SourceCodeLine = 69;
                                _115 (  __context__ , "CiscoSwitch__parseShowVlan", "Invalid input/output count in JAP routing VLAN") ; 
                                }
                            
                            } 
                        
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 69;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( IVLANID >= 11 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( IVLANID <= 404 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Left( _173[ 1 ] , (int)( 3 ) ) == "TX_") ) || Functions.TestForTrue ( Functions.BoolToInt (Functions.Left( _173[ 1 ] , (int)( 12 ) ) == "TRANSMITTER_") )) ) )) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 70;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( _173[ 1 ] , (int)( 12 ) ) == "TRANSMITTER_"))  ) ) 
                                { 
                                __context__.SourceCodeLine = 70;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _38( __context__ , _173[ 2 ] , (short)( 1 ) , "gi(%d*)/?(%d*)" , ref _176 ) <= 2 ))  ) ) 
                                    { 
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 70;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _176._4[ 2 ] > _176._3[ 2 ] ))  ) ) 
                                        {
                                        __context__.SourceCodeLine = 70;
                                        IPORT = (ushort) ( Functions.Atoi( _116( __context__ , _173[ 2 ] , (ushort)( _176._3[ 2 ] ) , (ushort)( _176._4[ 2 ] ) ) ) ) ; 
                                        }
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 70;
                                        IPORT = (ushort) ( Functions.Atoi( _116( __context__ , _173[ 2 ] , (ushort)( _176._3[ 1 ] ) , (ushort)( _176._4[ 1 ] ) ) ) ) ; 
                                        }
                                    
                                    __context__.SourceCodeLine = 70;
                                    _115 (  __context__ , "CiscoSwitch__parseShowVlan col[2]", _173[ 2 ]) ; 
                                    __context__.SourceCodeLine = 70;
                                    _115 (  __context__ , "CiscoSwitch__parseShowVlan results.start[1]", Functions.ItoA( (int)( _176._3[ 1 ] ) )) ; 
                                    __context__.SourceCodeLine = 70;
                                    _115 (  __context__ , "CiscoSwitch__parseShowVlan results.end[1]", Functions.ItoA( (int)( _176._4[ 1 ] ) )) ; 
                                    __context__.SourceCodeLine = 71;
                                    _115 (  __context__ , "CiscoSwitch__parseShowVlan results.start[2]", Functions.ItoA( (int)( _176._3[ 2 ] ) )) ; 
                                    __context__.SourceCodeLine = 71;
                                    _115 (  __context__ , "CiscoSwitch__parseShowVlan results.end[2]", Functions.ItoA( (int)( _176._4[ 2 ] ) )) ; 
                                    __context__.SourceCodeLine = 71;
                                    _115 (  __context__ , "CiscoSwitch__parseShowVlan iPort", Functions.ItoA( (int)( IPORT ) )) ; 
                                    __context__.SourceCodeLine = 71;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IPORT <= 0 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 71;
                                        _115 (  __context__ , "CiscoSwitch__parseShowVlan", "Invalid port name in TX VLAN name") ; 
                                        } 
                                    
                                    else 
                                        { 
                                        __context__.SourceCodeLine = 71;
                                        IPORTSTATUS [ 0 , IPORT] = (short) ( Functions.ToSignedInteger( -( IVLANID ) ) ) ; 
                                        __context__.SourceCodeLine = 71;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IPORT > IPORTSTATUS[ 0 , 0 ] ))  ) ) 
                                            {
                                            __context__.SourceCodeLine = 71;
                                            IPORTSTATUS [ 0 , 0] = (short) ( IPORT ) ; 
                                            }
                                        
                                        __context__.SourceCodeLine = 71;
                                        _170 = (short) ( (_170 + 1) ) ; 
                                        } 
                                    
                                    } 
                                
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 71;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _38( __context__ , _173[ 1 ] , (short)( 1 ) , "TX_%d+_gi(%d*)/?(%d*)/?(%d*)" , ref _176 ) <= 1 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 72;
                                    _115 (  __context__ , "CiscoSwitch__parseShowVlan", "TX VLAN name with unexpected format") ; 
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 72;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _176._4[ 3 ] > _176._3[ 3 ] ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 72;
                                        ISWITCH = (ushort) ( (Functions.Atoi( _116( __context__ , _173[ 1 ] , (ushort)( _176._3[ 1 ] ) , (ushort)( _176._4[ 1 ] ) ) ) - 1) ) ; 
                                        __context__.SourceCodeLine = 72;
                                        IPORT = (ushort) ( Functions.Atoi( _116( __context__ , _173[ 1 ] , (ushort)( _176._3[ 3 ] ) , (ushort)( _176._4[ 3 ] ) ) ) ) ; 
                                        } 
                                    
                                    else 
                                        { 
                                        __context__.SourceCodeLine = 72;
                                        ISWITCH = (ushort) ( 0 ) ; 
                                        __context__.SourceCodeLine = 72;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _176._4[ 2 ] > _176._3[ 2 ] ))  ) ) 
                                            {
                                            __context__.SourceCodeLine = 72;
                                            IPORT = (ushort) ( Functions.Atoi( _116( __context__ , _173[ 1 ] , (ushort)( _176._3[ 2 ] ) , (ushort)( _176._4[ 2 ] ) ) ) ) ; 
                                            }
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 72;
                                            IPORT = (ushort) ( Functions.Atoi( _116( __context__ , _173[ 1 ] , (ushort)( _176._3[ 1 ] ) , (ushort)( _176._4[ 1 ] ) ) ) ) ; 
                                            }
                                        
                                        } 
                                    
                                    __context__.SourceCodeLine = 72;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( IPORT < 1 ) ) || Functions.TestForTrue ( Functions.BoolToInt ( IPORT > 52 ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( ISWITCH < 0 ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( ISWITCH >= 8 ) )) ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 72;
                                        _115 (  __context__ , "CiscoSwitch__parseShowVlan", "TX VLAN name with invalid port name") ; 
                                        } 
                                    
                                    else 
                                        { 
                                        __context__.SourceCodeLine = 72;
                                        IPORTSTATUS [ ISWITCH , IPORT] = (short) ( Functions.ToSignedInteger( -( IVLANID ) ) ) ; 
                                        __context__.SourceCodeLine = 73;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IPORT > IPORTSTATUS[ ISWITCH , 0 ] ))  ) ) 
                                            {
                                            __context__.SourceCodeLine = 73;
                                            IPORTSTATUS [ ISWITCH , 0] = (short) ( IPORT ) ; 
                                            }
                                        
                                        __context__.SourceCodeLine = 73;
                                        _170 = (short) ( (_170 + 1) ) ; 
                                        } 
                                    
                                    } 
                                
                                }
                            
                            __context__.SourceCodeLine = 73;
                            _171 = (short) ( (_171 + _144( __context__ , _173[ 2 ] , (short)( IVLANID ) , (short[,])( IPORTSTATUS ) , ref SPREFIXES )) ) ; 
                            __context__.SourceCodeLine = 73;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Right( _173[ 2 ] , (int)( 1 ) ) == ","))  ) ) 
                                {
                                __context__.SourceCodeLine = 73;
                                IPROCESSINGVLANID = (ushort) ( IVLANID ) ; 
                                }
                            
                            else 
                                {
                                __context__.SourceCodeLine = 73;
                                IPROCESSINGVLANID = (ushort) ( 0 ) ; 
                                }
                            
                            __context__.SourceCodeLine = 73;
                            _166 = (ushort) ( (_166 | 4) ) ; 
                            } 
                        
                        }
                    
                    }
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 73;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _167 > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( IPROCESSINGVLANID > 0 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Left( _173[ 0 ] , (int)( 2 ) ) == "gi") )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 73;
                    _171 = (short) ( (_171 + _144( __context__ , _173[ 0 ] , (short)( IPROCESSINGVLANID ) , (short[,])( IPORTSTATUS ) , ref SPREFIXES )) ) ; 
                    __context__.SourceCodeLine = 73;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Right( _173[ 0 ] , (int)( 1 ) ) != ","))  ) ) 
                        {
                        __context__.SourceCodeLine = 73;
                        IPROCESSINGVLANID = (ushort) ( 0 ) ; 
                        }
                    
                    } 
                
                }
            
            } 
        
        __context__.SourceCodeLine = 67;
        } 
    
    __context__.SourceCodeLine = 73;
    _115 (  __context__ , "CiscoSwitch__parseShowVlan iNumberOfInputs = ", Functions.ItoA( (int)( _170 ) )) ; 
    __context__.SourceCodeLine = 74;
    _115 (  __context__ , "CiscoSwitch__parseShowVlan iNumberOfOutputs = ", Functions.ItoA( (int)( _171 ) )) ; 
    __context__.SourceCodeLine = 74;
    CONFIGOK = (ushort) ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_166 == 7) ) && Functions.TestForTrue ( Functions.BoolToInt (_170 == IEXPECTEDINPUTS) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (_171 == IEXPECTEDOUTPUTS) )) ) ) ; 
    __context__.SourceCodeLine = 74;
    if ( Functions.TestForTrue  ( ( Functions.Not( CONFIGOK ))  ) ) 
        { 
        __context__.SourceCodeLine = 74;
        _115 (  __context__ , "CiscoSwitch__parseShowVlan", "Invalid configuration (missing VLANs or unexpected number or inputs or outputs)") ; 
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 74;
        _102 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 74;
        IOUTPUT = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 74;
        _89 = (ushort) ( _170 ) ; 
        __context__.SourceCodeLine = 74;
        _90 = (ushort) ( _171 ) ; 
        __context__.SourceCodeLine = 74;
        ushort __FN_FORSTART_VAL__3 = (ushort) ( 0 ) ;
        ushort __FN_FOREND_VAL__3 = (ushort)8; 
        int __FN_FORSTEP_VAL__3 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__3; (__FN_FORSTEP_VAL__3 > 0)  ? ( (I  >= __FN_FORSTART_VAL__3) && (I  <= __FN_FOREND_VAL__3) ) : ( (I  <= __FN_FORSTART_VAL__3) && (I  >= __FN_FOREND_VAL__3) ) ; I  += (ushort)__FN_FORSTEP_VAL__3) 
            { 
            __context__.SourceCodeLine = 74;
            ushort __FN_FORSTART_VAL__4 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__4 = (ushort)IPORTSTATUS[ I , 0 ]; 
            int __FN_FORSTEP_VAL__4 = (int)1; 
            for ( J  = __FN_FORSTART_VAL__4; (__FN_FORSTEP_VAL__4 > 0)  ? ( (J  >= __FN_FORSTART_VAL__4) && (J  <= __FN_FOREND_VAL__4) ) : ( (J  <= __FN_FORSTART_VAL__4) && (J  >= __FN_FOREND_VAL__4) ) ; J  += (ushort)__FN_FORSTEP_VAL__4) 
                { 
                __context__.SourceCodeLine = 74;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IPORTSTATUS[ I , J ] > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 74;
                    MakeString ( TEMP , "{0}{1:d}", SPREFIXES [ I ] , (short)J) ; 
                    __context__.SourceCodeLine = 74;
                    _100 [ IOUTPUT ]  .UpdateValue ( TEMP  ) ; 
                    __context__.SourceCodeLine = 74;
                    MakeString ( TEMP , "g_rxPositionOnStack[{0:d}] = {1}", (short)IOUTPUT, _100 [ IOUTPUT ] ) ; 
                    __context__.SourceCodeLine = 75;
                    _115 (  __context__ , "CiscoSwitch__parseShowVlan  ", TEMP) ; 
                    __context__.SourceCodeLine = 75;
                    OUTPUTFB [ IOUTPUT]  .Value = (ushort) ( (IPORTSTATUS[ I , J ] - 10) ) ; 
                    __context__.SourceCodeLine = 75;
                    _107 [ IOUTPUT ]  .UpdateValue ( Functions.ItoA (  (int) ( (IPORTSTATUS[ I , J ] - 10) ) )  ) ; 
                    __context__.SourceCodeLine = 75;
                    _106 [ IOUTPUT ]  .UpdateValue ( Functions.ItoA (  (int) ( (IPORTSTATUS[ I , J ] - 10) ) )  ) ; 
                    __context__.SourceCodeLine = 75;
                    IOUTPUT = (ushort) ( (IOUTPUT + 1) ) ; 
                    } 
                
                __context__.SourceCodeLine = 74;
                } 
            
            __context__.SourceCodeLine = 74;
            } 
        
        __context__.SourceCodeLine = 75;
        TEMP  .UpdateValue ( _100 [ 1 ]  ) ; 
        __context__.SourceCodeLine = 75;
        _163 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 75;
        do 
            { 
            __context__.SourceCodeLine = 75;
            _165 = (ushort) ( Functions.Find( "/" , TEMP , 1 ) ) ; 
            __context__.SourceCodeLine = 75;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _165 > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 75;
                _163 = (ushort) ( (_163 + 1) ) ; 
                __context__.SourceCodeLine = 75;
                TRASH  .UpdateValue ( Functions.Remove ( "/" , TEMP , 1)  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 75;
                _163 = (ushort) ( (_163 + 1) ) ; 
                __context__.SourceCodeLine = 75;
                TRASH  .UpdateValue ( TEMP  ) ; 
                } 
            
            } 
        while (false == ( Functions.TestForTrue  ( Functions.BoolToInt ( _165 < 1 )) )); 
        __context__.SourceCodeLine = 75;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_163 == 1))  ) ) 
            {
            __context__.SourceCodeLine = 75;
            _101  .UpdateValue ( "SG300"  ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 75;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_163 == 2))  ) ) 
                {
                __context__.SourceCodeLine = 75;
                _101  .UpdateValue ( "SG500-Standalone"  ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 75;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_163 == 3))  ) ) 
                    {
                    __context__.SourceCodeLine = 75;
                    _101  .UpdateValue ( "SG500-Stack"  ) ; 
                    }
                
                }
            
            }
        
        } 
    
    __context__.SourceCodeLine = 75;
    return (ushort)( CONFIGOK) ; 
    
    }
    
private void _161 (  SplusExecutionContext __context__, CrestronString _163 ) 
    { 
    
    __context__.SourceCodeLine = 75;
    if ( Functions.TestForTrue  ( ( _160( __context__ , _163 ))  ) ) 
        { 
        __context__.SourceCodeLine = 75;
        REBOOTINGINPROGRESS  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 76;
        ERRORMSG__DOLLAR__  .UpdateValue ( "NONE"  ) ; 
        __context__.SourceCodeLine = 76;
        _159 (  __context__  ) ; 
        __context__.SourceCodeLine = 76;
        _110 = (ushort) ( 65535 ) ; 
        __context__.SourceCodeLine = 76;
        _158 (  __context__  ) ; 
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 76;
        if ( Functions.TestForTrue  ( ( Functions.Not( _102 ))  ) ) 
            { 
            __context__.SourceCodeLine = 76;
            _102 = (ushort) ( 65535 ) ; 
            __context__.SourceCodeLine = 76;
            REBOOTINGINPROGRESS  .Value = (ushort) ( 65535 ) ; 
            __context__.SourceCodeLine = 76;
            ERRORMSG__DOLLAR__  .UpdateValue ( "The module has detected an unusable configuration on the switch.\r\n\r\n" + "Restoring switch to default configuration.\r\n\r\nThis may take several minutes."  ) ; 
            __context__.SourceCodeLine = 76;
            _134 (  __context__ , "reload", (ushort)( 15 ), "Are you sure you want to continue ? (Y/N)", (ushort)( 19 ), "Try Again Later") ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 76;
            REBOOTINGINPROGRESS  .Value = (ushort) ( 65535 ) ; 
            __context__.SourceCodeLine = 76;
            ERRORMSG__DOLLAR__  .UpdateValue ( "Bad Switch configuration\r\n\r\n Please run JAD CONFIG Again"  ) ; 
            __context__.SourceCodeLine = 76;
            CreateWait ( "__SPLS_TMPVAR__WAITLABEL_2__" , 200 , __SPLS_TMPVAR__WAITLABEL_2___Callback ) ;
            } 
        
        } 
    
    
    }
    
public void __SPLS_TMPVAR__WAITLABEL_2___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 76;
            REBOOTINGINPROGRESS  .Value = (ushort) ( 0 ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

private void _162 (  SplusExecutionContext __context__, CrestronString _164 ) 
    { 
    
    __context__.SourceCodeLine = 77;
    if ( Functions.TestForTrue  ( ( _160( __context__ , _164 ))  ) ) 
        { 
        __context__.SourceCodeLine = 77;
        if ( Functions.TestForTrue  ( ( _103)  ) ) 
            { 
            __context__.SourceCodeLine = 77;
            _103 = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 77;
            _143 (  __context__  ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 77;
            if ( Functions.TestForTrue  ( ( _112)  ) ) 
                { 
                __context__.SourceCodeLine = 77;
                _112 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 77;
                _158 (  __context__  ) ; 
                } 
            
            }
        
        } 
    
    else 
        {
        __context__.SourceCodeLine = 77;
        if ( Functions.TestForTrue  ( ( _112)  ) ) 
            { 
            __context__.SourceCodeLine = 77;
            _102 = (ushort) ( 65535 ) ; 
            __context__.SourceCodeLine = 77;
            _110 = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 77;
            REBOOTINGINPROGRESS  .Value = (ushort) ( 65535 ) ; 
            __context__.SourceCodeLine = 77;
            ERRORMSG__DOLLAR__  .UpdateValue ( "The module has detected an unusable configuration on the switch.\r\n\r\n" + "Restoring switch to default configuration.\r\n\r\nThis may take several minutes."  ) ; 
            __context__.SourceCodeLine = 77;
            _134 (  __context__ , "reload", (ushort)( 15 ), "Are you sure you want to continue ? (Y/N)", (ushort)( 19 ), "Try Again Later") ; 
            } 
        
        }
    
    
    }
    
private void _163 (  SplusExecutionContext __context__, ushort _165 , CrestronString _166 ) 
    { 
    
    __context__.SourceCodeLine = 77;
    _115 (  __context__ , "MsgActionSwitch - ", Functions.ItoA( (int)( _165 ) )) ; 
    __context__.SourceCodeLine = 77;
    
        {
        int __SPLS_TMPVAR__SWTCH_7__ = ((int)_165);
        
            { 
            if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 1) ) ) ) 
                { 
                __context__.SourceCodeLine = 77;
                _131 (  __context__ , _166) ; 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 2) ) ) ) 
                { 
                __context__.SourceCodeLine = 77;
                _130 (  __context__ , _166) ; 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 4) ) ) ) 
                { 
                __context__.SourceCodeLine = 78;
                _129 (  __context__ , _166) ; 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 10) ) ) ) 
                { 
                __context__.SourceCodeLine = 78;
                _161 (  __context__ , _166) ; 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 12) ) ) ) 
                { 
                __context__.SourceCodeLine = 78;
                _162 (  __context__ , _166) ; 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 14) ) ) ) 
                { 
                __context__.SourceCodeLine = 78;
                _157 (  __context__  ) ; 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 15) ) ) ) 
                { 
                __context__.SourceCodeLine = 78;
                _149 (  __context__  ) ; 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 17) ) ) ) 
                { 
                __context__.SourceCodeLine = 78;
                _150 (  __context__  ) ; 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 18) ) ) ) 
                { 
                __context__.SourceCodeLine = 78;
                CreateWait ( "__SPLS_TMPVAR__WAITLABEL_3__" , 2000 , __SPLS_TMPVAR__WAITLABEL_3___Callback ) ;
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 19) ) ) ) 
                { 
                __context__.SourceCodeLine = 78;
                _151 (  __context__  ) ; 
                } 
            
            } 
            
        }
        
    
    
    }
    
public void __SPLS_TMPVAR__WAITLABEL_3___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 78;
            _124 (  __context__  ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

private void _164 (  SplusExecutionContext __context__ ) 
    { 
    ushort _166 = 0;
    ushort _167 = 0;
    
    CrestronString _168;
    _168  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    
    
    __context__.SourceCodeLine = 78;
    _166 = (ushort) ( Functions.Find( "\u0027" , _71._64 , 1 ) ) ; 
    __context__.SourceCodeLine = 78;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _166 > 0 ))  ) ) 
        { 
        __context__.SourceCodeLine = 78;
        _168  .UpdateValue ( Functions.Mid ( _71 . _64 ,  (int) ( 1 ) ,  (int) ( _166 ) )  ) ; 
        __context__.SourceCodeLine = 78;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "#" , _71._64 , 1 ) > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 78;
            _71 . _65 = (ushort) ( (Functions.Length( _71._64 ) - _166) ) ; 
            __context__.SourceCodeLine = 78;
            _71 . _64  .UpdateValue ( Functions.Right ( _71 . _64 ,  (int) ( _71._65 ) )  ) ; 
            } 
        
        } 
    
    
    }
    
private void _165 (  SplusExecutionContext __context__ ) 
    { 
    CrestronString _167;
    _167  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
    
    _78 _168;
    _168  = new _78( this, true );
    _168 .PopulateCustomAttributeList( false );
    
    
    __context__.SourceCodeLine = 78;
    Functions.Pulse ( 10, __TRIGGER_START_HEARTBEAT_OUT ) ; 
    __context__.SourceCodeLine = 78;
    if ( Functions.TestForTrue  ( ( _49( __context__ , ref _87 ))  ) ) 
        { 
        __context__.SourceCodeLine = 78;
        _86 . _79  .UpdateValue ( "NULL STRING"  ) ; 
        __context__.SourceCodeLine = 78;
        if ( Functions.TestForTrue  ( ( _77._76)  ) ) 
            {
            __context__.SourceCodeLine = 79;
            _109 = (ushort) ( _155( __context__ , (ushort)( _109 ) ) ) ; 
            }
        
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 79;
        _120 (  __context__ ,   ref  _168 ) ; 
        __context__.SourceCodeLine = 79;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_168._79 == "NULL STRING"))  ) ) 
            {
            __context__.SourceCodeLine = 79;
            Functions.Pulse ( 5, __TRIGGER_SEND_NEXT_CMD_OUT ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 79;
            _128 (  __context__ , _168) ; 
            }
        
        } 
    
    
    }
    
private ushort _166 (  SplusExecutionContext __context__ ) 
    { 
    ushort _168 = 0;
    ushort _169 = 0;
    ushort _170 = 0;
    ushort _171 = 0;
    
    CrestronString _5;
    _5  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    
    ushort _172 = 0;
    
    CrestronString _173;
    CrestronString _174;
    _173  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10000, this );
    _174  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10000, this );
    
    ushort _175 = 0;
    
    ushort _176 = 0;
    
    
    __context__.SourceCodeLine = 79;
    _115 (  __context__ , "fnMessageHandler_onCommRx g_debugRXCommsCnt ", Functions.ItoA( (int)( _114 ) )) ; 
    __context__.SourceCodeLine = 79;
    _114 = (ushort) ( (_114 + 1) ) ; 
    __context__.SourceCodeLine = 79;
    _175 = (ushort) ( _91 ) ; 
    __context__.SourceCodeLine = 79;
    _164 (  __context__  ) ; 
    __context__.SourceCodeLine = 79;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "**** IDLE TIMEOUT ***\r\n\r\n\r\n" , _71._64 , 1 ) > 0 ))  ) ) 
        { 
        __context__.SourceCodeLine = 79;
        SWITCH_CLIENT .  SocketRxBuf  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 79;
        _168 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 79;
        _124 (  __context__  ) ; 
        __context__.SourceCodeLine = 79;
        _125 (  __context__  ) ; 
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 79;
        _5  .UpdateValue ( _86 . _80  ) ; 
        __context__.SourceCodeLine = 80;
        _115 (  __context__ , "fnMessageHandler_onCommRx ok pattern = ", _5) ; 
        __context__.SourceCodeLine = 80;
        _115 (  __context__ , "fnMessageHandler_onCommRx g_MessageHandlerComms.inputString ", _71._64) ; 
        __context__.SourceCodeLine = 80;
        _115 (  __context__ , "fnMessageHandler_onCommRx g_MessageHandlerComms.inputLength ", Functions.ItoA( (int)( _71._65 ) )) ; 
        __context__.SourceCodeLine = 80;
        _168 = (ushort) ( Functions.Find( _5 , _71._64 ) ) ; 
        __context__.SourceCodeLine = 80;
        _115 (  __context__ , "fnMessageHandler_onCommRx pos ", Functions.ItoA( (int)( _168 ) )) ; 
        __context__.SourceCodeLine = 80;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _168 > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 80;
            _172 = (ushort) ( _86._81 ) ; 
            __context__.SourceCodeLine = 80;
            CreateWait ( "__SPLS_TMPVAR__WAITLABEL_4__" , 10 , __SPLS_TMPVAR__WAITLABEL_4___Callback ) ;
            } 
        
        else 
            {
            __context__.SourceCodeLine = 80;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( _86._82 ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 80;
                _5  .UpdateValue ( _86 . _82  ) ; 
                __context__.SourceCodeLine = 80;
                _168 = (ushort) ( Functions.Find( _5 , _71._64 ) ) ; 
                __context__.SourceCodeLine = 80;
                _115 (  __context__ , "fnMessageHandler_onCommRx fail pos ", Functions.ItoA( (int)( _168 ) )) ; 
                __context__.SourceCodeLine = 80;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _168 > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 80;
                    _172 = (ushort) ( _86._83 ) ; 
                    __context__.SourceCodeLine = 80;
                    if ( Functions.TestForTrue  ( ( _113)  ) ) 
                        { 
                        __context__.SourceCodeLine = 81;
                        _113 = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 81;
                        CancelWait ( "WAIT_FOR_RX_SEND" ) ; 
                        } 
                    
                    } 
                
                } 
            
            }
        
        __context__.SourceCodeLine = 81;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _168 > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 81;
            _170 = (ushort) ( Functions.Find( _86._79 , _71._64 ) ) ; 
            __context__.SourceCodeLine = 81;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _170 > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 81;
                _173  .UpdateValue ( Functions.Mid ( _71 . _64 ,  (int) ( (_170 + Functions.Length( _86._79 )) ) ,  (int) ( (Functions.Length( _71._64 ) - ((_170 + Functions.Length( _86._79 )) - 1)) ) )  ) ; 
                } 
            
            __context__.SourceCodeLine = 81;
            _168 = (ushort) ( ((_168 + Functions.Length( _5 )) - 1) ) ; 
            __context__.SourceCodeLine = 81;
            _174  .UpdateValue ( Functions.Remove ( _168, _71 . _64 )  ) ; 
            __context__.SourceCodeLine = 81;
            _71 . _65 = (ushort) ( (_71._65 - _168) ) ; 
            __context__.SourceCodeLine = 81;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _172 > 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 81;
                _163 (  __context__ , (ushort)( _172 ), _173) ; 
                }
            
            __context__.SourceCodeLine = 81;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_175 == _91))  ) ) 
                {
                __context__.SourceCodeLine = 81;
                Functions.Pulse ( 1, __TRIGGER_SEND_NEXT_CMD_OUT ) ; 
                }
            
            } 
        
        } 
    
    __context__.SourceCodeLine = 81;
    return (ushort)( _168) ; 
    
    }
    
public void __SPLS_TMPVAR__WAITLABEL_4___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 80;
            if ( Functions.TestForTrue  ( ( _113)  ) ) 
                { 
                __context__.SourceCodeLine = 80;
                _113 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 80;
                CancelWait ( "WAIT_FOR_RX_SEND" ) ; 
                } 
            
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

private ushort _167 (  SplusExecutionContext __context__ ) 
    { 
    ushort _169 = 0;
    
    
    __context__.SourceCodeLine = 81;
    _169 = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 81;
    while ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.GetC( _93 ) != 65535))  ) ) 
        {
        __context__.SourceCodeLine = 81;
        _169 = (ushort) ( 65535 ) ; 
        __context__.SourceCodeLine = 81;
        }
    
    __context__.SourceCodeLine = 81;
    return (ushort)( _169) ; 
    
    }
    
private void _168 (  SplusExecutionContext __context__, CrestronString _79 ) 
    { 
    ushort _170 = 0;
    ushort _171 = 0;
    ushort _172 = 0;
    
    CrestronString _173;
    CrestronString _174;
    CrestronString _175;
    CrestronString _176;
    CrestronString _177;
    CrestronString ACTION;
    CrestronString _68;
    CrestronString STACKSWITCHNUMBER;
    _173  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
    _174  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
    _175  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
    _176  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    _177  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    ACTION  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
    _68  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
    STACKSWITCHNUMBER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
    
    
    __context__.SourceCodeLine = 82;
    _115 (  __context__ , "ExtractPOECommand cmd", _79) ; 
    __context__.SourceCodeLine = 82;
    _173  .UpdateValue ( Functions.Remove ( " " , _79 , 1)  ) ; 
    __context__.SourceCodeLine = 82;
    _173  .UpdateValue ( Functions.Left ( _173 ,  (int) ( (Functions.Length( _173 ) - 1) ) )  ) ; 
    __context__.SourceCodeLine = 82;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_173 == "POE"))  ) ) 
        { 
        __context__.SourceCodeLine = 82;
        _170 = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 82;
        while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( ";" , _79 , 1 ) > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 82;
            _176  .UpdateValue ( Functions.Remove ( ";" , _79 , 1)  ) ; 
            __context__.SourceCodeLine = 82;
            _176  .UpdateValue ( Functions.Left ( _176 ,  (int) ( (Functions.Length( _176 ) - 1) ) )  ) ; 
            __context__.SourceCodeLine = 82;
            _177  .UpdateValue ( Functions.Remove ( "=" , _176 , 1)  ) ; 
            __context__.SourceCodeLine = 82;
            _177  .UpdateValue ( Functions.Left ( _177 ,  (int) ( (Functions.Length( _177 ) - 1) ) )  ) ; 
            __context__.SourceCodeLine = 82;
            ACTION  .UpdateValue ( _176  ) ; 
            __context__.SourceCodeLine = 82;
            STACKSWITCHNUMBER  .UpdateValue ( Functions.Remove ( "," , _177 , 1)  ) ; 
            __context__.SourceCodeLine = 82;
            STACKSWITCHNUMBER  .UpdateValue ( Functions.Left ( STACKSWITCHNUMBER ,  (int) ( (Functions.Length( STACKSWITCHNUMBER ) - 1) ) )  ) ; 
            __context__.SourceCodeLine = 82;
            _68  .UpdateValue ( _177  ) ; 
            __context__.SourceCodeLine = 82;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (STACKSWITCHNUMBER != "") ) && Functions.TestForTrue ( Functions.BoolToInt (_68 != "") )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 83;
                
                    {
                    int __SPLS_TMPVAR__SWTCH_8__ = ((int)Functions.Atoi( STACKSWITCHNUMBER ));
                    
                        { 
                        if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 1) ) ) ) 
                            {
                            __context__.SourceCodeLine = 83;
                            _172 = (ushort) ( (500 + Functions.Atoi( _68 )) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 2) ) ) ) 
                            {
                            __context__.SourceCodeLine = 83;
                            _172 = (ushort) ( (610 + Functions.Atoi( _68 )) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 3) ) ) ) 
                            {
                            __context__.SourceCodeLine = 83;
                            _172 = (ushort) ( (720 + Functions.Atoi( _68 )) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 4) ) ) ) 
                            {
                            __context__.SourceCodeLine = 83;
                            _172 = (ushort) ( (830 + Functions.Atoi( _68 )) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 5) ) ) ) 
                            {
                            __context__.SourceCodeLine = 83;
                            _172 = (ushort) ( (940 + Functions.Atoi( _68 )) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 6) ) ) ) 
                            {
                            __context__.SourceCodeLine = 83;
                            _172 = (ushort) ( (1050 + Functions.Atoi( _68 )) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 7) ) ) ) 
                            {
                            __context__.SourceCodeLine = 83;
                            _172 = (ushort) ( (1160 + Functions.Atoi( _68 )) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 8) ) ) ) 
                            {
                            __context__.SourceCodeLine = 83;
                            _172 = (ushort) ( (1270 + Functions.Atoi( _68 )) ) ; 
                            }
                        
                        } 
                        
                    }
                    
                
                __context__.SourceCodeLine = 83;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ACTION == "ON"))  ) ) 
                    { 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 83;
                    _172 = (ushort) ( (_172 + 52) ) ; 
                    } 
                
                __context__.SourceCodeLine = 83;
                _115 (  __context__ , "ExtractPOECommand StackSwitchNumber", STACKSWITCHNUMBER) ; 
                __context__.SourceCodeLine = 83;
                _115 (  __context__ , "ExtractPOECommand index", Functions.ItoA( (int)( _172 ) )) ; 
                __context__.SourceCodeLine = 83;
                _115 (  __context__ , "ExtractPOECommand Action", ACTION) ; 
                __context__.SourceCodeLine = 83;
                _106 [ _172 ]  .UpdateValue ( "1"  ) ; 
                __context__.SourceCodeLine = 83;
                _156 (  __context__  ) ; 
                } 
            
            __context__.SourceCodeLine = 82;
            } 
        
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 83;
        _115 (  __context__ , "ExtractPOECommand", "UNKNOWN COMMAND") ; 
        } 
    
    
    }
    
private void _169 (  SplusExecutionContext __context__, CrestronString _79 ) 
    { 
    ushort _171 = 0;
    ushort _172 = 0;
    ushort _173 = 0;
    ushort _174 = 0;
    ushort _175 = 0;
    
    CrestronString _176;
    CrestronString _177;
    CrestronString _178;
    CrestronString _179;
    CrestronString _180;
    _176  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    _177  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    _178  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
    _179  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
    _180  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    
    
    __context__.SourceCodeLine = 84;
    _171 = (ushort) ( 1 ) ; 
    __context__.SourceCodeLine = 84;
    while ( Functions.TestForTrue  ( ( Functions.BoolToInt (_171 != 0))  ) ) 
        { 
        __context__.SourceCodeLine = 84;
        _171 = (ushort) ( Functions.Find( ";" , _79 , 1 ) ) ; 
        __context__.SourceCodeLine = 84;
        _176  .UpdateValue ( Functions.Remove ( ";" , _79 , 1)  ) ; 
        __context__.SourceCodeLine = 84;
        _176  .UpdateValue ( Functions.Left ( _176 ,  (int) ( (Functions.Length( _176 ) - 1) ) )  ) ; 
        __context__.SourceCodeLine = 84;
        _177  .UpdateValue ( Functions.Remove ( "SW " , _176 , 1)  ) ; 
        __context__.SourceCodeLine = 84;
        _177  .UpdateValue ( Functions.Remove ( "=" , _176 , 1)  ) ; 
        __context__.SourceCodeLine = 84;
        _177  .UpdateValue ( Functions.Left ( _177 ,  (int) ( (Functions.Length( _177 ) - 1) ) )  ) ; 
        __context__.SourceCodeLine = 84;
        _178  .UpdateValue ( _176  ) ; 
        __context__.SourceCodeLine = 84;
        _175 = (ushort) ( Functions.Atoi( _178 ) ) ; 
        __context__.SourceCodeLine = 84;
        _172 = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 84;
        do 
            { 
            __context__.SourceCodeLine = 84;
            _173 = (ushort) ( Functions.Find( "," , _177 , 1 ) ) ; 
            __context__.SourceCodeLine = 84;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _173 > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 84;
                _180  .UpdateValue ( Functions.Remove ( "," , _177 , 1)  ) ; 
                __context__.SourceCodeLine = 84;
                _180  .UpdateValue ( Functions.Left ( _180 ,  (int) ( (Functions.Length( _180 ) - 1) ) )  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 84;
                _180  .UpdateValue ( _177  ) ; 
                } 
            
            __context__.SourceCodeLine = 84;
            _174 = (ushort) ( Functions.Atoi( _180 ) ) ; 
            __context__.SourceCodeLine = 84;
            _115 (  __context__ , "ExtractInputAndOutputForSwitch iOutputPort;", Functions.ItoA( (int)( _174 ) )) ; 
            __context__.SourceCodeLine = 85;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _174 <= _90 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _174 > 0 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _175 <= _89 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _175 > 0 ) )) ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 85;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Not( _77._73 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _175 > 3 ) ) || Functions.TestForTrue ( Functions.BoolToInt ( _174 > 3 ) )) ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 85;
                    _115 (  __context__ , "ExtractInputAndOutputForSwitch", "Cant Process this in demo mode") ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 85;
                    _107 [ _174 ]  .UpdateValue ( "0"  ) ; 
                    __context__.SourceCodeLine = 85;
                    _106 [ _174 ]  .UpdateValue ( _178  ) ; 
                    } 
                
                } 
            
            } 
        while (false == ( Functions.TestForTrue  ( Functions.BoolToInt ( _173 < 1 )) )); 
        __context__.SourceCodeLine = 85;
        _156 (  __context__  ) ; 
        __context__.SourceCodeLine = 84;
        } 
    
    
    }
    
private void _170 (  SplusExecutionContext __context__, ushort _172 , ushort _173 ) 
    { 
    
    __context__.SourceCodeLine = 85;
    _115 (  __context__ , "fnCiscoSwitch_handleSetInput input", Functions.ItoA( (int)( _172 ) )) ; 
    __context__.SourceCodeLine = 85;
    _115 (  __context__ , "fnCiscoSwitch_handleSetInput ioutput", Functions.ItoA( (int)( _173 ) )) ; 
    __context__.SourceCodeLine = 85;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _173 <= _90 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _173 > 0 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _172 <= _89 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _172 > 0 ) )) ) )) ))  ) ) 
        { 
        __context__.SourceCodeLine = 85;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_77._73 == 0) ) && Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _172 > 3 ) ) || Functions.TestForTrue ( Functions.BoolToInt ( _173 > 3 ) )) ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 86;
            _115 (  __context__ , "ExtractInputAndOutputForSwitch", "Cant Process this in demo mode") ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 86;
            _107 [ _173 ]  .UpdateValue ( "0"  ) ; 
            __context__.SourceCodeLine = 86;
            _106 [ _173 ]  .UpdateValue ( Functions.ItoA (  (int) ( _172 ) )  ) ; 
            __context__.SourceCodeLine = 86;
            _156 (  __context__  ) ; 
            } 
        
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 86;
        _115 (  __context__ , "fnCiscoSwitch_handleSetInput ", "Cant Process this in demo mode") ; 
        } 
    
    
    }
    
private void _171 (  SplusExecutionContext __context__, CrestronString _173 ) 
    { 
    ushort _174 = 0;
    
    
    __context__.SourceCodeLine = 86;
    _174 = (ushort) ( 1 ) ; 
    __context__.SourceCodeLine = 86;
    while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _174 < Functions.Length( _173 ) ))  ) ) 
        { 
        __context__.SourceCodeLine = 86;
        Print( "{0}", Functions.Mid ( _173 ,  (int) ( _174 ) ,  (int) ( 100 ) ) ) ; 
        __context__.SourceCodeLine = 86;
        _174 = (ushort) ( (_174 + 100) ) ; 
        __context__.SourceCodeLine = 86;
        } 
    
    
    }
    
object START_MODULE_OnPush_0 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 86;
        _154 (  __context__  ) ; 
        __context__.SourceCodeLine = 86;
        _153 (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object REFRESH_STATUS_OnPush_1 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 86;
        if ( Functions.TestForTrue  ( ( _77._76)  ) ) 
            { 
            __context__.SourceCodeLine = 86;
            _106 [ 1382 ]  .UpdateValue ( "1"  ) ; 
            __context__.SourceCodeLine = 86;
            _156 (  __context__  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 86;
            _115 (  __context__ , "refresh_status", "g_CiscoSwitch.readyForCommands  =  false") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SEND_SAVE_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 86;
        if ( Functions.TestForTrue  ( ( _77._76)  ) ) 
            { 
            __context__.SourceCodeLine = 87;
            _106 [ 1381 ]  .UpdateValue ( "1"  ) ; 
            __context__.SourceCodeLine = 87;
            _156 (  __context__  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 87;
            _115 (  __context__ , "send_save", "g_CiscoSwitch.readyForCommands  =  false") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object POE_CMD_OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 87;
        _168 (  __context__ , POE_CMD) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FAVOUTITE_CMD_OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 87;
        _169 (  __context__ , FAVOUTITE_CMD) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DEBUGENABLE_OnChange_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 87;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DEBUGENABLE == "enable debug"))  ) ) 
            {
            __context__.SourceCodeLine = 87;
            _92 = (ushort) ( 65535 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 87;
            _92 = (ushort) ( 0 ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CRESTRON_MAC_OnChange_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 87;
        _99  .UpdateValue ( _99 + CRESTRON_MAC  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object OUTPUT_OnChange_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort OUTPUTPORT = 0;
        ushort INPUTPORT = 0;
        
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 87;
        OUTPUTPORT = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 87;
        INPUTPORT = (ushort) ( OUTPUT[ OUTPUTPORT ] .UshortValue ) ; 
        __context__.SourceCodeLine = 87;
        _115 (  __context__ , "Output Switching", "") ; 
        __context__.SourceCodeLine = 87;
        _170 (  __context__ , (ushort)( INPUTPORT ), (ushort)( OUTPUTPORT )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SWITCH_CLIENT_OnSocketConnect_8 ( Object __Info__ )

    { 
    SocketEventInfo __SocketInfo__ = (SocketEventInfo)__Info__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SocketInfo__);
        
        __context__.SourceCodeLine = 87;
        _86 . _80  .UpdateValue ( "User Name:"  ) ; 
        __context__.SourceCodeLine = 88;
        _86 . _81 = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 88;
        _86 . _82  .UpdateValue ( "#"  ) ; 
        __context__.SourceCodeLine = 88;
        _86 . _83 = (ushort) ( 14 ) ; 
        __context__.SourceCodeLine = 88;
        _95  .UpdateValue ( "\r\nClient Connect Event. Connected to: " + P_SWITCHIP + "\r\n"  ) ; 
        __context__.SourceCodeLine = 88;
        _115 (  __context__ , "socket", _95) ; 
        __context__.SourceCodeLine = 88;
        _133 (  __context__ , (ushort)( 1 )) ; 
        __context__.SourceCodeLine = 88;
        _48 (  __context__ ,   ref  _87 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SocketInfo__ ); }
    return this;
    
}

object SWITCH_CLIENT_OnSocketDisconnect_9 ( Object __Info__ )

    { 
    SocketEventInfo __SocketInfo__ = (SocketEventInfo)__Info__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SocketInfo__);
        
        __context__.SourceCodeLine = 88;
        _115 (  __context__ , "socket", "\r\nClient DisConnect Event\r\n") ; 
        __context__.SourceCodeLine = 88;
        _133 (  __context__ , (ushort)( 0 )) ; 
        __context__.SourceCodeLine = 88;
        _104 = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SocketInfo__ ); }
    return this;
    
}

object SWITCH_CLIENT_OnSocketStatus_10 ( Object __Info__ )

    { 
    SocketEventInfo __SocketInfo__ = (SocketEventInfo)__Info__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SocketInfo__);
        short STATUS = 0;
        
        
        __context__.SourceCodeLine = 88;
        STATUS = (short) ( __SocketInfo__.SocketStatus ) ; 
        __context__.SourceCodeLine = 88;
        _115 (  __context__ , "The SocketGetStatus returns:", Functions.ItoA( (int)( STATUS ) )) ; 
        __context__.SourceCodeLine = 88;
        _115 (  __context__ , "The MyClient.SocketStatus returns:", Functions.ItoA( (int)( SWITCH_CLIENT.SocketStatus ) )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SocketInfo__ ); }
    return this;
    
}

private void _172 (  SplusExecutionContext __context__ ) 
    { 
    ushort _174 = 0;
    
    
    __context__.SourceCodeLine = 88;
    if ( Functions.TestForTrue  ( ( _88)  ) ) 
        { 
        __context__.SourceCodeLine = 88;
        Functions.Pulse ( 10, __SOCKET_RECEIVE_BUSY ) ; 
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 88;
        _88 = (ushort) ( 65535 ) ; 
        __context__.SourceCodeLine = 89;
        _174 = (ushort) ( Functions.Length( SWITCH_CLIENT.SocketRxBuf ) ) ; 
        __context__.SourceCodeLine = 89;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _174 > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 89;
            _71 . _64  .UpdateValue ( _71 . _64 + Functions.Remove ( _174, SWITCH_CLIENT .  SocketRxBuf )  ) ; 
            __context__.SourceCodeLine = 89;
            _71 . _65 = (ushort) ( (_71._65 + _174) ) ; 
            __context__.SourceCodeLine = 89;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _166( __context__ ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 89;
                } 
            
            } 
        
        __context__.SourceCodeLine = 89;
        _88 = (ushort) ( 0 ) ; 
        } 
    
    
    }
    
object __TRIGGER_PROCESS_SOCKET_RECEIVE_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 89;
        _172 (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object __TRIGGER_SEND_NEXT_CMD_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 89;
        _165 (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object __TRIGGER_HEARTBEAT_OnPush_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 89;
        if ( Functions.TestForTrue  ( ( Functions.Not( _77._76 ))  ) ) 
            {
            __context__.SourceCodeLine = 89;
            _139 (  __context__  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SWITCH_CLIENT_OnSocketReceive_14 ( Object __Info__ )

    { 
    SocketEventInfo __SocketInfo__ = (SocketEventInfo)__Info__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SocketInfo__);
        
        __context__.SourceCodeLine = 89;
        _172 (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SocketInfo__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    ushort _174 = 0;
    
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 89;
        _88 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 89;
        _99  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 89;
        _98 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 89;
        _47 (  __context__ ,   ref  _87 , (ushort)( 1000 )) ; 
        __context__.SourceCodeLine = 89;
        VERSION__DOLLAR__  .UpdateValue ( "V2_08"  ) ; 
        __context__.SourceCodeLine = 89;
        ERRORMSG__DOLLAR__  .UpdateValue ( "NONE"  ) ; 
        __context__.SourceCodeLine = 89;
        _91 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 89;
        _103 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 89;
        _92 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 89;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)1500; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( _174  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_174  >= __FN_FORSTART_VAL__1) && (_174  <= __FN_FOREND_VAL__1) ) : ( (_174  <= __FN_FORSTART_VAL__1) && (_174  >= __FN_FOREND_VAL__1) ) ; _174  += (ushort)__FN_FORSTEP_VAL__1) 
            {
            __context__.SourceCodeLine = 89;
            _106 [ _174 ]  .UpdateValue ( "0"  ) ; 
            __context__.SourceCodeLine = 89;
            }
        
        __context__.SourceCodeLine = 89;
        ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__2 = (ushort)1500; 
        int __FN_FORSTEP_VAL__2 = (int)1; 
        for ( _174  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (_174  >= __FN_FORSTART_VAL__2) && (_174  <= __FN_FOREND_VAL__2) ) : ( (_174  <= __FN_FORSTART_VAL__2) && (_174  >= __FN_FOREND_VAL__2) ) ; _174  += (ushort)__FN_FORSTEP_VAL__2) 
            {
            __context__.SourceCodeLine = 89;
            _107 [ _174 ]  .UpdateValue ( "0"  ) ; 
            __context__.SourceCodeLine = 89;
            }
        
        __context__.SourceCodeLine = 90;
        _111 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 90;
        _104 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 90;
        _108 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 90;
        _109 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 90;
        _110 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 90;
        _114 = (ushort) ( 0 ) ; 
        
        
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
    _94  = new ushort[ 81 ];
    _93  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
    _95  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
    _97  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 32, this );
    _99  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
    _101  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    _100  = new CrestronString[ 405 ];
    for( uint i = 0; i < 405; i++ )
        _100 [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    _106  = new CrestronString[ 1501 ];
    for( uint i = 0; i < 1501; i++ )
        _106 [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
    _107  = new CrestronString[ 1501 ];
    for( uint i = 0; i < 1501; i++ )
        _107 [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
    SWITCH_CLIENT  = new SplusTcpClient ( 64000, this );
    _71  = new _63( this, true );
    _71 .PopulateCustomAttributeList( false );
    _77  = new _72( this, true );
    _77 .PopulateCustomAttributeList( false );
    _86  = new _78( this, true );
    _86 .PopulateCustomAttributeList( false );
    _87  = new _41( this, true );
    _87 .PopulateCustomAttributeList( false );
    _85  = new _78[ 1001 ];
    for( uint i = 0; i < 1001; i++ )
    {
        _85 [i] = new _78( this, true );
        _85 [i].PopulateCustomAttributeList( false );
        
    }
    
    __TRIGGER_SEND_NEXT_CMD = new Crestron.Logos.SplusObjects.DigitalInput( __TRIGGER_SEND_NEXT_CMD__DigitalInput__, this );
    m_DigitalInputList.Add( __TRIGGER_SEND_NEXT_CMD__DigitalInput__, __TRIGGER_SEND_NEXT_CMD );
    
    __TRIGGER_HEARTBEAT = new Crestron.Logos.SplusObjects.DigitalInput( __TRIGGER_HEARTBEAT__DigitalInput__, this );
    m_DigitalInputList.Add( __TRIGGER_HEARTBEAT__DigitalInput__, __TRIGGER_HEARTBEAT );
    
    __TRIGGER_PROCESS_SOCKET_RECEIVE = new Crestron.Logos.SplusObjects.DigitalInput( __TRIGGER_PROCESS_SOCKET_RECEIVE__DigitalInput__, this );
    m_DigitalInputList.Add( __TRIGGER_PROCESS_SOCKET_RECEIVE__DigitalInput__, __TRIGGER_PROCESS_SOCKET_RECEIVE );
    
    REFRESH_STATUS = new Crestron.Logos.SplusObjects.DigitalInput( REFRESH_STATUS__DigitalInput__, this );
    m_DigitalInputList.Add( REFRESH_STATUS__DigitalInput__, REFRESH_STATUS );
    
    START_MODULE = new Crestron.Logos.SplusObjects.DigitalInput( START_MODULE__DigitalInput__, this );
    m_DigitalInputList.Add( START_MODULE__DigitalInput__, START_MODULE );
    
    SEND_SAVE = new Crestron.Logos.SplusObjects.DigitalInput( SEND_SAVE__DigitalInput__, this );
    m_DigitalInputList.Add( SEND_SAVE__DigitalInput__, SEND_SAVE );
    
    __TRIGGER_SEND_NEXT_CMD_OUT = new Crestron.Logos.SplusObjects.DigitalOutput( __TRIGGER_SEND_NEXT_CMD_OUT__DigitalOutput__, this );
    m_DigitalOutputList.Add( __TRIGGER_SEND_NEXT_CMD_OUT__DigitalOutput__, __TRIGGER_SEND_NEXT_CMD_OUT );
    
    __TRIGGER_START_HEARTBEAT_OUT = new Crestron.Logos.SplusObjects.DigitalOutput( __TRIGGER_START_HEARTBEAT_OUT__DigitalOutput__, this );
    m_DigitalOutputList.Add( __TRIGGER_START_HEARTBEAT_OUT__DigitalOutput__, __TRIGGER_START_HEARTBEAT_OUT );
    
    __SOCKET_RECEIVE_BUSY = new Crestron.Logos.SplusObjects.DigitalOutput( __SOCKET_RECEIVE_BUSY__DigitalOutput__, this );
    m_DigitalOutputList.Add( __SOCKET_RECEIVE_BUSY__DigitalOutput__, __SOCKET_RECEIVE_BUSY );
    
    REBOOTINGINPROGRESS = new Crestron.Logos.SplusObjects.DigitalOutput( REBOOTINGINPROGRESS__DigitalOutput__, this );
    m_DigitalOutputList.Add( REBOOTINGINPROGRESS__DigitalOutput__, REBOOTINGINPROGRESS );
    
    OUTPUT = new InOutArray<AnalogInput>( 404, this );
    for( uint i = 0; i < 404; i++ )
    {
        OUTPUT[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( OUTPUT__AnalogSerialInput__ + i, OUTPUT__AnalogSerialInput__, this );
        m_AnalogInputList.Add( OUTPUT__AnalogSerialInput__ + i, OUTPUT[i+1] );
    }
    
    NUMOFOUTPUTS = new Crestron.Logos.SplusObjects.AnalogOutput( NUMOFOUTPUTS__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( NUMOFOUTPUTS__AnalogSerialOutput__, NUMOFOUTPUTS );
    
    NUMOFINPUTS = new Crestron.Logos.SplusObjects.AnalogOutput( NUMOFINPUTS__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( NUMOFINPUTS__AnalogSerialOutput__, NUMOFINPUTS );
    
    OUTPUTFB = new InOutArray<AnalogOutput>( 404, this );
    for( uint i = 0; i < 404; i++ )
    {
        OUTPUTFB[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( OUTPUTFB__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( OUTPUTFB__AnalogSerialOutput__ + i, OUTPUTFB[i+1] );
    }
    
    FAVOUTITE_CMD = new Crestron.Logos.SplusObjects.StringInput( FAVOUTITE_CMD__AnalogSerialInput__, 1000, this );
    m_StringInputList.Add( FAVOUTITE_CMD__AnalogSerialInput__, FAVOUTITE_CMD );
    
    POE_CMD = new Crestron.Logos.SplusObjects.StringInput( POE_CMD__AnalogSerialInput__, 1000, this );
    m_StringInputList.Add( POE_CMD__AnalogSerialInput__, POE_CMD );
    
    DEBUGENABLE = new Crestron.Logos.SplusObjects.StringInput( DEBUGENABLE__AnalogSerialInput__, 50, this );
    m_StringInputList.Add( DEBUGENABLE__AnalogSerialInput__, DEBUGENABLE );
    
    CRESTRON_MAC = new Crestron.Logos.SplusObjects.StringInput( CRESTRON_MAC__AnalogSerialInput__, 200, this );
    m_StringInputList.Add( CRESTRON_MAC__AnalogSerialInput__, CRESTRON_MAC );
    
    OPERATIONFB__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( OPERATIONFB__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( OPERATIONFB__DOLLAR____AnalogSerialOutput__, OPERATIONFB__DOLLAR__ );
    
    CRESTRONID__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CRESTRONID__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CRESTRONID__DOLLAR____AnalogSerialOutput__, CRESTRONID__DOLLAR__ );
    
    VERSION__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( VERSION__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( VERSION__DOLLAR____AnalogSerialOutput__, VERSION__DOLLAR__ );
    
    ERRORMSG__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( ERRORMSG__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( ERRORMSG__DOLLAR____AnalogSerialOutput__, ERRORMSG__DOLLAR__ );
    
    P_SWITCHIP = new StringParameter( P_SWITCHIP__Parameter__, this );
    m_ParameterList.Add( P_SWITCHIP__Parameter__, P_SWITCHIP );
    
    P_SWITCHUSERNAME = new StringParameter( P_SWITCHUSERNAME__Parameter__, this );
    m_ParameterList.Add( P_SWITCHUSERNAME__Parameter__, P_SWITCHUSERNAME );
    
    P_SWITCHPASSWORD = new StringParameter( P_SWITCHPASSWORD__Parameter__, this );
    m_ParameterList.Add( P_SWITCHPASSWORD__Parameter__, P_SWITCHPASSWORD );
    
    P_SWITCHLICENCEKEY = new StringParameter( P_SWITCHLICENCEKEY__Parameter__, this );
    m_ParameterList.Add( P_SWITCHLICENCEKEY__Parameter__, P_SWITCHLICENCEKEY );
    
    WAIT_FOR_RX_SEND_Callback = new WaitFunction( WAIT_FOR_RX_SEND_CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_0___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_0___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_1___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_1___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_2___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_2___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_3___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_3___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_4___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_4___CallbackFn );
    
    START_MODULE.OnDigitalPush.Add( new InputChangeHandlerWrapper( START_MODULE_OnPush_0, false ) );
    REFRESH_STATUS.OnDigitalPush.Add( new InputChangeHandlerWrapper( REFRESH_STATUS_OnPush_1, false ) );
    SEND_SAVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( SEND_SAVE_OnPush_2, false ) );
    POE_CMD.OnSerialChange.Add( new InputChangeHandlerWrapper( POE_CMD_OnChange_3, false ) );
    FAVOUTITE_CMD.OnSerialChange.Add( new InputChangeHandlerWrapper( FAVOUTITE_CMD_OnChange_4, false ) );
    DEBUGENABLE.OnSerialChange.Add( new InputChangeHandlerWrapper( DEBUGENABLE_OnChange_5, false ) );
    CRESTRON_MAC.OnSerialChange.Add( new InputChangeHandlerWrapper( CRESTRON_MAC_OnChange_6, false ) );
    for( uint i = 0; i < 404; i++ )
        OUTPUT[i+1].OnAnalogChange.Add( new InputChangeHandlerWrapper( OUTPUT_OnChange_7, false ) );
        
    SWITCH_CLIENT.OnSocketConnect.Add( new SocketHandlerWrapper( SWITCH_CLIENT_OnSocketConnect_8, false ) );
    SWITCH_CLIENT.OnSocketDisconnect.Add( new SocketHandlerWrapper( SWITCH_CLIENT_OnSocketDisconnect_9, false ) );
    SWITCH_CLIENT.OnSocketStatus.Add( new SocketHandlerWrapper( SWITCH_CLIENT_OnSocketStatus_10, false ) );
    __TRIGGER_PROCESS_SOCKET_RECEIVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( __TRIGGER_PROCESS_SOCKET_RECEIVE_OnPush_11, false ) );
    __TRIGGER_SEND_NEXT_CMD.OnDigitalPush.Add( new InputChangeHandlerWrapper( __TRIGGER_SEND_NEXT_CMD_OnPush_12, false ) );
    __TRIGGER_HEARTBEAT.OnDigitalPush.Add( new InputChangeHandlerWrapper( __TRIGGER_HEARTBEAT_OnPush_13, false ) );
    SWITCH_CLIENT.OnSocketReceive.Add( new SocketHandlerWrapper( SWITCH_CLIENT_OnSocketReceive_14, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_JAP_AVSWITCH_CISCO_V2_08 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction WAIT_FOR_RX_SEND_Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_0___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_1___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_2___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_3___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_4___Callback;


const uint __TRIGGER_SEND_NEXT_CMD__DigitalInput__ = 0;
const uint __TRIGGER_HEARTBEAT__DigitalInput__ = 1;
const uint __TRIGGER_PROCESS_SOCKET_RECEIVE__DigitalInput__ = 2;
const uint REFRESH_STATUS__DigitalInput__ = 3;
const uint START_MODULE__DigitalInput__ = 4;
const uint SEND_SAVE__DigitalInput__ = 5;
const uint FAVOUTITE_CMD__AnalogSerialInput__ = 0;
const uint POE_CMD__AnalogSerialInput__ = 1;
const uint DEBUGENABLE__AnalogSerialInput__ = 2;
const uint CRESTRON_MAC__AnalogSerialInput__ = 3;
const uint OUTPUT__AnalogSerialInput__ = 4;
const uint __TRIGGER_SEND_NEXT_CMD_OUT__DigitalOutput__ = 0;
const uint __TRIGGER_START_HEARTBEAT_OUT__DigitalOutput__ = 1;
const uint __SOCKET_RECEIVE_BUSY__DigitalOutput__ = 2;
const uint REBOOTINGINPROGRESS__DigitalOutput__ = 3;
const uint OPERATIONFB__DOLLAR____AnalogSerialOutput__ = 0;
const uint CRESTRONID__DOLLAR____AnalogSerialOutput__ = 1;
const uint VERSION__DOLLAR____AnalogSerialOutput__ = 2;
const uint ERRORMSG__DOLLAR____AnalogSerialOutput__ = 3;
const uint NUMOFOUTPUTS__AnalogSerialOutput__ = 4;
const uint NUMOFINPUTS__AnalogSerialOutput__ = 5;
const uint OUTPUTFB__AnalogSerialOutput__ = 6;
const uint P_SWITCHIP__Parameter__ = 10;
const uint P_SWITCHUSERNAME__Parameter__ = 11;
const uint P_SWITCHPASSWORD__Parameter__ = 12;
const uint P_SWITCHLICENCEKEY__Parameter__ = 13;

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

[SplusStructAttribute(-1, true, false)]
public class _0 : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public CrestronString  _1;
    
    [SplusStructAttribute(1, false, false)]
    public ushort  _2 = 0;
    
    [SplusStructAttribute(2, false, false)]
    public ushort  [] _3;
    
    [SplusStructAttribute(3, false, false)]
    public ushort  [] _4;
    
    [SplusStructAttribute(4, false, false)]
    public CrestronString  _5;
    
    [SplusStructAttribute(5, false, false)]
    public ushort  _6 = 0;
    
    [SplusStructAttribute(6, false, false)]
    public ushort  _7 = 0;
    
    [SplusStructAttribute(7, false, false)]
    public ushort  _8 = 0;
    
    [SplusStructAttribute(8, false, false)]
    public ushort  _9 = 0;
    
    [SplusStructAttribute(9, false, false)]
    public ushort  [] _10;
    
    [SplusStructAttribute(10, false, false)]
    public short  [] _11;
    
    
    public _0( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        _3  = new ushort[ 11 ];
        _4  = new ushort[ 11 ];
        _10  = new ushort[ 11 ];
        _11  = new short[ 11 ];
        _1  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 80, Owner );
        _5  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, Owner );
        
        
    }
    
}
[SplusStructAttribute(-1, true, false)]
public class _41 : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public ushort  _42 = 0;
    
    [SplusStructAttribute(1, false, false)]
    public ushort  _43 = 0;
    
    [SplusStructAttribute(2, false, false)]
    public ushort  _44 = 0;
    
    
    public _41( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        
        
    }
    
}
[SplusStructAttribute(-1, true, false)]
public class _63 : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public CrestronString  _64;
    
    [SplusStructAttribute(1, false, false)]
    public ushort  _65 = 0;
    
    [SplusStructAttribute(2, false, false)]
    public ushort  _66 = 0;
    
    [SplusStructAttribute(3, false, false)]
    public CrestronString  _67;
    
    [SplusStructAttribute(4, false, false)]
    public ushort  _68 = 0;
    
    [SplusStructAttribute(5, false, false)]
    public ushort  _69 = 0;
    
    [SplusStructAttribute(6, false, false)]
    public CrestronString  _70;
    
    
    public _63( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        _64  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64000, Owner );
        _67  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 15, Owner );
        _70  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 15, Owner );
        
        
    }
    
}
[SplusStructAttribute(-1, true, false)]
public class _72 : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public ushort  _73 = 0;
    
    [SplusStructAttribute(1, false, false)]
    public ushort  _74 = 0;
    
    [SplusStructAttribute(2, false, false)]
    public ushort  _75 = 0;
    
    [SplusStructAttribute(3, false, false)]
    public ushort  _76 = 0;
    
    
    public _72( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        
        
    }
    
}
[SplusStructAttribute(-1, true, false)]
public class _78 : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public CrestronString  _79;
    
    [SplusStructAttribute(1, false, false)]
    public CrestronString  _80;
    
    [SplusStructAttribute(2, false, false)]
    public ushort  _81 = 0;
    
    [SplusStructAttribute(3, false, false)]
    public CrestronString  _82;
    
    [SplusStructAttribute(4, false, false)]
    public ushort  _83 = 0;
    
    [SplusStructAttribute(5, false, false)]
    public CrestronString  _84;
    
    
    public _78( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        _79  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5000, Owner );
        _80  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, Owner );
        _82  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, Owner );
        _84  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, Owner );
        
        
    }
    
}

}
