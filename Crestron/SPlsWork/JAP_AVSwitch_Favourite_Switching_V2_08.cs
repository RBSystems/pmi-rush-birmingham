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

namespace UserModule_JAP_AVSWITCH_FAVOURITE_SWITCHING_V2_08
{
    public class UserModuleClass_JAP_AVSWITCH_FAVOURITE_SWITCHING_V2_08 : SplusObject
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
            
        private void _41 (  SplusExecutionContext __context__, CrestronString _43 , CrestronString _44 ) 
            { 
            
            __context__.SourceCodeLine = 21;
            Print( "\r\nJanus Favourites {0} - {1} \r\n", _43 , _44 ) ; 
            
            }
            
        private CrestronString _42 (  SplusExecutionContext __context__, CrestronString _44 , ushort _3 , ushort _4 ) 
            { 
            ushort _45 = 0;
            
            CrestronString _46;
            _46  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 254, this );
            
            
            __context__.SourceCodeLine = 21;
            _45 = (ushort) ( (_4 - _3) ) ; 
            __context__.SourceCodeLine = 21;
            _46  .UpdateValue ( Functions.Mid ( _44 ,  (int) ( _3 ) ,  (int) ( _45 ) )  ) ; 
            __context__.SourceCodeLine = 21;
            return ( _46 ) ; 
            
            }
            
        private CrestronString _43 (  SplusExecutionContext __context__, CrestronString _45 ) 
            { 
            CrestronString _46;
            _46  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
            
            
            __context__.SourceCodeLine = 21;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "PRO2" , _45 , 1 ) > 0 ) ) || Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "AV2" , _45 , 1 ) > 0 ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "RACK2" , _45 , 1 ) > 0 ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "CP2E" , _45 , 1 ) > 0 ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "MC2E" , _45 , 1 ) > 0 ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "MC2W" , _45 , 1 ) > 0 ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "MP2" , _45 , 1 ) > 0 ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "MP2E" , _45 , 1 ) > 0 ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "QM-RMC" , _45 , 1 ) > 0 ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "QM-RMCRX-BA" , _45 , 1 ) > 0 ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "PAC2" , _45 , 1 ) > 0 ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "PAC2M" , _45 , 1 ) > 0 ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "DIN-AP2" , _45 , 1 ) > 0 ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "IPAC-GL1" , _45 , 1 ) > 0 ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "null" , _45 , 1 ) > 0 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 22;
                _46  .UpdateValue ( "\\NVRAM\\BookMark.txt"  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 22;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Find( "PRO3" , _45 , 1 ) ) || Functions.TestForTrue ( Functions.Find( "AV3" , _45 , 1 ) )) ) ) || Functions.TestForTrue ( Functions.Find( "CP3N" , _45 , 1 ) )) ) ) || Functions.TestForTrue ( Functions.Find( "CP3" , _45 , 1 ) )) ) ) || Functions.TestForTrue ( Functions.Find( "MC3" , _45 , 1 ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 22;
                    _46  .UpdateValue ( "\\NVRAM\\BookMark.txt"  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 22;
                    _46  .UpdateValue ( "UNKNOWN"  ) ; 
                    __context__.SourceCodeLine = 23;
                    _41 (  __context__ , "__fnGetPath", "MODEL UNSUPPORTED") ; 
                    } 
                
                }
            
            __context__.SourceCodeLine = 23;
            return ( _46 ) ; 
            
            }
            
        private void _44 (  SplusExecutionContext __context__, CrestronString _46 ) 
            { 
            
            __context__.SourceCodeLine = 23;
            StartFileOperations ( ) ; 
            __context__.SourceCodeLine = 23;
            FileDelete ( _43 (  __context__ , _46) ) ; 
            __context__.SourceCodeLine = 23;
            EndFileOperations ( ) ; 
            
            }
            
        private CrestronString _45 (  SplusExecutionContext __context__, ushort _47 ) 
            { 
            CrestronString _48;
            _48  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
            
            
            __context__.SourceCodeLine = 23;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _47 < 10 ))  ) ) 
                {
                __context__.SourceCodeLine = 23;
                _48  .UpdateValue ( "0" + Functions.ItoA (  (int) ( _47 ) ) + " "  ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 23;
                _48  .UpdateValue ( Functions.ItoA (  (int) ( _47 ) ) + " "  ) ; 
                }
            
            __context__.SourceCodeLine = 23;
            return ( _48 ) ; 
            
            }
            
        private void _46 (  SplusExecutionContext __context__, ushort _48 , CrestronString _49 , CrestronString _50 ) 
            { 
            short _51 = 0;
            short _52 = 0;
            short _53 = 0;
            
            CrestronString _54;
            CrestronString _55;
            CrestronString _56;
            _54  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5000, this );
            _55  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
            _56  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5000, this );
            
            ushort _57 = 0;
            ushort _58 = 0;
            
            _0 _59;
            _59  = new _0( this, true );
            _59 .PopulateCustomAttributeList( false );
            
            
            __context__.SourceCodeLine = 23;
            _41 (  __context__ , "__fnSendToFileFavourite", _49) ; 
            __context__.SourceCodeLine = 23;
            _41 (  __context__ , "__fnSendToFileFavourite", _45( __context__ , (ushort)( _48 ) )) ; 
            __context__.SourceCodeLine = 23;
            StartFileOperations ( ) ; 
            __context__.SourceCodeLine = 24;
            _51 = (short) ( FileOpen( _43( __context__ , _50 ) ,(ushort) (0 | 16384) ) ) ; 
            __context__.SourceCodeLine = 24;
            _53 = (short) ( ReadSignedInteger( (short)( _51 ) , ref _52 ) ) ; 
            __context__.SourceCodeLine = 24;
            Print( "\r\nread iErrorCode = {0:d}\r\n", (short)_51) ; 
            __context__.SourceCodeLine = 24;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _51 > Functions.ToSignedLongInteger( -( 1 ) ) ))  ) ) 
                { 
                __context__.SourceCodeLine = 24;
                do 
                    { 
                    __context__.SourceCodeLine = 24;
                    FileRead (  (short) ( _51 ) , _54 ,  (ushort) ( 1000 ) ) ; 
                    __context__.SourceCodeLine = 24;
                    _56  .UpdateValue ( _56 + _54  ) ; 
                    __context__.SourceCodeLine = 24;
                    _41 (  __context__ , "__fnSendToFileFavourite sFileBuf", _56) ; 
                    } 
                while (false == ( Functions.TestForTrue  ( FileEOF( (short)( _51 ) )) )); 
                __context__.SourceCodeLine = 24;
                _44 (  __context__ , _50) ; 
                __context__.SourceCodeLine = 24;
                _54  .UpdateValue ( ""  ) ; 
                } 
            
            __context__.SourceCodeLine = 24;
            FileClose (  (short) ( _51 ) ) ; 
            __context__.SourceCodeLine = 24;
            EndFileOperations ( ) ; 
            __context__.SourceCodeLine = 24;
            do 
                { 
                __context__.SourceCodeLine = 24;
                _55  .UpdateValue ( Functions.Remove ( "\r\n" , _56 , 1)  ) ; 
                __context__.SourceCodeLine = 24;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _38( __context__ , _55 , (short)( 1 ) , "FAV(%d+) " , ref _59 ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 24;
                    _58 = (ushort) ( Functions.Atoi( _42( __context__ , _55 , (ushort)( _59._3[ 1 ] ) , (ushort)( _59._4[ 1 ] ) ) ) ) ; 
                    __context__.SourceCodeLine = 24;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_58 == _48))  ) ) 
                        { 
                        __context__.SourceCodeLine = 24;
                        break ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 24;
                        _54  .UpdateValue ( _54 + _55  ) ; 
                        } 
                    
                    } 
                
                } 
            while (false == ( Functions.TestForTrue  ( Functions.BoolToInt ( Functions.Find( "\r\n" , _56 , 1 ) < 1 )) )); 
            __context__.SourceCodeLine = 24;
            _41 (  __context__ , "__fnSendToFileFavourite sDataFile", _54) ; 
            __context__.SourceCodeLine = 25;
            _54  .UpdateValue ( "\r\n" + _54 + _56 + "FAV" + _45 (  __context__ , (ushort)( _48 )) + _49 + "\r\n"  ) ; 
            __context__.SourceCodeLine = 25;
            _41 (  __context__ , "__fnSendToFileFavourite sDataFile", _54) ; 
            __context__.SourceCodeLine = 25;
            StartFileOperations ( ) ; 
            __context__.SourceCodeLine = 25;
            _51 = (short) ( FileOpen( _43( __context__ , _50 ) ,(ushort) (2 | 16384) ) ) ; 
            __context__.SourceCodeLine = 25;
            _53 = (short) ( ReadSignedInteger( (short)( _51 ) , ref _52 ) ) ; 
            __context__.SourceCodeLine = 25;
            Print( "\r\nwrite iErrorCode = {0:d}\r\n", (short)_53) ; 
            __context__.SourceCodeLine = 25;
            _53 = (short) ( FileWrite( (short)( _51 ) , _54 , (ushort)( Functions.Length( _54 ) ) ) ) ; 
            __context__.SourceCodeLine = 25;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _53 > 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 25;
                Print( "Written to file: {0}\r\n", _54 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 25;
                Print( "Written to file: {0:d}\r\n", (short)_53) ; 
                }
            
            __context__.SourceCodeLine = 25;
            FileClose (  (short) ( _51 ) ) ; 
            __context__.SourceCodeLine = 25;
            EndFileOperations ( ) ; 
            
            }
            
        private CrestronString _47 (  SplusExecutionContext __context__, ushort _49 , CrestronString _50 ) 
            { 
            short _51 = 0;
            
            CrestronString _52;
            CrestronString _53;
            CrestronString _54;
            CrestronString _55;
            _52  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5000, this );
            _53  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
            _54  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5000, this );
            _55  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
            
            ushort _56 = 0;
            
            _0 _57;
            _57  = new _0( this, true );
            _57 .PopulateCustomAttributeList( false );
            
            
            __context__.SourceCodeLine = 26;
            StartFileOperations ( ) ; 
            __context__.SourceCodeLine = 26;
            _51 = (short) ( FileOpen( _43( __context__ , _50 ) ,(ushort) (0 | 16384) ) ) ; 
            __context__.SourceCodeLine = 26;
            do 
                { 
                __context__.SourceCodeLine = 26;
                FileRead (  (short) ( _51 ) , _52 ,  (ushort) ( 1000 ) ) ; 
                __context__.SourceCodeLine = 26;
                _54  .UpdateValue ( _54 + _52  ) ; 
                } 
            while (false == ( Functions.TestForTrue  ( FileEOF( (short)( _51 ) )) )); 
            __context__.SourceCodeLine = 26;
            FileClose (  (short) ( _51 ) ) ; 
            __context__.SourceCodeLine = 26;
            do 
                { 
                __context__.SourceCodeLine = 26;
                _53  .UpdateValue ( Functions.Remove ( "\r\n" , _54 , 1)  ) ; 
                __context__.SourceCodeLine = 26;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _38( __context__ , _53 , (short)( 1 ) , "FAV(%d+) " , ref _57 ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 26;
                    _55  .UpdateValue ( _42 (  __context__ , _53, (ushort)( _57._3[ 1 ] ), (ushort)( _57._4[ 1 ] ))  ) ; 
                    __context__.SourceCodeLine = 26;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Atoi( _55 ) == _49))  ) ) 
                        { 
                        __context__.SourceCodeLine = 26;
                        break ; 
                        } 
                    
                    } 
                
                } 
            while (false == ( Functions.TestForTrue  ( Functions.BoolToInt ( Functions.Find( "\r\n" , _54 , 1 ) < 1 )) )); 
            __context__.SourceCodeLine = 26;
            EndFileOperations ( ) ; 
            __context__.SourceCodeLine = 26;
            return ( _53 ) ; 
            
            }
            
        private short _48 (  SplusExecutionContext __context__, CrestronString _50 ) 
            { 
            short _51 = 0;
            
            
            __context__.SourceCodeLine = 26;
            StartFileOperations ( ) ; 
            __context__.SourceCodeLine = 26;
            _51 = (short) ( FileOpen( _43( __context__ , _50 ) ,(ushort) ((8 | 256) | 16384) ) ) ; 
            __context__.SourceCodeLine = 26;
            Print( "\r\nCreate iErrorCode = {0:d}\r\n", (short)_51) ; 
            __context__.SourceCodeLine = 26;
            FileClose (  (short) ( _51 ) ) ; 
            __context__.SourceCodeLine = 27;
            EndFileOperations ( ) ; 
            __context__.SourceCodeLine = 27;
            return (short)( _51) ; 
            
            }
            
        Crestron.Logos.SplusObjects.StringInput PROCESSORTYPE;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_ALL;
        Crestron.Logos.SplusObjects.DigitalInput CLEAR_ALL;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> CREATE_FAVOURITE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> RECALL_FAVOURITE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> OUTPUT;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> INPUT;
        Crestron.Logos.SplusObjects.AnalogInput OUTPUT_NUMBER;
        Crestron.Logos.SplusObjects.AnalogInput INPUT_NUMBER;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> OUTPUTSTATUS;
        Crestron.Logos.SplusObjects.DigitalOutput FAVOURITEFILEERROR;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> OUTPUTFB;
        Crestron.Logos.SplusObjects.StringOutput FAVOURITE_CMD;
        Crestron.Logos.SplusObjects.StringOutput MULTI_SWITCH_CMD;
        ushort [] _49;
        ushort _50 = 0;
        private void _51 (  SplusExecutionContext __context__, CrestronString _53 , CrestronString _54 ) 
            { 
            
            __context__.SourceCodeLine = 27;
            if ( Functions.TestForTrue  ( ( _50)  ) ) 
                { 
                __context__.SourceCodeLine = 27;
                Print( "\r\n {0} - {1} \r\n", _53 , _54 ) ; 
                } 
            
            
            }
            
        private void _52 (  SplusExecutionContext __context__, ushort _54 ) 
            { 
            ushort _55 = 0;
            ushort _56 = 0;
            
            CrestronString _57;
            CrestronString _58;
            _57  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1100, this );
            _58  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1100, this );
            
            
            __context__.SourceCodeLine = 28;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)OUTPUT_NUMBER  .UshortValue; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( _56  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_56  >= __FN_FORSTART_VAL__1) && (_56  <= __FN_FOREND_VAL__1) ) : ( (_56  <= __FN_FORSTART_VAL__1) && (_56  >= __FN_FOREND_VAL__1) ) ; _56  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 28;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_49[ _56 ] == 1))  ) ) 
                    {
                    __context__.SourceCodeLine = 28;
                    _58  .UpdateValue ( _58 + Functions.ItoA (  (int) ( _56 ) ) + ","  ) ; 
                    }
                
                __context__.SourceCodeLine = 28;
                } 
            
            __context__.SourceCodeLine = 28;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( _58 ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 28;
                _58  .UpdateValue ( Functions.Left ( _58 ,  (int) ( (Functions.Length( _58 ) - 1) ) )  ) ; 
                __context__.SourceCodeLine = 28;
                _57  .UpdateValue ( _57 + "SW " + _58 + "=" + Functions.ItoA (  (int) ( _54 ) ) + ";"  ) ; 
                __context__.SourceCodeLine = 28;
                MULTI_SWITCH_CMD  .UpdateValue ( _57  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 28;
                Print( "Nothing Selected") ; 
                } 
            
            
            }
            
        private void _53 (  SplusExecutionContext __context__, ushort _55 ) 
            { 
            ushort _56 = 0;
            ushort _57 = 0;
            
            CrestronString _58;
            CrestronString _59;
            _58  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1100, this );
            _59  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1100, this );
            
            
            __context__.SourceCodeLine = 28;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)INPUT_NUMBER  .UshortValue; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( _56  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_56  >= __FN_FORSTART_VAL__1) && (_56  <= __FN_FOREND_VAL__1) ) : ( (_56  <= __FN_FORSTART_VAL__1) && (_56  >= __FN_FOREND_VAL__1) ) ; _56  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 28;
                _59  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 28;
                ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__2 = (ushort)OUTPUT_NUMBER  .UshortValue; 
                int __FN_FORSTEP_VAL__2 = (int)1; 
                for ( _57  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (_57  >= __FN_FORSTART_VAL__2) && (_57  <= __FN_FOREND_VAL__2) ) : ( (_57  <= __FN_FORSTART_VAL__2) && (_57  >= __FN_FOREND_VAL__2) ) ; _57  += (ushort)__FN_FORSTEP_VAL__2) 
                    { 
                    __context__.SourceCodeLine = 28;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (OUTPUTSTATUS[ _57 ] .UshortValue == _56) ) && Functions.TestForTrue ( Functions.BoolToInt (_49[ _57 ] == 1) )) ))  ) ) 
                        {
                        __context__.SourceCodeLine = 28;
                        _59  .UpdateValue ( _59 + Functions.ItoA (  (int) ( _57 ) ) + ","  ) ; 
                        }
                    
                    __context__.SourceCodeLine = 28;
                    } 
                
                __context__.SourceCodeLine = 28;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( _59 ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 28;
                    _59  .UpdateValue ( Functions.Left ( _59 ,  (int) ( (Functions.Length( _59 ) - 1) ) )  ) ; 
                    __context__.SourceCodeLine = 28;
                    _58  .UpdateValue ( _58 + "SW " + _59 + "=" + Functions.ItoA (  (int) ( _56 ) ) + ";"  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 29;
                    Print( "Nothing Selected") ; 
                    } 
                
                __context__.SourceCodeLine = 28;
                } 
            
            __context__.SourceCodeLine = 29;
            _46 (  __context__ , (ushort)( _55 ), _58, PROCESSORTYPE) ; 
            
            }
            
        object SELECT_ALL_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort I = 0;
                
                
                __context__.SourceCodeLine = 29;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)OUTPUT_NUMBER  .UshortValue; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 29;
                    _49 [ I] = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 29;
                    OUTPUTFB [ I]  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 29;
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object CLEAR_ALL_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 29;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)OUTPUT_NUMBER  .UshortValue; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 29;
                _49 [ I] = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 29;
                OUTPUTFB [ I]  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 29;
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object OUTPUT_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 29;
        I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 29;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( I <= OUTPUT_NUMBER  .UshortValue ))  ) ) 
            { 
            __context__.SourceCodeLine = 29;
            Print( "iSelectedOutputArray[{0:d}] = {1:d} ", (short)I, (short)_49[ I ]) ; 
            __context__.SourceCodeLine = 29;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_49[ I ] == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 29;
                _49 [ I] = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 29;
                OUTPUTFB [ I]  .Value = (ushort) ( _49[ I ] ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 29;
                _49 [ I] = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 29;
                OUTPUTFB [ I]  .Value = (ushort) ( _49[ I ] ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INPUT_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 29;
        I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 29;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( I <= INPUT_NUMBER  .UshortValue ))  ) ) 
            { 
            __context__.SourceCodeLine = 29;
            _52 (  __context__ , (ushort)( I )) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CREATE_FAVOURITE_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        short IERROR = 0;
        
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 30;
        I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 30;
        IERROR = (short) ( _48( __context__ , PROCESSORTYPE ) ) ; 
        __context__.SourceCodeLine = 30;
        _53 (  __context__ , (ushort)( I )) ; 
        __context__.SourceCodeLine = 30;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IERROR < 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 30;
            FAVOURITEFILEERROR  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 30;
            CreateWait ( "__SPLS_TMPVAR__WAITLABEL_0__" , 500 , __SPLS_TMPVAR__WAITLABEL_0___Callback ) ;
            } 
        
        else 
            {
            __context__.SourceCodeLine = 30;
            FAVOURITEFILEERROR  .Value = (ushort) ( 0 ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void __SPLS_TMPVAR__WAITLABEL_0___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            {
            __context__.SourceCodeLine = 30;
            FAVOURITEFILEERROR  .Value = (ushort) ( 0 ) ; 
            }
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object RECALL_FAVOURITE_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 30;
        I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 30;
        FAVOURITE_CMD  .UpdateValue ( _47 (  __context__ , (ushort)( I ), PROCESSORTYPE)  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    short _55 = 0;
    
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 30;
        _55 = (short) ( _48( __context__ , PROCESSORTYPE ) ) ; 
        
        
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
    _49  = new ushort[ 405 ];
    
    SELECT_ALL = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_ALL__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_ALL__DigitalInput__, SELECT_ALL );
    
    CLEAR_ALL = new Crestron.Logos.SplusObjects.DigitalInput( CLEAR_ALL__DigitalInput__, this );
    m_DigitalInputList.Add( CLEAR_ALL__DigitalInput__, CLEAR_ALL );
    
    CREATE_FAVOURITE = new InOutArray<DigitalInput>( 8, this );
    for( uint i = 0; i < 8; i++ )
    {
        CREATE_FAVOURITE[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( CREATE_FAVOURITE__DigitalInput__ + i, CREATE_FAVOURITE__DigitalInput__, this );
        m_DigitalInputList.Add( CREATE_FAVOURITE__DigitalInput__ + i, CREATE_FAVOURITE[i+1] );
    }
    
    RECALL_FAVOURITE = new InOutArray<DigitalInput>( 8, this );
    for( uint i = 0; i < 8; i++ )
    {
        RECALL_FAVOURITE[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( RECALL_FAVOURITE__DigitalInput__ + i, RECALL_FAVOURITE__DigitalInput__, this );
        m_DigitalInputList.Add( RECALL_FAVOURITE__DigitalInput__ + i, RECALL_FAVOURITE[i+1] );
    }
    
    OUTPUT = new InOutArray<DigitalInput>( 404, this );
    for( uint i = 0; i < 404; i++ )
    {
        OUTPUT[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( OUTPUT__DigitalInput__ + i, OUTPUT__DigitalInput__, this );
        m_DigitalInputList.Add( OUTPUT__DigitalInput__ + i, OUTPUT[i+1] );
    }
    
    INPUT = new InOutArray<DigitalInput>( 404, this );
    for( uint i = 0; i < 404; i++ )
    {
        INPUT[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( INPUT__DigitalInput__ + i, INPUT__DigitalInput__, this );
        m_DigitalInputList.Add( INPUT__DigitalInput__ + i, INPUT[i+1] );
    }
    
    FAVOURITEFILEERROR = new Crestron.Logos.SplusObjects.DigitalOutput( FAVOURITEFILEERROR__DigitalOutput__, this );
    m_DigitalOutputList.Add( FAVOURITEFILEERROR__DigitalOutput__, FAVOURITEFILEERROR );
    
    OUTPUTFB = new InOutArray<DigitalOutput>( 404, this );
    for( uint i = 0; i < 404; i++ )
    {
        OUTPUTFB[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( OUTPUTFB__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( OUTPUTFB__DigitalOutput__ + i, OUTPUTFB[i+1] );
    }
    
    OUTPUT_NUMBER = new Crestron.Logos.SplusObjects.AnalogInput( OUTPUT_NUMBER__AnalogSerialInput__, this );
    m_AnalogInputList.Add( OUTPUT_NUMBER__AnalogSerialInput__, OUTPUT_NUMBER );
    
    INPUT_NUMBER = new Crestron.Logos.SplusObjects.AnalogInput( INPUT_NUMBER__AnalogSerialInput__, this );
    m_AnalogInputList.Add( INPUT_NUMBER__AnalogSerialInput__, INPUT_NUMBER );
    
    OUTPUTSTATUS = new InOutArray<AnalogInput>( 404, this );
    for( uint i = 0; i < 404; i++ )
    {
        OUTPUTSTATUS[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( OUTPUTSTATUS__AnalogSerialInput__ + i, OUTPUTSTATUS__AnalogSerialInput__, this );
        m_AnalogInputList.Add( OUTPUTSTATUS__AnalogSerialInput__ + i, OUTPUTSTATUS[i+1] );
    }
    
    PROCESSORTYPE = new Crestron.Logos.SplusObjects.StringInput( PROCESSORTYPE__AnalogSerialInput__, 256, this );
    m_StringInputList.Add( PROCESSORTYPE__AnalogSerialInput__, PROCESSORTYPE );
    
    FAVOURITE_CMD = new Crestron.Logos.SplusObjects.StringOutput( FAVOURITE_CMD__AnalogSerialOutput__, this );
    m_StringOutputList.Add( FAVOURITE_CMD__AnalogSerialOutput__, FAVOURITE_CMD );
    
    MULTI_SWITCH_CMD = new Crestron.Logos.SplusObjects.StringOutput( MULTI_SWITCH_CMD__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MULTI_SWITCH_CMD__AnalogSerialOutput__, MULTI_SWITCH_CMD );
    
    __SPLS_TMPVAR__WAITLABEL_0___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_0___CallbackFn );
    
    SELECT_ALL.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_ALL_OnPush_0, false ) );
    CLEAR_ALL.OnDigitalPush.Add( new InputChangeHandlerWrapper( CLEAR_ALL_OnPush_1, false ) );
    for( uint i = 0; i < 404; i++ )
        OUTPUT[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( OUTPUT_OnPush_2, false ) );
        
    for( uint i = 0; i < 404; i++ )
        INPUT[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( INPUT_OnPush_3, false ) );
        
    for( uint i = 0; i < 8; i++ )
        CREATE_FAVOURITE[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( CREATE_FAVOURITE_OnPush_4, false ) );
        
    for( uint i = 0; i < 8; i++ )
        RECALL_FAVOURITE[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( RECALL_FAVOURITE_OnPush_5, false ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_JAP_AVSWITCH_FAVOURITE_SWITCHING_V2_08 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction __SPLS_TMPVAR__WAITLABEL_0___Callback;


const uint PROCESSORTYPE__AnalogSerialInput__ = 0;
const uint SELECT_ALL__DigitalInput__ = 0;
const uint CLEAR_ALL__DigitalInput__ = 1;
const uint CREATE_FAVOURITE__DigitalInput__ = 2;
const uint RECALL_FAVOURITE__DigitalInput__ = 10;
const uint OUTPUT__DigitalInput__ = 18;
const uint INPUT__DigitalInput__ = 422;
const uint OUTPUT_NUMBER__AnalogSerialInput__ = 1;
const uint INPUT_NUMBER__AnalogSerialInput__ = 2;
const uint OUTPUTSTATUS__AnalogSerialInput__ = 3;
const uint FAVOURITEFILEERROR__DigitalOutput__ = 0;
const uint OUTPUTFB__DigitalOutput__ = 1;
const uint FAVOURITE_CMD__AnalogSerialOutput__ = 0;
const uint MULTI_SWITCH_CMD__AnalogSerialOutput__ = 1;

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

}
