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

namespace UserModule_JAP_AVSWITCH_LUXUL_V1_04
{
    public class UserModuleClass_JAP_AVSWITCH_LUXUL_V1_04 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        private CrestronString _0 (  SplusExecutionContext __context__, CrestronString _2 ) 
            { 
            ushort _3 = 0;
            ushort _4 = 0;
            ushort _5 = 0;
            
            CrestronString _6;
            CrestronString _7;
            _6  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
            _7  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
            
            
            __context__.SourceCodeLine = 2;
            _3 = (ushort) ( Functions.Length( _2 ) ) ; 
            __context__.SourceCodeLine = 2;
            _5 = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 2;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _5 < _3 ))  ) ) 
                { 
                __context__.SourceCodeLine = 2;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( _2 , (int)( _5 ) ) == 38))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2;
                    _4 = (ushort) ( Functions.Find( ";" , _2 , _5 ) ) ; 
                    __context__.SourceCodeLine = 2;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _4 > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 2;
                        _6  .UpdateValue ( Functions.Mid ( _2 ,  (int) ( (_5 + 1) ) ,  (int) ( ((_4 - _5) - 1) ) )  ) ; 
                        __context__.SourceCodeLine = 2;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( _6 , (int)( 1 ) ) == 35))  ) ) 
                            { 
                            __context__.SourceCodeLine = 2;
                            _7  .UpdateValue ( Functions.Chr (  (int) ( Functions.Atoi( Functions.Mid( _6 , (int)( 2 ) , (int)( Functions.Length( _6 ) ) ) ) ) )  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 2;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_6 == "quot"))  ) ) 
                                { 
                                __context__.SourceCodeLine = 2;
                                _7  .UpdateValue ( "\""  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 2;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_6 == "apos"))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 2;
                                    _7  .UpdateValue ( "\'"  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 2;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_6 == "amp"))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 2;
                                        _7  .UpdateValue ( "&"  ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 2;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_6 == "lt"))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 2;
                                            _7  .UpdateValue ( "<"  ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 2;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_6 == "gt"))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 2;
                                                _7  .UpdateValue ( ">"  ) ; 
                                                } 
                                            
                                            else 
                                                { 
                                                __context__.SourceCodeLine = 2;
                                                _7  .UpdateValue ( "&" + _6 + ";"  ) ; 
                                                } 
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        __context__.SourceCodeLine = 2;
                        _2  .UpdateValue ( Functions.Left ( _2 ,  (int) ( (_5 - 1) ) ) + _7 + Functions.Mid ( _2 ,  (int) ( (_4 + 1) ) ,  (int) ( Functions.Length( _2 ) ) )  ) ; 
                        __context__.SourceCodeLine = 2;
                        _5 = (ushort) ( ((_5 + Functions.Length( _7 )) - 1) ) ; 
                        __context__.SourceCodeLine = 2;
                        _3 = (ushort) ( Functions.Length( _2 ) ) ; 
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 2;
                _5 = (ushort) ( (_5 + 1) ) ; 
                __context__.SourceCodeLine = 2;
                } 
            
            __context__.SourceCodeLine = 2;
            ; 
            __context__.SourceCodeLine = 2;
            return ( _2 ) ; 
            
            }
            
        private CrestronString _1 (  SplusExecutionContext __context__, CrestronString _3 ) 
            { 
            CrestronString _4;
            _4  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3000, this );
            
            CrestronString _5;
            _5  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            
            ushort _6 = 0;
            ushort _7 = 0;
            ushort _8 = 0;
            ushort _9 = 0;
            ushort _10 = 0;
            ushort _11 = 0;
            ushort _12 = 0;
            ushort _13 = 0;
            ushort _14 = 0;
            
            
            __context__.SourceCodeLine = 3;
            _5  .UpdateValue ( "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/="  ) ; 
            __context__.SourceCodeLine = 3;
            _13 = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 3;
            _14 = (ushort) ( Functions.Length( _3 ) ) ; 
            __context__.SourceCodeLine = 3;
            _4  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 3;
            _3  .UpdateValue ( _3 + Functions.Chr (  (int) ( 0 ) ) + Functions.Chr (  (int) ( 0 ) )  ) ; 
            __context__.SourceCodeLine = 3;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _13 <= _14 ))  ) ) 
                { 
                __context__.SourceCodeLine = 3;
                _6 = (ushort) ( Byte( _3 , (int)( _13 ) ) ) ; 
                __context__.SourceCodeLine = 3;
                _13 = (ushort) ( (_13 + 1) ) ; 
                __context__.SourceCodeLine = 3;
                _7 = (ushort) ( Byte( _3 , (int)( _13 ) ) ) ; 
                __context__.SourceCodeLine = 3;
                _13 = (ushort) ( (_13 + 1) ) ; 
                __context__.SourceCodeLine = 3;
                _8 = (ushort) ( Byte( _3 , (int)( _13 ) ) ) ; 
                __context__.SourceCodeLine = 3;
                _13 = (ushort) ( (_13 + 1) ) ; 
                __context__.SourceCodeLine = 3;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_7 == 65535))  ) ) 
                    { 
                    __context__.SourceCodeLine = 3;
                    _7 = (ushort) ( 0 ) ; 
                    } 
                
                __context__.SourceCodeLine = 3;
                ; 
                __context__.SourceCodeLine = 3;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_8 == 65535))  ) ) 
                    { 
                    __context__.SourceCodeLine = 3;
                    _8 = (ushort) ( 0 ) ; 
                    } 
                
                __context__.SourceCodeLine = 3;
                ; 
                __context__.SourceCodeLine = 3;
                _9 = (ushort) ( (_6 >> 2) ) ; 
                __context__.SourceCodeLine = 3;
                _10 = (ushort) ( (((_6 & 3) << 4) | (_7 >> 4)) ) ; 
                __context__.SourceCodeLine = 3;
                _11 = (ushort) ( (((_7 & 15) << 2) | (_8 >> 6)) ) ; 
                __context__.SourceCodeLine = 3;
                _12 = (ushort) ( (_8 & 63) ) ; 
                __context__.SourceCodeLine = 3;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_7 == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 3;
                    _11 = (ushort) ( 64 ) ; 
                    __context__.SourceCodeLine = 3;
                    _12 = (ushort) ( 64 ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 3;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_8 == 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 3;
                        _12 = (ushort) ( 64 ) ; 
                        } 
                    
                    }
                
                __context__.SourceCodeLine = 3;
                _4  .UpdateValue ( _4 + Functions.Mid ( _5 ,  (int) ( (_9 + 1) ) ,  (int) ( 1 ) ) + Functions.Mid ( _5 ,  (int) ( (_10 + 1) ) ,  (int) ( 1 ) ) + Functions.Mid ( _5 ,  (int) ( (_11 + 1) ) ,  (int) ( 1 ) ) + Functions.Mid ( _5 ,  (int) ( (_12 + 1) ) ,  (int) ( 1 ) )  ) ; 
                __context__.SourceCodeLine = 3;
                } 
            
            __context__.SourceCodeLine = 3;
            return ( _4 ) ; 
            
            }
            
        private CrestronString _2 (  SplusExecutionContext __context__, CrestronString _4 ) 
            { 
            CrestronString _5;
            _5  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3000, this );
            
            CrestronString _6;
            _6  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            
            ushort _7 = 0;
            ushort _8 = 0;
            ushort _9 = 0;
            ushort _10 = 0;
            ushort _11 = 0;
            ushort _12 = 0;
            ushort _13 = 0;
            ushort _14 = 0;
            ushort _15 = 0;
            
            
            __context__.SourceCodeLine = 4;
            _6  .UpdateValue ( "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/="  ) ; 
            __context__.SourceCodeLine = 4;
            _14 = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 4;
            _5  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 4;
            _15 = (ushort) ( Functions.Length( _4 ) ) ; 
            __context__.SourceCodeLine = 4;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _14 <= _15 ))  ) ) 
                { 
                __context__.SourceCodeLine = 4;
                _10 = (ushort) ( (Functions.Find( Functions.Mid( _4 , (int)( _14 ) , (int)( 1 ) ) , _6 ) - 1) ) ; 
                __context__.SourceCodeLine = 4;
                _14 = (ushort) ( (_14 + 1) ) ; 
                __context__.SourceCodeLine = 4;
                _11 = (ushort) ( (Functions.Find( Functions.Mid( _4 , (int)( _14 ) , (int)( 1 ) ) , _6 ) - 1) ) ; 
                __context__.SourceCodeLine = 4;
                _14 = (ushort) ( (_14 + 1) ) ; 
                __context__.SourceCodeLine = 4;
                _12 = (ushort) ( (Functions.Find( Functions.Mid( _4 , (int)( _14 ) , (int)( 1 ) ) , _6 ) - 1) ) ; 
                __context__.SourceCodeLine = 4;
                _14 = (ushort) ( (_14 + 1) ) ; 
                __context__.SourceCodeLine = 4;
                _13 = (ushort) ( (Functions.Find( Functions.Mid( _4 , (int)( _14 ) , (int)( 1 ) ) , _6 ) - 1) ) ; 
                __context__.SourceCodeLine = 4;
                _14 = (ushort) ( (_14 + 1) ) ; 
                __context__.SourceCodeLine = 4;
                _7 = (ushort) ( ((_10 << 2) | (_11 >> 4)) ) ; 
                __context__.SourceCodeLine = 4;
                _8 = (ushort) ( (((_11 & 15) << 4) | (_12 >> 2)) ) ; 
                __context__.SourceCodeLine = 4;
                _9 = (ushort) ( (((_12 & 3) << 6) | _13) ) ; 
                __context__.SourceCodeLine = 4;
                _5  .UpdateValue ( _5 + Functions.Chr (  (int) ( _7 ) )  ) ; 
                __context__.SourceCodeLine = 4;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_12 != 64))  ) ) 
                    {
                    __context__.SourceCodeLine = 4;
                    _5  .UpdateValue ( _5 + Functions.Chr (  (int) ( _8 ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 4;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_13 != 64))  ) ) 
                    {
                    __context__.SourceCodeLine = 4;
                    _5  .UpdateValue ( _5 + Functions.Chr (  (int) ( _9 ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 4;
                } 
            
            __context__.SourceCodeLine = 4;
            return ( _5 ) ; 
            
            }
            
        private void _3 (  SplusExecutionContext __context__, CrestronString _5 ) 
            { 
            CrestronString _6;
            CrestronString _7;
            _6  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            _7  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            
            
            __context__.SourceCodeLine = 5;
            _7  .UpdateValue ( _1 (  __context__ , _5)  ) ; 
            __context__.SourceCodeLine = 5;
            _6  .UpdateValue ( _2 (  __context__ , _7)  ) ; 
            __context__.SourceCodeLine = 5;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_6 == _5))  ) ) 
                { 
                __context__.SourceCodeLine = 5;
                Print( "__Base64__ OK\r\n    In$     {0}\r\n    Encode  {1}\r\n    Out$    {2}\r\n", _5 , _7 , _6 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 5;
                Print( "__Base64__ ERROR\r\n    In$     {0}\r\n    Encode  {1}\r\n    Out$    {2}\r\n", _5 , _7 , _6 ) ; 
                } 
            
            
            }
            
        private ushort _4 (  SplusExecutionContext __context__, ushort _6 , ushort _7 , ushort _8 , ushort _9 , ushort _10 , ushort _11 , ushort _12 ) 
            { 
            uint _13 = 0;
            
            ushort _14 = 0;
            ushort _15 = 0;
            
            ushort _16 = 0;
            ushort _17 = 0;
            
            
            __context__.SourceCodeLine = 5;
            _15 = (ushort) ( ((_9 - _6) / _8) ) ; 
            __context__.SourceCodeLine = 5;
            _14 = (ushort) ( ((_7 - _6) / _8) ) ; 
            __context__.SourceCodeLine = 5;
            _16 = (ushort) ( ((_11 - _10) / _12) ) ; 
            __context__.SourceCodeLine = 5;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_15 == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 5;
                return (ushort)( _10) ; 
                } 
            
            __context__.SourceCodeLine = 5;
            _13 = (uint) ( (_15 * _16) ) ; 
            __context__.SourceCodeLine = 5;
            _17 = (ushort) ( (_13 / _14) ) ; 
            __context__.SourceCodeLine = 6;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Mod( _13 , _14 ) > (_14 / 2) ))  ) ) 
                { 
                __context__.SourceCodeLine = 6;
                _17 = (ushort) ( (_17 + 1) ) ; 
                } 
            
            __context__.SourceCodeLine = 6;
            return (ushort)( (_17 * _12)) ; 
            
            }
            
        private ushort _5 (  SplusExecutionContext __context__, CrestronString _7 ) 
            { 
            ushort _8 = 0;
            ushort _9 = 0;
            ushort _10 = 0;
            
            CrestronString _11;
            CrestronString _12;
            _11  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
            _12  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
            
            
            __context__.SourceCodeLine = 6;
            _11  .UpdateValue ( Functions.Remove ( "-" , _7 )  ) ; 
            __context__.SourceCodeLine = 6;
            _8 = (ushort) ( Byte( _7 , (int)( 1 ) ) ) ; 
            __context__.SourceCodeLine = 6;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _8 < 48 ) ) || Functions.TestForTrue ( Functions.BoolToInt ( _8 > 57 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 6;
                return (ushort)( 65535) ; 
                } 
            
            __context__.SourceCodeLine = 6;
            _11  .UpdateValue ( Functions.Remove ( "." , _7 )  ) ; 
            __context__.SourceCodeLine = 6;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( _11 ) == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 6;
                _11  .UpdateValue ( Functions.Remove ( "d" , _7 )  ) ; 
                __context__.SourceCodeLine = 6;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( _11 ) == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 6;
                    return (ushort)( 65535) ; 
                    } 
                
                __context__.SourceCodeLine = 6;
                _9 = (ushort) ( Functions.Atoi( _11 ) ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 6;
                _11  .UpdateValue ( Functions.Left ( _11 ,  (int) ( (Functions.Length( _11 ) - 1) ) )  ) ; 
                __context__.SourceCodeLine = 6;
                _12  .UpdateValue ( Functions.Remove ( "d" , _7 )  ) ; 
                __context__.SourceCodeLine = 6;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( _12 ) == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 6;
                    return (ushort)( 65535) ; 
                    } 
                
                __context__.SourceCodeLine = 6;
                _9 = (ushort) ( Functions.Atoi( _11 ) ) ; 
                __context__.SourceCodeLine = 6;
                _10 = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 6;
                _8 = (ushort) ( Byte( _12 , (int)( _10 ) ) ) ; 
                __context__.SourceCodeLine = 6;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_8 == 100))  ) ) 
                    { 
                    __context__.SourceCodeLine = 6;
                    return (ushort)( 65535) ; 
                    } 
                
                __context__.SourceCodeLine = 6;
                while ( Functions.TestForTrue  ( ( Functions.BoolToInt (_8 != 100))  ) ) 
                    { 
                    __context__.SourceCodeLine = 6;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _8 < 48 ) ) || Functions.TestForTrue ( Functions.BoolToInt ( _8 > 57 ) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 6;
                        return (ushort)( 65535) ; 
                        } 
                    
                    __context__.SourceCodeLine = 6;
                    _10 = (ushort) ( (_10 + 1) ) ; 
                    __context__.SourceCodeLine = 6;
                    _8 = (ushort) ( Byte( _12 , (int)( _10 ) ) ) ; 
                    __context__.SourceCodeLine = 6;
                    _9 = (ushort) ( (_9 * 10) ) ; 
                    __context__.SourceCodeLine = 6;
                    } 
                
                __context__.SourceCodeLine = 7;
                _9 = (ushort) ( (_9 + Functions.Atoi( _12 )) ) ; 
                } 
            
            __context__.SourceCodeLine = 7;
            return (ushort)( _9) ; 
            
            }
            
        private ushort _6 (  SplusExecutionContext __context__, CrestronString _8 , CrestronString _9 , ushort _10 ) 
            { 
            ushort _11 = 0;
            
            
            __context__.SourceCodeLine = 7;
            _11 = (ushort) ( Functions.Find( _8 , _9 , _10 ) ) ; 
            __context__.SourceCodeLine = 7;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _11 < _10 ))  ) ) 
                {
                __context__.SourceCodeLine = 7;
                _11 = (ushort) ( 0 ) ; 
                }
            
            __context__.SourceCodeLine = 7;
            return (ushort)( _11) ; 
            
            }
            
        private ushort _19 (  SplusExecutionContext __context__, ushort _21 ) 
            { 
            
            __context__.SourceCodeLine = 7;
            return (ushort)( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _21 >= 64 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _21 <= 90 ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _21 >= 96 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _21 <= 122 ) )) ) )) )) ; 
            
            }
            
        private ushort _20 (  SplusExecutionContext __context__, ushort _22 ) 
            { 
            
            __context__.SourceCodeLine = 7;
            return (ushort)( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _22 < 32 ) ) || Functions.TestForTrue ( Functions.BoolToInt (_22 == 127) )) )) ; 
            
            }
            
        private ushort _21 (  SplusExecutionContext __context__, ushort _23 ) 
            { 
            
            __context__.SourceCodeLine = 8;
            return (ushort)( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _23 >= 48 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _23 <= 57 ) )) )) ; 
            
            }
            
        private ushort _22 (  SplusExecutionContext __context__, ushort _24 ) 
            { 
            
            __context__.SourceCodeLine = 8;
            return (ushort)( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _24 >= 96 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _24 <= 122 ) )) )) ; 
            
            }
            
        private ushort _23 (  SplusExecutionContext __context__, ushort _25 ) 
            { 
            
            __context__.SourceCodeLine = 8;
            return (ushort)( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _25 >= 33 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _25 <= 47 ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _25 >= 58 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _25 <= 64 ) )) ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _25 >= 91 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _25 <= 96 ) )) ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _25 >= 123 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _25 <= 126 ) )) ) )) )) ; 
            
            }
            
        private ushort _24 (  SplusExecutionContext __context__, ushort _26 ) 
            { 
            
            __context__.SourceCodeLine = 8;
            return (ushort)( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_26 == 9) ) || Functions.TestForTrue ( Functions.BoolToInt (_26 == 10) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (_26 == 13) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (_26 == 32) )) )) ; 
            
            }
            
        private ushort _25 (  SplusExecutionContext __context__, ushort _27 ) 
            { 
            
            __context__.SourceCodeLine = 8;
            return (ushort)( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _27 >= 64 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _27 <= 90 ) )) )) ; 
            
            }
            
        private ushort _26 (  SplusExecutionContext __context__, ushort _28 ) 
            { 
            
            __context__.SourceCodeLine = 8;
            return (ushort)( Functions.BoolToInt ( (Functions.TestForTrue ( _21( __context__ , (ushort)( _28 ) ) ) || Functions.TestForTrue ( _19( __context__ , (ushort)( _28 ) ) )) )) ; 
            
            }
            
        private ushort _27 (  SplusExecutionContext __context__, ushort _29 ) 
            { 
            
            __context__.SourceCodeLine = 8;
            return (ushort)( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( _21( __context__ , (ushort)( _29 ) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _29 >= 65 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _29 <= 70 ) )) ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _29 >= 97 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _29 <= 102 ) )) ) )) )) ; 
            
            }
            
        private ushort _28 (  SplusExecutionContext __context__, ref _7 _30 , ushort _31 , CrestronString _12 , ushort _32 ) 
            { 
            ushort _33 = 0;
            
            ushort _34 = 0;
            
            
            __context__.SourceCodeLine = 9;
            _30 . _12  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 9;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( _12 ) > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt (Byte( _12 , (int)( 1 ) ) == 94) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 9;
                _33 = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 9;
                _32 = (ushort) ( (_32 - 1) ) ; 
                __context__.SourceCodeLine = 9;
                _30 . _12  .UpdateValue ( Functions.Right ( _12 ,  (int) ( _32 ) )  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 9;
                _33 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 9;
                _30 . _12  .UpdateValue ( _12  ) ; 
                } 
            
            __context__.SourceCodeLine = 9;
            _30 . _8  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 9;
            _30 . _9 = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 9;
            _30 . _13 = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 9;
            _30 . _14 = (ushort) ( (_31 + 1) ) ; 
            __context__.SourceCodeLine = 9;
            _30 . _15 = (ushort) ( (_32 + 1) ) ; 
            __context__.SourceCodeLine = 9;
            _30 . _16 = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 9;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 0 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)(10 - 1); 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( _34  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_34  >= __FN_FORSTART_VAL__1) && (_34  <= __FN_FOREND_VAL__1) ) : ( (_34  <= __FN_FORSTART_VAL__1) && (_34  >= __FN_FOREND_VAL__1) ) ; _34  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 9;
                _30 . _10 [ _34] = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 9;
                _30 . _11 [ _34] = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 9;
                _30 . _17 [ _34] = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 9;
                _30 . _18 [ _34] = (short) ( 0 ) ; 
                __context__.SourceCodeLine = 9;
                } 
            
            __context__.SourceCodeLine = 9;
            return (ushort)( _33) ; 
            
            }
            
        private ushort _29 (  SplusExecutionContext __context__, ref _7 _31 , ushort _32 , CrestronString _33 ) 
            { 
            
            __context__.SourceCodeLine = 9;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (_31._9 + _32) > 10 ))  ) ) 
                { 
                __context__.SourceCodeLine = 9;
                _32 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 9;
                _31 . _8  .UpdateValue ( _33  ) ; 
                } 
            
            __context__.SourceCodeLine = 10;
            return (ushort)( _32) ; 
            
            }
            
        private ushort _30 (  SplusExecutionContext __context__, ref _7 _32 , ushort _33 , ushort _34 ) 
            { 
            ushort _35 = 0;
            
            ushort _10 = 0;
            
            
            __context__.SourceCodeLine = 10;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _32._9 >= 10 ))  ) ) 
                { 
                __context__.SourceCodeLine = 10;
                _32 . _8  .UpdateValue ( "stack overflow"  ) ; 
                __context__.SourceCodeLine = 10;
                _35 = (ushort) ( 0 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 10;
                _10 = (ushort) ( ((_33 - _32._13) + 1) ) ; 
                __context__.SourceCodeLine = 10;
                _32 . _10 [ _32._9] = (ushort) ( _10 ) ; 
                __context__.SourceCodeLine = 10;
                _32 . _11 [ _32._9] = (ushort) ( (_10 + (_34 - _33)) ) ; 
                __context__.SourceCodeLine = 10;
                _32 . _9 = (ushort) ( (_32._9 + 1) ) ; 
                __context__.SourceCodeLine = 10;
                _35 = (ushort) ( 1 ) ; 
                } 
            
            __context__.SourceCodeLine = 10;
            return (ushort)( _35) ; 
            
            }
            
        private ushort _31 (  SplusExecutionContext __context__, ref _7 _33 , ushort _34 ) 
            { 
            
            __context__.SourceCodeLine = 10;
            _34 = (ushort) ( (_34 - 49) ) ; 
            __context__.SourceCodeLine = 10;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _34 < 0 ) ) || Functions.TestForTrue ( Functions.BoolToInt ( _34 >= _33._16 ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (_33._18[ _34 ] == Functions.ToSignedLongInteger( -( 1 ) )) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 10;
                _33 . _8  .UpdateValue ( "invalid capture index"  ) ; 
                __context__.SourceCodeLine = 10;
                _34 = (ushort) ( 0 ) ; 
                } 
            
            __context__.SourceCodeLine = 10;
            return (ushort)( _34) ; 
            
            }
            
        private short _32 (  SplusExecutionContext __context__, ref _7 _34 ) 
            { 
            ushort _16 = 0;
            
            
            __context__.SourceCodeLine = 10;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( _34._16 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)0; 
            int __FN_FORSTEP_VAL__1 = (int)Functions.ToLongInteger( -( 1 ) ); 
            for ( _16  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_16  >= __FN_FORSTART_VAL__1) && (_16  <= __FN_FOREND_VAL__1) ) : ( (_16  <= __FN_FORSTART_VAL__1) && (_16  >= __FN_FOREND_VAL__1) ) ; _16  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 10;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_34._18[ _16 ] == Functions.ToSignedLongInteger( -( 1 ) )))  ) ) 
                    {
                    __context__.SourceCodeLine = 11;
                    return (short)( _16) ; 
                    }
                
                __context__.SourceCodeLine = 10;
                } 
            
            __context__.SourceCodeLine = 11;
            _34 . _8  .UpdateValue ( "invalid pattern capture"  ) ; 
            __context__.SourceCodeLine = 11;
            return (short)( Functions.ToSignedInteger( -( 1 ) )) ; 
            
            }
            
        private ushort _33 (  SplusExecutionContext __context__, ref _7 _35 , ushort _36 ) 
            { 
            
            __context__.SourceCodeLine = 11;
            _36 = (ushort) ( (_36 + 1) ) ; 
            __context__.SourceCodeLine = 11;
            
                {
                int __SPLS_TMPVAR__SWTCH_1__ = ((int)Byte( _35._12 , (int)( (_36 - 1) ) ));
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 37) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 11;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_36 == _35._15))  ) ) 
                            { 
                            __context__.SourceCodeLine = 11;
                            _35 . _8  .UpdateValue ( "malformed pattern (ends with %)"  ) ; 
                            __context__.SourceCodeLine = 11;
                            return (ushort)( _36) ; 
                            } 
                        
                        __context__.SourceCodeLine = 11;
                        return (ushort)( (_36 + 1)) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 91) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 11;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _36 < _35._15 ) ) && Functions.TestForTrue ( Functions.BoolToInt (Byte( _35._12 , (int)( _36 ) ) == 94) )) ))  ) ) 
                            {
                            __context__.SourceCodeLine = 11;
                            _36 = (ushort) ( (_36 + 1) ) ; 
                            }
                        
                        __context__.SourceCodeLine = 11;
                        do 
                            { 
                            __context__.SourceCodeLine = 11;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_36 == _35._15))  ) ) 
                                { 
                                __context__.SourceCodeLine = 11;
                                _35 . _8  .UpdateValue ( "malformed pattern (missing ])"  ) ; 
                                __context__.SourceCodeLine = 11;
                                return (ushort)( _36) ; 
                                } 
                            
                            __context__.SourceCodeLine = 11;
                            _36 = (ushort) ( (_36 + 1) ) ; 
                            __context__.SourceCodeLine = 11;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Byte( _35._12 , (int)( (_36 - 1) ) ) == 37) ) && Functions.TestForTrue ( Functions.BoolToInt ( _36 < _35._15 ) )) ))  ) ) 
                                {
                                __context__.SourceCodeLine = 11;
                                _36 = (ushort) ( (_36 + 1) ) ; 
                                }
                            
                            } 
                        while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (Byte( _35._12 , (int)( _36 ) ) == 93)) )); 
                        __context__.SourceCodeLine = 11;
                        return (ushort)( (_36 + 1)) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 11;
                        return (ushort)( _36) ; 
                        } 
                    
                    } 
                    
                }
                
            
            
            return 0; // default return value (none specified in module)
            }
            
        private ushort _34 (  SplusExecutionContext __context__, ushort _36 , ushort _37 ) 
            { 
            ushort _38 = 0;
            
            
            __context__.SourceCodeLine = 12;
            
                {
                int __SPLS_TMPVAR__SWTCH_2__ = ((int)Functions.LowerChar( (uint)( _37 ) ));
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == (  (uint) ( 97 ) ) ) ) ) 
                        {
                        __context__.SourceCodeLine = 12;
                        _38 = (ushort) ( _19( __context__ , (ushort)( _36 ) ) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 99) ) ) ) 
                        {
                        __context__.SourceCodeLine = 12;
                        _38 = (ushort) ( _20( __context__ , (ushort)( _36 ) ) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 100) ) ) ) 
                        {
                        __context__.SourceCodeLine = 12;
                        _38 = (ushort) ( _21( __context__ , (ushort)( _36 ) ) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 108) ) ) ) 
                        {
                        __context__.SourceCodeLine = 12;
                        _38 = (ushort) ( _22( __context__ , (ushort)( _36 ) ) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 112) ) ) ) 
                        {
                        __context__.SourceCodeLine = 12;
                        _38 = (ushort) ( _23( __context__ , (ushort)( _36 ) ) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 115) ) ) ) 
                        {
                        __context__.SourceCodeLine = 12;
                        _38 = (ushort) ( _24( __context__ , (ushort)( _36 ) ) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 117) ) ) ) 
                        {
                        __context__.SourceCodeLine = 12;
                        _38 = (ushort) ( _25( __context__ , (ushort)( _36 ) ) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 119) ) ) ) 
                        {
                        __context__.SourceCodeLine = 12;
                        _38 = (ushort) ( _26( __context__ , (ushort)( _36 ) ) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 120) ) ) ) 
                        {
                        __context__.SourceCodeLine = 12;
                        _38 = (ushort) ( _27( __context__ , (ushort)( _36 ) ) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 122) ) ) ) 
                        {
                        __context__.SourceCodeLine = 12;
                        return (ushort)( Functions.BoolToInt (_36 == 0)) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 12;
                        return (ushort)( Functions.BoolToInt (_37 == _36)) ; 
                        }
                    
                    } 
                    
                }
                
            
            __context__.SourceCodeLine = 12;
            if ( Functions.TestForTrue  ( ( _25( __context__ , (ushort)( _37 ) ))  ) ) 
                {
                __context__.SourceCodeLine = 12;
                _38 = (ushort) ( Functions.Not( _38 ) ) ; 
                }
            
            __context__.SourceCodeLine = 12;
            return (ushort)( _38) ; 
            
            }
            
        private ushort _35 (  SplusExecutionContext __context__, ref _7 _37 , ushort _38 , ushort _39 , ushort _40 ) 
            { 
            ushort _41 = 0;
            
            
            __context__.SourceCodeLine = 12;
            _41 = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 13;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (_39 + 1) < _37._15 ) ) && Functions.TestForTrue ( Functions.BoolToInt (Byte( _37._12 , (int)( (_39 + 1) ) ) == 94) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 13;
                _41 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 13;
                _39 = (ushort) ( (_39 + 1) ) ; 
                } 
            
            __context__.SourceCodeLine = 13;
            _39 = (ushort) ( (_39 + 1) ) ; 
            __context__.SourceCodeLine = 13;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _39 < _40 ))  ) ) 
                { 
                __context__.SourceCodeLine = 13;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( _37._12 , (int)( _39 ) ) == 37))  ) ) 
                    { 
                    __context__.SourceCodeLine = 13;
                    _39 = (ushort) ( (_39 + 1) ) ; 
                    __context__.SourceCodeLine = 13;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _39 < _37._15 ) ) && Functions.TestForTrue ( _34( __context__ , (ushort)( _38 ) , (ushort)( Byte( _37._12 , (int)( _39 ) ) ) ) )) ))  ) ) 
                        {
                        __context__.SourceCodeLine = 13;
                        return (ushort)( _41) ; 
                        }
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 13;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (_39 + 1) < _37._15 ) ) && Functions.TestForTrue ( Functions.BoolToInt (Byte( _37._12 , (int)( (_39 + 1) ) ) == 45) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( (_39 + 2) < _40 ) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 13;
                        _39 = (ushort) ( (_39 + 2) ) ; 
                        __context__.SourceCodeLine = 13;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Byte( _37._12 , (int)( (_39 - 2) ) ) <= _38 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _38 <= Byte( _37._12 , (int)( _39 ) ) ) )) ))  ) ) 
                            {
                            __context__.SourceCodeLine = 13;
                            return (ushort)( _41) ; 
                            }
                        
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 13;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( _37._12 , (int)( _39 ) ) == _38))  ) ) 
                            {
                            __context__.SourceCodeLine = 13;
                            return (ushort)( _41) ; 
                            }
                        
                        }
                    
                    }
                
                __context__.SourceCodeLine = 13;
                _39 = (ushort) ( (_39 + 1) ) ; 
                __context__.SourceCodeLine = 13;
                } 
            
            __context__.SourceCodeLine = 13;
            return (ushort)( Functions.Not( _41 )) ; 
            
            }
            
        private ushort _36 (  SplusExecutionContext __context__, ref _7 _38 , ushort _39 , ushort _40 , ushort _41 ) 
            { 
            
            __context__.SourceCodeLine = 13;
            
                {
                int __SPLS_TMPVAR__SWTCH_3__ = ((int)Byte( _38._12 , (int)( _40 ) ));
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 46) ) ) ) 
                        {
                        __context__.SourceCodeLine = 13;
                        return (ushort)( 1) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 37) ) ) ) 
                        {
                        __context__.SourceCodeLine = 14;
                        return (ushort)( _34( __context__ , (ushort)( _39 ) , (ushort)( Byte( _38._12 , (int)( (_40 + 1) ) ) ) )) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 91) ) ) ) 
                        {
                        __context__.SourceCodeLine = 14;
                        return (ushort)( _35( __context__ , ref _38 , (ushort)( _39 ) , (ushort)( _40 ) , (ushort)( (_41 - 1) ) )) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 14;
                        return (ushort)( Functions.BoolToInt (Byte( _38._12 , (int)( _40 ) ) == _39)) ; 
                        }
                    
                    } 
                    
                }
                
            
            
            return 0; // default return value (none specified in module)
            }
            
        private ushort _37 (  SplusExecutionContext __context__, ref _7 _39 , CrestronString _40 , ushort _41 , ushort _42 ) 
            { 
            ushort _43 = 0;
            
            ushort _44 = 0;
            
            ushort _45 = 0;
            
            
            __context__.SourceCodeLine = 14;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _42 >= (_39._15 - 1) ))  ) ) 
                { 
                __context__.SourceCodeLine = 14;
                _39 . _8  .UpdateValue ( "malformed pattern (missing arguments to %b)"  ) ; 
                __context__.SourceCodeLine = 14;
                return (ushort)( 0) ; 
                } 
            
            __context__.SourceCodeLine = 14;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( _40 , (int)( _41 ) ) != Byte( _39._12 , (int)( _42 ) )))  ) ) 
                {
                __context__.SourceCodeLine = 14;
                return (ushort)( 0) ; 
                }
            
            else 
                { 
                __context__.SourceCodeLine = 14;
                _43 = (ushort) ( Byte( _39._12 , (int)( _42 ) ) ) ; 
                __context__.SourceCodeLine = 14;
                _44 = (ushort) ( Byte( _39._12 , (int)( (_42 + 1) ) ) ) ; 
                __context__.SourceCodeLine = 14;
                _45 = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 14;
                _41 = (ushort) ( (_41 + 1) ) ; 
                __context__.SourceCodeLine = 14;
                while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _41 < _39._14 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 14;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( _40 , (int)( _41 ) ) == _44))  ) ) 
                        { 
                        __context__.SourceCodeLine = 14;
                        _45 = (ushort) ( (_45 - 1) ) ; 
                        __context__.SourceCodeLine = 14;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_45 == 0))  ) ) 
                            {
                            __context__.SourceCodeLine = 14;
                            return (ushort)( (_41 + 1)) ; 
                            }
                        
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 15;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( _40 , (int)( _41 ) ) == _43))  ) ) 
                            {
                            __context__.SourceCodeLine = 15;
                            _45 = (ushort) ( (_45 + 1) ) ; 
                            }
                        
                        }
                    
                    __context__.SourceCodeLine = 15;
                    _41 = (ushort) ( (_41 + 1) ) ; 
                    __context__.SourceCodeLine = 14;
                    } 
                
                } 
            
            __context__.SourceCodeLine = 15;
            return (ushort)( 0) ; 
            
            }
            
        private ushort _38 (  SplusExecutionContext __context__, ref _7 _40 , CrestronString _41 , ushort _42 , ushort _43 ) 
            { 
            ushort _18 = 0;
            
            
            __context__.SourceCodeLine = 15;
            _43 = (ushort) ( _31( __context__ , ref _40 , (ushort)( _43 ) ) ) ; 
            __context__.SourceCodeLine = 15;
            _18 = (ushort) ( _40._18[ _43 ] ) ; 
            __context__.SourceCodeLine = 15;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (_40._14 - _42) >= _18 ) ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Mid( _41 , (int)( _40._17[ _43 ] ) , (int)( _18 ) ) == Functions.Mid( _41 , (int)( _42 ) , (int)( _18 ) )) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 15;
                return (ushort)( (_42 + _18)) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 15;
                return (ushort)( 0) ; 
                }
            
            
            return 0; // default return value (none specified in module)
            }
            
        private ushort _39 (  SplusExecutionContext __context__, ref _7 _41 , CrestronString _42 , ushort _43 , ushort _44 ) 
            { 
            ushort _45 = 0;
            
            ushort _46 = 0;
            
            short _47 = 0;
            
            ushort _48 = 0;
            
            ushort _49 = 0;
            
            short _50 = 0;
            
            ushort _51 = 0;
            
            
            __context__.SourceCodeLine = 15;
            while ( Functions.TestForTrue  ( ( 1)  ) ) 
                { 
                __context__.SourceCodeLine = 15;
                _48 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 15;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_44 == _41._15))  ) ) 
                    { 
                    __context__.SourceCodeLine = 15;
                    return (ushort)( _43) ; 
                    } 
                
                __context__.SourceCodeLine = 15;
                
                    {
                    int __SPLS_TMPVAR__SWTCH_4__ = ((int)Byte( _41._12 , (int)( _44 ) ));
                    
                        { 
                        if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 40) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 16;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( _41._12 , (int)( (_44 + 1) ) ) == 41))  ) ) 
                                { 
                                __context__.SourceCodeLine = 16;
                                _47 = (short) ( Functions.ToSignedInteger( -( 2 ) ) ) ; 
                                __context__.SourceCodeLine = 16;
                                _44 = (ushort) ( (_44 + 2) ) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 16;
                                _47 = (short) ( Functions.ToSignedInteger( -( 1 ) ) ) ; 
                                __context__.SourceCodeLine = 16;
                                _44 = (ushort) ( (_44 + 1) ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 16;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _41._16 >= 10 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 16;
                                _41 . _8  .UpdateValue ( "too many captures"  ) ; 
                                __context__.SourceCodeLine = 16;
                                return (ushort)( 0) ; 
                                } 
                            
                            __context__.SourceCodeLine = 16;
                            _41 . _17 [ _41._16] = (ushort) ( _43 ) ; 
                            __context__.SourceCodeLine = 16;
                            _41 . _18 [ _41._16] = (short) ( _47 ) ; 
                            __context__.SourceCodeLine = 16;
                            _41 . _16 = (ushort) ( (_41._16 + 1) ) ; 
                            __context__.SourceCodeLine = 16;
                            _51 = (ushort) ( _39( __context__ , ref _41 , _42 , (ushort)( _43 ) , (ushort)( _44 ) ) ) ; 
                            __context__.SourceCodeLine = 16;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_51 == 0))  ) ) 
                                {
                                __context__.SourceCodeLine = 16;
                                _41 . _16 = (ushort) ( (_41._16 - 1) ) ; 
                                }
                            
                            __context__.SourceCodeLine = 16;
                            return (ushort)( _51) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 41) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 16;
                            _50 = (short) ( _32( __context__ , ref _41 ) ) ; 
                            __context__.SourceCodeLine = 16;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _50 < 0 ))  ) ) 
                                {
                                __context__.SourceCodeLine = 16;
                                return (ushort)( 0) ; 
                                }
                            
                            __context__.SourceCodeLine = 16;
                            _41 . _18 [ _50] = (short) ( (_43 - _41._17[ _50 ]) ) ; 
                            __context__.SourceCodeLine = 16;
                            _51 = (ushort) ( _39( __context__ , ref _41 , _42 , (ushort)( _43 ) , (ushort)( (_44 + 1) ) ) ) ; 
                            __context__.SourceCodeLine = 16;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_51 == 0))  ) ) 
                                {
                                __context__.SourceCodeLine = 16;
                                _41 . _18 [ _50] = (short) ( Functions.ToInteger( -( 1 ) ) ) ; 
                                }
                            
                            __context__.SourceCodeLine = 16;
                            return (ushort)( _51) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 36) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 16;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ((_44 + 1) == _41._15))  ) ) 
                                { 
                                __context__.SourceCodeLine = 16;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_43 == _41._14))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 16;
                                    return (ushort)( _43) ; 
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 16;
                                    return (ushort)( 0) ; 
                                    } 
                                
                                } 
                            
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 37) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 17;
                            
                                {
                                int __SPLS_TMPVAR__SWTCH_5__ = ((int)Byte( _41._12 , (int)( (_44 + 1) ) ));
                                
                                    { 
                                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 98) ) ) ) 
                                        { 
                                        __context__.SourceCodeLine = 17;
                                        _43 = (ushort) ( _37( __context__ , ref _41 , _42 , (ushort)( _43 ) , (ushort)( (_44 + 2) ) ) ) ; 
                                        __context__.SourceCodeLine = 17;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_43 == 0))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 17;
                                            return (ushort)( 0) ; 
                                            } 
                                        
                                        __context__.SourceCodeLine = 17;
                                        _44 = (ushort) ( (_44 + 4) ) ; 
                                        __context__.SourceCodeLine = 17;
                                        _48 = (ushort) ( 1 ) ; 
                                        } 
                                    
                                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 102) ) ) ) 
                                        { 
                                        __context__.SourceCodeLine = 17;
                                        _44 = (ushort) ( (_44 + 2) ) ; 
                                        __context__.SourceCodeLine = 17;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( _41._12 , (int)( _44 ) ) != 91))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 17;
                                            _41 . _8  .UpdateValue ( "missing [ after %f in pattern"  ) ; 
                                            __context__.SourceCodeLine = 17;
                                            return (ushort)( 0) ; 
                                            } 
                                        
                                        __context__.SourceCodeLine = 17;
                                        _45 = (ushort) ( _33( __context__ , ref _41 , (ushort)( _44 ) ) ) ; 
                                        __context__.SourceCodeLine = 17;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_43 == _41._13))  ) ) 
                                            {
                                            __context__.SourceCodeLine = 17;
                                            _46 = (ushort) ( 0 ) ; 
                                            }
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 17;
                                            _46 = (ushort) ( Byte( _42 , (int)( (_43 - 1) ) ) ) ; 
                                            }
                                        
                                        __context__.SourceCodeLine = 17;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( _35( __context__ , ref _41 , (ushort)( _46 ) , (ushort)( _44 ) , (ushort)( (_45 - 1) ) ) ) || Functions.TestForTrue ( Functions.Not( _35( __context__ , ref _41 , (ushort)( Byte( _42 , (int)( _43 ) ) ) , (ushort)( _44 ) , (ushort)( (_45 - 1) ) ) ) )) ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 17;
                                            return (ushort)( 0) ; 
                                            } 
                                        
                                        __context__.SourceCodeLine = 17;
                                        _44 = (ushort) ( _45 ) ; 
                                        __context__.SourceCodeLine = 17;
                                        _48 = (ushort) ( 1 ) ; 
                                        } 
                                    
                                    else 
                                        { 
                                        __context__.SourceCodeLine = 17;
                                        if ( Functions.TestForTrue  ( ( _21( __context__ , (ushort)( Byte( _41._12 , (int)( (_44 + 1) ) ) ) ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 17;
                                            _43 = (ushort) ( _38( __context__ , ref _41 , _42 , (ushort)( _43 ) , (ushort)( Byte( _41._12 , (int)( (_44 + 1) ) ) ) ) ) ; 
                                            __context__.SourceCodeLine = 17;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_43 == 0))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 17;
                                                return (ushort)( 0) ; 
                                                } 
                                            
                                            __context__.SourceCodeLine = 17;
                                            _44 = (ushort) ( (_44 + 2) ) ; 
                                            __context__.SourceCodeLine = 17;
                                            _48 = (ushort) ( 1 ) ; 
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
                    
                
                __context__.SourceCodeLine = 17;
                if ( Functions.TestForTrue  ( ( Functions.Not( _48 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 18;
                    _45 = (ushort) ( _33( __context__ , ref _41 , (ushort)( _44 ) ) ) ; 
                    __context__.SourceCodeLine = 18;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _43 < _41._14 ) ) && Functions.TestForTrue ( _36( __context__ , ref _41 , (ushort)( Byte( _42 , (int)( _43 ) ) ) , (ushort)( _44 ) , (ushort)( _45 ) ) )) ))  ) ) 
                        {
                        __context__.SourceCodeLine = 18;
                        _47 = (short) ( 1 ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 18;
                        _47 = (short) ( 0 ) ; 
                        }
                    
                    __context__.SourceCodeLine = 18;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _45 >= _41._15 ))  ) ) 
                        {
                        __context__.SourceCodeLine = 18;
                        _49 = (ushort) ( 0 ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 18;
                        _49 = (ushort) ( Byte( _41._12 , (int)( _45 ) ) ) ; 
                        }
                    
                    __context__.SourceCodeLine = 18;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_49 == 63))  ) ) 
                        { 
                        __context__.SourceCodeLine = 18;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_47 != 0))  ) ) 
                            { 
                            __context__.SourceCodeLine = 18;
                            _47 = (short) ( _39( __context__ , ref _41 , _42 , (ushort)( (_43 + 1) ) , (ushort)( (_45 + 1) ) ) ) ; 
                            __context__.SourceCodeLine = 18;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_47 != 0))  ) ) 
                                { 
                                __context__.SourceCodeLine = 18;
                                return (ushort)( _47) ; 
                                } 
                            
                            } 
                        
                        __context__.SourceCodeLine = 18;
                        _44 = (ushort) ( (_45 + 1) ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 18;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_49 == 42) ) || Functions.TestForTrue ( Functions.BoolToInt (_49 == 43) )) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 18;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_49 == 43))  ) ) 
                                { 
                                __context__.SourceCodeLine = 18;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_47 == 0))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 18;
                                    return (ushort)( 0) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 18;
                                    _43 = (ushort) ( (_43 + 1) ) ; 
                                    }
                                
                                } 
                            
                            __context__.SourceCodeLine = 18;
                            _50 = (short) ( 0 ) ; 
                            __context__.SourceCodeLine = 18;
                            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (_43 + _50) < _41._14 ) ) && Functions.TestForTrue ( _36( __context__ , ref _41 , (ushort)( Byte( _42 , (int)( (_43 + _50) ) ) ) , (ushort)( _44 ) , (ushort)( _45 ) ) )) ))  ) ) 
                                {
                                __context__.SourceCodeLine = 18;
                                _50 = (short) ( (_50 + 1) ) ; 
                                __context__.SourceCodeLine = 18;
                                }
                            
                            __context__.SourceCodeLine = 18;
                            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _50 >= 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 18;
                                _51 = (ushort) ( _39( __context__ , ref _41 , _42 , (ushort)( (_43 + _50) ) , (ushort)( (_45 + 1) ) ) ) ; 
                                __context__.SourceCodeLine = 18;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _51 > 0 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 18;
                                    return (ushort)( _51) ; 
                                    } 
                                
                                __context__.SourceCodeLine = 18;
                                _50 = (short) ( (_50 - 1) ) ; 
                                __context__.SourceCodeLine = 18;
                                } 
                            
                            __context__.SourceCodeLine = 18;
                            return (ushort)( 0) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 18;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_49 == 45))  ) ) 
                                { 
                                __context__.SourceCodeLine = 18;
                                while ( Functions.TestForTrue  ( ( 1)  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 19;
                                    _51 = (ushort) ( _39( __context__ , ref _41 , _42 , (ushort)( _43 ) , (ushort)( (_45 + 1) ) ) ) ; 
                                    __context__.SourceCodeLine = 19;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_51 != 0))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 19;
                                        return (ushort)( _51) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 19;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _43 < _41._14 ) ) && Functions.TestForTrue ( _36( __context__ , ref _41 , (ushort)( Byte( _42 , (int)( _43 ) ) ) , (ushort)( _44 ) , (ushort)( _45 ) ) )) ))  ) ) 
                                            {
                                            __context__.SourceCodeLine = 19;
                                            _43 = (ushort) ( (_43 + 1) ) ; 
                                            }
                                        
                                        else 
                                            { 
                                            __context__.SourceCodeLine = 19;
                                            return (ushort)( 0) ; 
                                            } 
                                        
                                        }
                                    
                                    __context__.SourceCodeLine = 18;
                                    } 
                                
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 19;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_47 == 0))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 19;
                                    return (ushort)( 0) ; 
                                    } 
                                
                                __context__.SourceCodeLine = 19;
                                _43 = (ushort) ( (_43 + 1) ) ; 
                                __context__.SourceCodeLine = 19;
                                _44 = (ushort) ( _45 ) ; 
                                } 
                            
                            }
                        
                        }
                    
                    } 
                
                __context__.SourceCodeLine = 15;
                } 
            
            
            return 0; // default return value (none specified in module)
            }
            
        private ushort _40 (  SplusExecutionContext __context__, ref _7 _42 , ushort _43 , ushort _44 , ushort _45 ) 
            { 
            ushort _46 = 0;
            
            short _47 = 0;
            
            
            __context__.SourceCodeLine = 19;
            _46 = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 19;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _43 >= _42._16 ))  ) ) 
                { 
                __context__.SourceCodeLine = 19;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_43 == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 19;
                    _46 = (ushort) ( _30( __context__ , ref _42 , (ushort)( _44 ) , (ushort)( _45 ) ) ) ; 
                    }
                
                else 
                    { 
                    __context__.SourceCodeLine = 19;
                    _42 . _8  .UpdateValue ( "invalid capture index"  ) ; 
                    __context__.SourceCodeLine = 19;
                    _46 = (ushort) ( 0 ) ; 
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 19;
                _47 = (short) ( _42._18[ _43 ] ) ; 
                __context__.SourceCodeLine = 19;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_47 == Functions.ToSignedLongInteger( -( 1 ) )))  ) ) 
                    { 
                    __context__.SourceCodeLine = 19;
                    _42 . _8  .UpdateValue ( "unfinished capture"  ) ; 
                    __context__.SourceCodeLine = 19;
                    _46 = (ushort) ( 0 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 19;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_47 == Functions.ToSignedLongInteger( -( 2 ) )))  ) ) 
                        {
                        __context__.SourceCodeLine = 19;
                        _47 = (short) ( 0 ) ; 
                        }
                    
                    __context__.SourceCodeLine = 19;
                    _46 = (ushort) ( _30( __context__ , ref _42 , (ushort)( _42._17[ _43 ] ) , (ushort)( (_42._17[ _43 ] + _47) ) ) ) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 20;
            return (ushort)( _46) ; 
            
            }
            
        private ushort _41 (  SplusExecutionContext __context__, ref _7 _43 , ushort _44 , ushort _45 ) 
            { 
            ushort _46 = 0;
            
            ushort _47 = 0;
            
            
            __context__.SourceCodeLine = 20;
            _46 = (ushort) ( _29( __context__ , ref _43 , (ushort)( (_43._16 + 1) ) , "too many captures" ) ) ; 
            __context__.SourceCodeLine = 20;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _46 > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 20;
                _30 (  __context__ ,   ref  _43 , (ushort)( _44 ), (ushort)( _45 )) ; 
                __context__.SourceCodeLine = 20;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 0 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)(_46 - 2); 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( _47  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_47  >= __FN_FORSTART_VAL__1) && (_47  <= __FN_FOREND_VAL__1) ) : ( (_47  <= __FN_FORSTART_VAL__1) && (_47  >= __FN_FOREND_VAL__1) ) ; _47  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 20;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_40( __context__ , ref _43 , (ushort)( _47 ) , (ushort)( _44 ) , (ushort)( _45 ) ) == 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 20;
                        _46 = (ushort) ( _47 ) ; 
                        __context__.SourceCodeLine = 20;
                        break ; 
                        } 
                    
                    __context__.SourceCodeLine = 20;
                    } 
                
                } 
            
            __context__.SourceCodeLine = 20;
            return (ushort)( _46) ; 
            
            }
            
        private short _42 (  SplusExecutionContext __context__, CrestronString _44 , ushort _45 , ushort _46 , CrestronString _47 , ushort _48 , ushort _49 ) 
            { 
            
            __context__.SourceCodeLine = 20;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (_46 + _49) <= _45 ))  ) ) 
                { 
                __context__.SourceCodeLine = 20;
                _44  .UpdateValue ( Functions.Left ( _44 ,  (int) ( _46 ) ) + Functions.Mid ( _47 ,  (int) ( _48 ) ,  (int) ( _49 ) )  ) ; 
                __context__.SourceCodeLine = 20;
                return (short)( (_46 + _49)) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 20;
                _44  .UpdateValue ( "buffer overflow"  ) ; 
                __context__.SourceCodeLine = 20;
                return (short)( Functions.ToSignedInteger( -( 15 ) )) ; 
                } 
            
            
            return 0; // default return value (none specified in module)
            }
            
        private short _43 (  SplusExecutionContext __context__, ref _7 _45 , CrestronString _46 , ushort _47 , ushort _48 , CrestronString _49 , ushort _50 , ushort _51 , CrestronString _52 , ushort _53 ) 
            { 
            short _54 = 0;
            
            ushort _55 = 0;
            
            ushort _56 = 0;
            
            
            __context__.SourceCodeLine = 21;
            _54 = (short) ( _48 ) ; 
            __context__.SourceCodeLine = 21;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)_53; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( _55  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_55  >= __FN_FORSTART_VAL__1) && (_55  <= __FN_FOREND_VAL__1) ) : ( (_55  <= __FN_FORSTART_VAL__1) && (_55  >= __FN_FOREND_VAL__1) ) ; _55  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 21;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( _52 , (int)( _55 ) ) != 37))  ) ) 
                    {
                    __context__.SourceCodeLine = 21;
                    _54 = (short) ( _42( __context__ , _46 , (ushort)( _47 ) , (ushort)( _48 ) , _52 , (ushort)( _55 ) , (ushort)( 1 ) ) ) ; 
                    }
                
                else 
                    { 
                    __context__.SourceCodeLine = 21;
                    _55 = (ushort) ( (_55 + 1) ) ; 
                    __context__.SourceCodeLine = 21;
                    _56 = (ushort) ( Byte( _52 , (int)( _55 ) ) ) ; 
                    __context__.SourceCodeLine = 21;
                    if ( Functions.TestForTrue  ( ( Functions.Not( _21( __context__ , (ushort)( _56 ) ) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 21;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_56 == 37))  ) ) 
                            {
                            __context__.SourceCodeLine = 21;
                            _54 = (short) ( _42( __context__ , _46 , (ushort)( _47 ) , (ushort)( _48 ) , _52 , (ushort)( _55 ) , (ushort)( 1 ) ) ) ; 
                            }
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 21;
                            _46  .UpdateValue ( "invalid use of %c in replacement string"  ) ; 
                            __context__.SourceCodeLine = 21;
                            _54 = (short) ( Functions.ToSignedInteger( -( Functions.Length( _46 ) ) ) ) ; 
                            } 
                        
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 21;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_56 == 48))  ) ) 
                            {
                            __context__.SourceCodeLine = 21;
                            _54 = (short) ( _42( __context__ , _46 , (ushort)( _47 ) , (ushort)( _48 ) , _49 , (ushort)( _50 ) , (ushort)( (_51 - _50) ) ) ) ; 
                            }
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 21;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_40( __context__ , ref _45 , (ushort)( (_56 - 49) ) , (ushort)( _50 ) , (ushort)( _51 ) ) == 0))  ) ) 
                                { 
                                __context__.SourceCodeLine = 22;
                                _46  .UpdateValue ( _45 . _8  ) ; 
                                __context__.SourceCodeLine = 22;
                                _54 = (short) ( Functions.ToSignedInteger( -( Functions.Length( _46 ) ) ) ) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 22;
                                _54 = (short) ( _42( __context__ , _46 , (ushort)( _47 ) , (ushort)( _48 ) , _49 , (ushort)( ((_45._13 + _45._10[ (_45._9 - 1) ]) - 1) ) , (ushort)( (_45._11[ (_45._9 - 1) ] - _45._10[ (_45._9 - 1) ]) ) ) ) ; 
                                __context__.SourceCodeLine = 22;
                                _45 . _9 = (ushort) ( (_45._9 - 1) ) ; 
                                } 
                            
                            } 
                        
                        }
                    
                    } 
                
                __context__.SourceCodeLine = 22;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _54 < 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 22;
                    break ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 22;
                    _48 = (ushort) ( _54 ) ; 
                    }
                
                __context__.SourceCodeLine = 21;
                } 
            
            __context__.SourceCodeLine = 22;
            return (short)( _54) ; 
            
            }
            
        private ushort _44 (  SplusExecutionContext __context__, CrestronString _46 , ushort _47 , short _48 , CrestronString _12 , ushort _49 , ref _7 _50 ) 
            { 
            ushort _51 = 0;
            
            ushort _52 = 0;
            
            ushort _53 = 0;
            
            
            __context__.SourceCodeLine = 22;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _48 < 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 22;
                _48 = (short) ( ((_47 + _48) + 1) ) ; 
                }
            
            __context__.SourceCodeLine = 22;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _48 < 1 ))  ) ) 
                {
                __context__.SourceCodeLine = 22;
                _48 = (short) ( 1 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 22;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _48 > (_47 + 1) ))  ) ) 
                    {
                    __context__.SourceCodeLine = 22;
                    _48 = (short) ( (_47 + 1) ) ; 
                    }
                
                }
            
            __context__.SourceCodeLine = 22;
            _52 = (ushort) ( _48 ) ; 
            __context__.SourceCodeLine = 22;
            _51 = (ushort) ( _28( __context__ , ref _50 , (ushort)( _47 ) , _12 , (ushort)( _49 ) ) ) ; 
            __context__.SourceCodeLine = 22;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _52 < _50._14 ))  ) ) 
                { 
                __context__.SourceCodeLine = 22;
                do 
                    { 
                    __context__.SourceCodeLine = 22;
                    _50 . _16 = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 22;
                    _53 = (ushort) ( _39( __context__ , ref _50 , _46 , (ushort)( _52 ) , (ushort)( 1 ) ) ) ; 
                    __context__.SourceCodeLine = 22;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_53 != 0))  ) ) 
                        {
                        __context__.SourceCodeLine = 22;
                        return (ushort)( _41( __context__ , ref _50 , (ushort)( _52 ) , (ushort)( _53 ) )) ; 
                        }
                    
                    __context__.SourceCodeLine = 23;
                    _52 = (ushort) ( (_52 + 1) ) ; 
                    } 
                while (false == ( Functions.TestForTrue  ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _52 >= _50._14 ) ) || Functions.TestForTrue ( _51 )) )) )); 
                } 
            
            __context__.SourceCodeLine = 23;
            return (ushort)( 0) ; 
            
            }
            
        private ushort _45 (  SplusExecutionContext __context__, CrestronString _47 , short _48 , CrestronString _12 , ref _7 _49 ) 
            { 
            
            __context__.SourceCodeLine = 23;
            return (ushort)( _44( __context__ , _47 , (ushort)( Functions.Length( _47 ) ) , (short)( _48 ) , _12 , (ushort)( Functions.Length( _12 ) ) , ref _49 )) ; 
            
            }
            
        private short _46 (  SplusExecutionContext __context__, CrestronString _48 , ushort _49 , short _50 , CrestronString _12 , ushort _51 , CrestronString _52 , ushort REPLEN , short REPCOUNT , CrestronString BUFFER , ref ushort BUFFERLEN ) 
            { 
            ushort _53 = 0;
            
            short _54 = 0;
            
            short _55 = 0;
            
            ushort _56 = 0;
            
            ushort _57 = 0;
            
            _7 _58;
            _58  = new _7( this, true );
            _58 .PopulateCustomAttributeList( false );
            
            
            __context__.SourceCodeLine = 23;
            _54 = (short) ( 0 ) ; 
            __context__.SourceCodeLine = 23;
            _55 = (short) ( 0 ) ; 
            __context__.SourceCodeLine = 23;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( REPCOUNT <= 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 23;
                REPCOUNT = (short) ( (_49 + 1) ) ; 
                }
            
            __context__.SourceCodeLine = 23;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _50 < 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 23;
                _50 = (short) ( ((_49 + _50) + 1) ) ; 
                }
            
            __context__.SourceCodeLine = 23;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _50 < 1 ))  ) ) 
                {
                __context__.SourceCodeLine = 24;
                _50 = (short) ( 1 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 24;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _50 > (_49 + 1) ))  ) ) 
                    {
                    __context__.SourceCodeLine = 24;
                    _50 = (short) ( (_49 + 1) ) ; 
                    }
                
                }
            
            __context__.SourceCodeLine = 24;
            BUFFER  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 24;
            _56 = (ushort) ( _50 ) ; 
            __context__.SourceCodeLine = 24;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _56 > 1 ))  ) ) 
                {
                __context__.SourceCodeLine = 24;
                _55 = (short) ( _42( __context__ , BUFFER , (ushort)( BUFFERLEN ) , (ushort)( _55 ) , _48 , (ushort)( 1 ) , (ushort)( (_56 - 1) ) ) ) ; 
                }
            
            __context__.SourceCodeLine = 24;
            _53 = (ushort) ( _28( __context__ , ref _58 , (ushort)( _49 ) , _12 , (ushort)( _51 ) ) ) ; 
            __context__.SourceCodeLine = 24;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _54 < REPCOUNT ))  ) ) 
                { 
                __context__.SourceCodeLine = 24;
                _58 . _16 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 24;
                _58 . _9 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 24;
                _57 = (ushort) ( _39( __context__ , ref _58 , _48 , (ushort)( _56 ) , (ushort)( 1 ) ) ) ; 
                __context__.SourceCodeLine = 24;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( _58._8 ) != 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 24;
                    _55 = (short) ( Functions.Length( _58._8 ) ) ; 
                    __context__.SourceCodeLine = 24;
                    BUFFER  .UpdateValue ( _58 . _8  ) ; 
                    __context__.SourceCodeLine = 24;
                    _54 = (short) ( Functions.ToSignedInteger( -( 1 ) ) ) ; 
                    __context__.SourceCodeLine = 24;
                    break ; 
                    } 
                
                __context__.SourceCodeLine = 24;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_57 != 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 24;
                    _54 = (short) ( (_54 + 1) ) ; 
                    __context__.SourceCodeLine = 24;
                    _55 = (short) ( _43( __context__ , ref _58 , BUFFER , (ushort)( BUFFERLEN ) , (ushort)( _55 ) , _48 , (ushort)( _56 ) , (ushort)( _57 ) , _52 , (ushort)( REPLEN ) ) ) ; 
                    __context__.SourceCodeLine = 24;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _55 < 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 24;
                        _54 = (short) ( Functions.ToSignedInteger( -( 1 ) ) ) ; 
                        __context__.SourceCodeLine = 24;
                        _55 = (short) ( Functions.ToSignedInteger( -( _55 ) ) ) ; 
                        __context__.SourceCodeLine = 24;
                        break ; 
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 24;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _57 > _56 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 24;
                    _56 = (ushort) ( _57 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 24;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _56 < _58._14 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 24;
                        _55 = (short) ( _42( __context__ , BUFFER , (ushort)( BUFFERLEN ) , (ushort)( _55 ) , _48 , (ushort)( _56 ) , (ushort)( 1 ) ) ) ; 
                        __context__.SourceCodeLine = 24;
                        _56 = (ushort) ( (_56 + 1) ) ; 
                        __context__.SourceCodeLine = 24;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _55 < 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 24;
                            _54 = (short) ( Functions.ToSignedInteger( -( 1 ) ) ) ; 
                            __context__.SourceCodeLine = 24;
                            _55 = (short) ( Functions.ToSignedInteger( -( _55 ) ) ) ; 
                            __context__.SourceCodeLine = 24;
                            break ; 
                            } 
                        
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 24;
                        break ; 
                        }
                    
                    }
                
                __context__.SourceCodeLine = 24;
                if ( Functions.TestForTrue  ( ( _53)  ) ) 
                    {
                    __context__.SourceCodeLine = 25;
                    break ; 
                    }
                
                __context__.SourceCodeLine = 24;
                } 
            
            __context__.SourceCodeLine = 25;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _54 >= 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 25;
                _55 = (short) ( _42( __context__ , BUFFER , (ushort)( BUFFERLEN ) , (ushort)( _55 ) , _48 , (ushort)( _56 ) , (ushort)( (_58._14 - _56) ) ) ) ; 
                __context__.SourceCodeLine = 25;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _55 < 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 25;
                    _54 = (short) ( Functions.ToSignedInteger( -( 1 ) ) ) ; 
                    __context__.SourceCodeLine = 25;
                    _55 = (short) ( Functions.ToSignedInteger( -( _55 ) ) ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 25;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _55 < BUFFERLEN ))  ) ) 
                        { 
                        } 
                    
                    }
                
                } 
            
            __context__.SourceCodeLine = 25;
            BUFFERLEN = (ushort) ( _55 ) ; 
            __context__.SourceCodeLine = 25;
            return (short)( _54) ; 
            
            }
            
        private short _47 (  SplusExecutionContext __context__, CrestronString _49 , short _50 , CrestronString _12 , CrestronString _51 , short _52 , CrestronString BUFFER , ref ushort BUFFERLEN ) 
            { 
            
            __context__.SourceCodeLine = 25;
            return (short)( _46( __context__ , _49 , (ushort)( Functions.Length( _49 ) ) , (short)( _50 ) , _12 , (ushort)( Functions.Length( _12 ) ) , _51 , (ushort)( Functions.Length( _51 ) ) , (short)( _52 ) , BUFFER , ref BUFFERLEN )) ; 
            
            }
            
        private ushort _55 (  SplusExecutionContext __context__, ref _48 _57 ) 
            { 
            ushort _58 = 0;
            
            
            __context__.SourceCodeLine = 26;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_57._52 == _57._51) ) && Functions.TestForTrue ( Functions.BoolToInt (_57._54 == 0) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 26;
                _58 = (ushort) ( 1 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 26;
                _58 = (ushort) ( 0 ) ; 
                } 
            
            __context__.SourceCodeLine = 26;
            return (ushort)( _58) ; 
            
            }
            
        private ushort _56 (  SplusExecutionContext __context__, ref _48 _58 ) 
            { 
            
            __context__.SourceCodeLine = 26;
            return (ushort)( _55( __context__ , ref _58 )) ; 
            
            }
            
        private ushort _57 (  SplusExecutionContext __context__, ref _48 _59 ) 
            { 
            ushort _60 = 0;
            
            
            __context__.SourceCodeLine = 26;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_59._52 == _59._51) ) && Functions.TestForTrue ( Functions.BoolToInt (_59._54 != 0) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 26;
                _60 = (ushort) ( 1 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 26;
                _60 = (ushort) ( 0 ) ; 
                } 
            
            __context__.SourceCodeLine = 26;
            return (ushort)( _60) ; 
            
            }
            
        private ushort _58 (  SplusExecutionContext __context__, ref _48 _60 ) 
            { 
            ushort _61 = 0;
            
            
            __context__.SourceCodeLine = 26;
            if ( Functions.TestForTrue  ( ( _55( __context__ , ref _60 ))  ) ) 
                { 
                __context__.SourceCodeLine = 26;
                _61 = (ushort) ( _60._53 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 26;
                _61 = (ushort) ( _60._51 ) ; 
                } 
            
            __context__.SourceCodeLine = 26;
            return (ushort)( _61) ; 
            
            }
            
        private ushort _59 (  SplusExecutionContext __context__, ref _48 _61 ) 
            { 
            ushort _62 = 0;
            
            
            __context__.SourceCodeLine = 26;
            if ( Functions.TestForTrue  ( ( _55( __context__ , ref _61 ))  ) ) 
                { 
                __context__.SourceCodeLine = 26;
                _62 = (ushort) ( _61._53 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 26;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_61._52 == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 26;
                    _62 = (ushort) ( (_61._53 - 1) ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 26;
                    _62 = (ushort) ( (_61._52 - 1) ) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 26;
            return (ushort)( _62) ; 
            
            }
            
        private ushort _60 (  SplusExecutionContext __context__, ref _48 _62 ) 
            { 
            
            __context__.SourceCodeLine = 27;
            return (ushort)( _58( __context__ , ref _62 )) ; 
            
            }
            
        private ushort _61 (  SplusExecutionContext __context__, ref _48 _63 ) 
            { 
            
            __context__.SourceCodeLine = 27;
            return (ushort)( _59( __context__ , ref _63 )) ; 
            
            }
            
        private ushort _62 (  SplusExecutionContext __context__, ref _48 _64 ) 
            { 
            ushort _65 = 0;
            
            
            __context__.SourceCodeLine = 27;
            if ( Functions.TestForTrue  ( ( _57( __context__ , ref _64 ))  ) ) 
                { 
                __context__.SourceCodeLine = 27;
                _65 = (ushort) ( _64._53 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 27;
                _65 = (ushort) ( _64._52 ) ; 
                __context__.SourceCodeLine = 27;
                _64 . _52 = (ushort) ( (_64._52 + 1) ) ; 
                __context__.SourceCodeLine = 27;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_64._52 == _64._53))  ) ) 
                    { 
                    __context__.SourceCodeLine = 27;
                    _64 . _54 = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 27;
                    _64 . _52 = (ushort) ( 0 ) ; 
                    } 
                
                __context__.SourceCodeLine = 27;
                _64 . _49 = (ushort) ( _58( __context__ , ref _64 ) ) ; 
                __context__.SourceCodeLine = 27;
                _64 . _50 = (ushort) ( _59( __context__ , ref _64 ) ) ; 
                } 
            
            __context__.SourceCodeLine = 27;
            return (ushort)( _65) ; 
            
            }
            
        private ushort _63 (  SplusExecutionContext __context__, _48 _65 ) 
            { 
            ushort _66 = 0;
            
            
            __context__.SourceCodeLine = 27;
            if ( Functions.TestForTrue  ( ( _55( __context__ , ref _65 ))  ) ) 
                { 
                __context__.SourceCodeLine = 27;
                _66 = (ushort) ( _65._53 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 27;
                _66 = (ushort) ( _65._51 ) ; 
                __context__.SourceCodeLine = 27;
                _65 . _51 = (ushort) ( (_65._51 + 1) ) ; 
                __context__.SourceCodeLine = 27;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_65._51 == _65._53))  ) ) 
                    { 
                    __context__.SourceCodeLine = 27;
                    _65 . _54 = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 27;
                    _65 . _51 = (ushort) ( 0 ) ; 
                    } 
                
                __context__.SourceCodeLine = 27;
                _65 . _49 = (ushort) ( _58( __context__ , ref _65 ) ) ; 
                __context__.SourceCodeLine = 27;
                _65 . _50 = (ushort) ( _59( __context__ , ref _65 ) ) ; 
                } 
            
            __context__.SourceCodeLine = 27;
            return (ushort)( _66) ; 
            
            }
            
        private void _64 (  SplusExecutionContext __context__, ref _48 _66 ) 
            { 
            
            __context__.SourceCodeLine = 27;
            _66 . _51 = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 27;
            _66 . _52 = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 28;
            _66 . _49 = (ushort) ( _58( __context__ , ref _66 ) ) ; 
            __context__.SourceCodeLine = 28;
            _66 . _50 = (ushort) ( _59( __context__ , ref _66 ) ) ; 
            __context__.SourceCodeLine = 28;
            _66 . _54 = (ushort) ( 0 ) ; 
            
            }
            
        private void _65 (  SplusExecutionContext __context__, ref _48 _67 , ushort _68 ) 
            { 
            
            __context__.SourceCodeLine = 28;
            _64 (  __context__ ,   ref  _67 ) ; 
            __context__.SourceCodeLine = 28;
            _67 . _53 = (ushort) ( _68 ) ; 
            
            }
            
        private ushort _66 (  SplusExecutionContext __context__, ref _48 _68 , ushort _69 ) 
            { 
            ushort _70 = 0;
            ushort _71 = 0;
            ushort _72 = 0;
            
            
            __context__.SourceCodeLine = 28;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _69 >= _68._53 ))  ) ) 
                { 
                __context__.SourceCodeLine = 28;
                _70 = (ushort) ( _68._53 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 28;
                _70 = (ushort) ( (_69 + 1) ) ; 
                __context__.SourceCodeLine = 28;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_70 == _68._53))  ) ) 
                    { 
                    __context__.SourceCodeLine = 28;
                    _70 = (ushort) ( 0 ) ; 
                    } 
                
                __context__.SourceCodeLine = 28;
                _71 = (ushort) ( _58( __context__ , ref _68 ) ) ; 
                __context__.SourceCodeLine = 28;
                _72 = (ushort) ( _59( __context__ , ref _68 ) ) ; 
                __context__.SourceCodeLine = 28;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _71 < _72 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 28;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _70 <= _71 ) ) || Functions.TestForTrue ( Functions.BoolToInt ( _70 > _72 ) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 28;
                        _70 = (ushort) ( _68._53 ) ; 
                        } 
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 28;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_71 == _72))  ) ) 
                        { 
                        __context__.SourceCodeLine = 28;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (0 == _68._54))  ) ) 
                            { 
                            __context__.SourceCodeLine = 28;
                            _70 = (ushort) ( _68._53 ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 28;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_70 == _72))  ) ) 
                                { 
                                __context__.SourceCodeLine = 28;
                                _70 = (ushort) ( _68._53 ) ; 
                                } 
                            
                            } 
                        
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 28;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _70 <= _71 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _70 > _72 ) )) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 28;
                            _70 = (ushort) ( _68._53 ) ; 
                            } 
                        
                        } 
                    
                    }
                
                } 
            
            __context__.SourceCodeLine = 28;
            return (ushort)( _70) ; 
            
            }
            
        private ushort _67 (  SplusExecutionContext __context__, ref _48 _69 ) 
            { 
            ushort _70 = 0;
            
            
            __context__.SourceCodeLine = 29;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_69._54 == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 29;
                _70 = (ushort) ( (_69._52 - _69._51) ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 29;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_69._52 == _69._51))  ) ) 
                    { 
                    __context__.SourceCodeLine = 29;
                    _70 = (ushort) ( _69._53 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 29;
                    _70 = (ushort) ( ((_69._53 - _69._51) + _69._52) ) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 29;
            return (ushort)( _70) ; 
            
            }
            
        private void _68 (  SplusExecutionContext __context__, ushort [] _70 , ushort [] _71 , ushort [] _72 ) 
            { 
            
            __context__.SourceCodeLine = 29;
            _70 [ 0] = (ushort) ( 254 ) ; 
            __context__.SourceCodeLine = 29;
            _70 [ 1] = (ushort) ( 126 ) ; 
            __context__.SourceCodeLine = 29;
            _70 [ 2] = (ushort) ( 62 ) ; 
            __context__.SourceCodeLine = 29;
            _70 [ 3] = (ushort) ( 30 ) ; 
            __context__.SourceCodeLine = 29;
            _70 [ 4] = (ushort) ( 14 ) ; 
            __context__.SourceCodeLine = 29;
            _70 [ 5] = (ushort) ( 6 ) ; 
            __context__.SourceCodeLine = 29;
            _70 [ 6] = (ushort) ( 2 ) ; 
            __context__.SourceCodeLine = 29;
            _71 [ 0] = (ushort) ( 128 ) ; 
            __context__.SourceCodeLine = 29;
            _71 [ 1] = (ushort) ( 192 ) ; 
            __context__.SourceCodeLine = 29;
            _71 [ 2] = (ushort) ( 224 ) ; 
            __context__.SourceCodeLine = 29;
            _71 [ 3] = (ushort) ( 240 ) ; 
            __context__.SourceCodeLine = 29;
            _71 [ 4] = (ushort) ( 248 ) ; 
            __context__.SourceCodeLine = 29;
            _71 [ 5] = (ushort) ( 252 ) ; 
            __context__.SourceCodeLine = 29;
            _71 [ 6] = (ushort) ( 254 ) ; 
            __context__.SourceCodeLine = 29;
            _72 [ 0] = (ushort) ( 9 ) ; 
            __context__.SourceCodeLine = 29;
            _72 [ 1] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 29;
            _72 [ 2] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 29;
            _72 [ 3] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 29;
            _72 [ 4] = (ushort) ( 44 ) ; 
            __context__.SourceCodeLine = 29;
            _72 [ 5] = (ushort) ( 3 ) ; 
            __context__.SourceCodeLine = 29;
            _72 [ 6] = (ushort) ( 55 ) ; 
            __context__.SourceCodeLine = 29;
            _72 [ 7] = (ushort) ( 18 ) ; 
            __context__.SourceCodeLine = 29;
            _72 [ 8] = (ushort) ( 58 ) ; 
            __context__.SourceCodeLine = 29;
            _72 [ 9] = (ushort) ( 33 ) ; 
            __context__.SourceCodeLine = 29;
            _72 [ 10] = (ushort) ( 43 ) ; 
            __context__.SourceCodeLine = 29;
            _72 [ 11] = (ushort) ( 24 ) ; 
            __context__.SourceCodeLine = 29;
            _72 [ 12] = (ushort) ( 60 ) ; 
            __context__.SourceCodeLine = 30;
            _72 [ 13] = (ushort) ( 51 ) ; 
            __context__.SourceCodeLine = 30;
            _72 [ 14] = (ushort) ( 7 ) ; 
            __context__.SourceCodeLine = 30;
            _72 [ 15] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 30;
            _72 [ 16] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 30;
            _72 [ 17] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 30;
            _72 [ 18] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 30;
            _72 [ 19] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 30;
            _72 [ 20] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 30;
            _72 [ 21] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 30;
            _72 [ 22] = (ushort) ( 61 ) ; 
            __context__.SourceCodeLine = 30;
            _72 [ 23] = (ushort) ( 48 ) ; 
            __context__.SourceCodeLine = 30;
            _72 [ 24] = (ushort) ( 56 ) ; 
            __context__.SourceCodeLine = 30;
            _72 [ 25] = (ushort) ( 46 ) ; 
            __context__.SourceCodeLine = 30;
            _72 [ 26] = (ushort) ( 52 ) ; 
            __context__.SourceCodeLine = 30;
            _72 [ 27] = (ushort) ( 38 ) ; 
            __context__.SourceCodeLine = 30;
            _72 [ 28] = (ushort) ( 39 ) ; 
            __context__.SourceCodeLine = 30;
            _72 [ 29] = (ushort) ( 36 ) ; 
            __context__.SourceCodeLine = 30;
            _72 [ 30] = (ushort) ( 31 ) ; 
            __context__.SourceCodeLine = 30;
            _72 [ 31] = (ushort) ( 59 ) ; 
            __context__.SourceCodeLine = 30;
            _72 [ 32] = (ushort) ( 30 ) ; 
            __context__.SourceCodeLine = 30;
            _72 [ 33] = (ushort) ( 20 ) ; 
            __context__.SourceCodeLine = 30;
            _72 [ 34] = (ushort) ( 45 ) ; 
            __context__.SourceCodeLine = 30;
            _72 [ 35] = (ushort) ( 37 ) ; 
            __context__.SourceCodeLine = 30;
            _72 [ 36] = (ushort) ( 62 ) ; 
            __context__.SourceCodeLine = 30;
            _72 [ 37] = (ushort) ( 14 ) ; 
            __context__.SourceCodeLine = 30;
            _72 [ 38] = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 30;
            _72 [ 39] = (ushort) ( 15 ) ; 
            __context__.SourceCodeLine = 30;
            _72 [ 40] = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 30;
            _72 [ 41] = (ushort) ( 23 ) ; 
            __context__.SourceCodeLine = 30;
            _72 [ 42] = (ushort) ( 5 ) ; 
            __context__.SourceCodeLine = 30;
            _72 [ 43] = (ushort) ( 50 ) ; 
            __context__.SourceCodeLine = 30;
            _72 [ 44] = (ushort) ( 13 ) ; 
            __context__.SourceCodeLine = 30;
            _72 [ 45] = (ushort) ( 19 ) ; 
            __context__.SourceCodeLine = 30;
            _72 [ 46] = (ushort) ( 10 ) ; 
            __context__.SourceCodeLine = 30;
            _72 [ 47] = (ushort) ( 27 ) ; 
            __context__.SourceCodeLine = 30;
            _72 [ 48] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 30;
            _72 [ 49] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 30;
            _72 [ 50] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 30;
            _72 [ 51] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 31;
            _72 [ 52] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 31;
            _72 [ 53] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 31;
            _72 [ 54] = (ushort) ( 28 ) ; 
            __context__.SourceCodeLine = 31;
            _72 [ 55] = (ushort) ( 49 ) ; 
            __context__.SourceCodeLine = 31;
            _72 [ 56] = (ushort) ( 63 ) ; 
            __context__.SourceCodeLine = 31;
            _72 [ 57] = (ushort) ( 57 ) ; 
            __context__.SourceCodeLine = 31;
            _72 [ 58] = (ushort) ( 22 ) ; 
            __context__.SourceCodeLine = 31;
            _72 [ 59] = (ushort) ( 40 ) ; 
            __context__.SourceCodeLine = 31;
            _72 [ 60] = (ushort) ( 41 ) ; 
            __context__.SourceCodeLine = 31;
            _72 [ 61] = (ushort) ( 12 ) ; 
            __context__.SourceCodeLine = 31;
            _72 [ 62] = (ushort) ( 47 ) ; 
            __context__.SourceCodeLine = 31;
            _72 [ 63] = (ushort) ( 34 ) ; 
            __context__.SourceCodeLine = 31;
            _72 [ 64] = (ushort) ( 2 ) ; 
            __context__.SourceCodeLine = 31;
            _72 [ 65] = (ushort) ( 16 ) ; 
            __context__.SourceCodeLine = 31;
            _72 [ 66] = (ushort) ( 6 ) ; 
            __context__.SourceCodeLine = 31;
            _72 [ 67] = (ushort) ( 11 ) ; 
            __context__.SourceCodeLine = 31;
            _72 [ 68] = (ushort) ( 32 ) ; 
            __context__.SourceCodeLine = 31;
            _72 [ 69] = (ushort) ( 21 ) ; 
            __context__.SourceCodeLine = 31;
            _72 [ 70] = (ushort) ( 8 ) ; 
            __context__.SourceCodeLine = 31;
            _72 [ 71] = (ushort) ( 4 ) ; 
            __context__.SourceCodeLine = 31;
            _72 [ 72] = (ushort) ( 26 ) ; 
            __context__.SourceCodeLine = 31;
            _72 [ 73] = (ushort) ( 29 ) ; 
            __context__.SourceCodeLine = 31;
            _72 [ 74] = (ushort) ( 17 ) ; 
            __context__.SourceCodeLine = 31;
            _72 [ 75] = (ushort) ( 42 ) ; 
            __context__.SourceCodeLine = 31;
            _72 [ 76] = (ushort) ( 53 ) ; 
            __context__.SourceCodeLine = 31;
            _72 [ 77] = (ushort) ( 54 ) ; 
            __context__.SourceCodeLine = 31;
            _72 [ 78] = (ushort) ( 35 ) ; 
            __context__.SourceCodeLine = 31;
            _72 [ 79] = (ushort) ( 25 ) ; 
            
            }
            
        private void _69 (  SplusExecutionContext __context__, CrestronString _71 , ushort [] _72 , ushort _73 ) 
            { 
            CrestronString _74;
            _74  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 512, this );
            
            ushort _75 = 0;
            ushort _76 = 0;
            
            
            __context__.SourceCodeLine = 31;
            _76 = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 31;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)_73; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( _75  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_75  >= __FN_FORSTART_VAL__1) && (_75  <= __FN_FOREND_VAL__1) ) : ( (_75  <= __FN_FORSTART_VAL__1) && (_75  >= __FN_FOREND_VAL__1) ) ; _75  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 31;
                _74  .UpdateValue ( _74 + Functions.ItoHex (  (int) ( _72[ (_75 - 1) ] ) ) + " "  ) ; 
                __context__.SourceCodeLine = 32;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Mod( _75 , 16 ) == 0) ) || Functions.TestForTrue ( Functions.BoolToInt (_75 == _73) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 32;
                    _74  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 32;
                    _76 = (ushort) ( (_76 + 1) ) ; 
                    } 
                
                __context__.SourceCodeLine = 31;
                } 
            
            
            }
            
        private uint _70 (  SplusExecutionContext __context__, uint [] _72 , ref ushort _73 ) 
            { 
            uint _74 = 0;
            uint _75 = 0;
            uint _76 = 0;
            uint _77 = 0;
            
            
            __context__.SourceCodeLine = 32;
            _74 = (uint) ( _72[ _73 ] ) ; 
            __context__.SourceCodeLine = 32;
            _75 = (uint) ( _72[ ((_73 + 13) & 15) ] ) ; 
            __context__.SourceCodeLine = 32;
            _76 = (uint) ( (((_74 ^ _75) ^ (_74 << 16)) ^ (_75 << 15)) ) ; 
            __context__.SourceCodeLine = 32;
            _75 = (uint) ( _72[ ((_73 + 9) & 15) ] ) ; 
            __context__.SourceCodeLine = 32;
            _75 = (uint) ( (_75 ^ (_75 >> 11)) ) ; 
            __context__.SourceCodeLine = 32;
            _72 [ _73] = (uint) ( (_76 ^ _75) ) ; 
            __context__.SourceCodeLine = 32;
            _74 = (uint) ( _72[ _73 ] ) ; 
            __context__.SourceCodeLine = 32;
            _77 = (uint) ( (_74 ^ ((_74 << 5) & 3661901088)) ) ; 
            __context__.SourceCodeLine = 32;
            _73 = (ushort) ( ((_73 + 15) & 15) ) ; 
            __context__.SourceCodeLine = 32;
            _74 = (uint) ( _72[ _73 ] ) ; 
            __context__.SourceCodeLine = 32;
            _72 [ _73] = (uint) ( (((((_74 ^ _76) ^ _77) ^ (_74 << 2)) ^ (_76 << 18)) ^ (_75 << 28)) ) ; 
            __context__.SourceCodeLine = 32;
            return (uint)( _72[ _73 ]) ; 
            
            }
            
        private void _71 (  SplusExecutionContext __context__, uint _73 , ref uint [] _74 , ref ushort _75 ) 
            { 
            ushort _76 = 0;
            
            uint _77 = 0;
            
            
            __context__.SourceCodeLine = 33;
            _77 = (uint) ( 0 ) ; 
            __context__.SourceCodeLine = 33;
            _75 = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 33;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 0 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)15; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( _76  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_76  >= __FN_FORSTART_VAL__1) && (_76  <= __FN_FOREND_VAL__1) ) : ( (_76  <= __FN_FORSTART_VAL__1) && (_76  >= __FN_FOREND_VAL__1) ) ; _76  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 33;
                _74 [ _76] = (uint) ( ((_73 + _77) ^ (1431655765 >> _76)) ) ; 
                __context__.SourceCodeLine = 33;
                _77 = (uint) ( (_77 + 7623293) ) ; 
                __context__.SourceCodeLine = 33;
                } 
            
            
            }
            
        private ushort _72 (  SplusExecutionContext __context__, CrestronString _74 , ushort _75 , ref ushort [] _76 , ref CrestronString [] _77 ) 
            { 
            ushort _78 = 0;
            
            ushort _79 = 0;
            
            ushort [] _80;
            _80  = new ushort[ 257 ];
            
            uint [] _81;
            _81  = new uint[ 257 ];
            
            uint _82 = 0;
            
            ushort _83 = 0;
            
            ushort [] _84;
            _84  = new ushort[ 4 ];
            
            short _85 = 0;
            short _86 = 0;
            
            ushort _87 = 0;
            ushort _88 = 0;
            
            ushort _89 = 0;
            
            uint _90 = 0;
            
            ushort _91 = 0;
            
            ushort _92 = 0;
            
            ushort [] _93;
            _93  = new ushort[ 7 ];
            
            ushort [] _94;
            _94  = new ushort[ 7 ];
            
            ushort [] _95;
            _95  = new ushort[ 80 ];
            
            uint [] _96;
            _96  = new uint[ 17 ];
            
            ushort _97 = 0;
            
            uint _98 = 0;
            
            
            __context__.SourceCodeLine = 33;
            _68 (  __context__ , (ushort[])( _93 ), (ushort[])( _94 ), (ushort[])( _95 )) ; 
            __context__.SourceCodeLine = 33;
            _79 = (ushort) ( Functions.Length( _74 ) ) ; 
            __context__.SourceCodeLine = 34;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _79 < 44 ) ) || Functions.TestForTrue ( Functions.BoolToInt (Mod( _79 , 4 ) != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( ((_79 * 3) / 4) > 256 ) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 34;
                _78 = (ushort) ( 0 ) ; 
                }
            
            else 
                { 
                __context__.SourceCodeLine = 34;
                _82 = (uint) ( 0 ) ; 
                __context__.SourceCodeLine = 34;
                _83 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 34;
                short __FN_FORSTART_VAL__1 = (short) ( 0 ) ;
                short __FN_FOREND_VAL__1 = (short)(_79 - 1); 
                int __FN_FORSTEP_VAL__1 = (int)4; 
                for ( _85  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_85  >= __FN_FORSTART_VAL__1) && (_85  <= __FN_FOREND_VAL__1) ) : ( (_85  <= __FN_FORSTART_VAL__1) && (_85  >= __FN_FOREND_VAL__1) ) ; _85  += (short)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 34;
                    short __FN_FORSTART_VAL__2 = (short) ( 0 ) ;
                    short __FN_FOREND_VAL__2 = (short)3; 
                    int __FN_FORSTEP_VAL__2 = (int)1; 
                    for ( _86  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (_86  >= __FN_FORSTART_VAL__2) && (_86  <= __FN_FOREND_VAL__2) ) : ( (_86  <= __FN_FORSTART_VAL__2) && (_86  >= __FN_FOREND_VAL__2) ) ; _86  += (short)__FN_FORSTEP_VAL__2) 
                        { 
                        __context__.SourceCodeLine = 34;
                        _89 = (ushort) ( Byte( _74 , (int)( ((_85 + _86) + 1) ) ) ) ; 
                        __context__.SourceCodeLine = 34;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _89 >= 43 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _89 <= 122 ) )) ))  ) ) 
                            {
                            __context__.SourceCodeLine = 34;
                            _84 [ _86] = (ushort) ( _95[ (_89 - 43) ] ) ; 
                            }
                        
                        else 
                            {
                            __context__.SourceCodeLine = 34;
                            _84 [ _86] = (ushort) ( 255 ) ; 
                            }
                        
                        __context__.SourceCodeLine = 34;
                        } 
                    
                    __context__.SourceCodeLine = 34;
                    _80 [ _83] = (ushort) ( (((_84[ 0 ] << 2) | (_84[ 1 ] >> 4)) & 255) ) ; 
                    __context__.SourceCodeLine = 34;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_84[ 2 ] != 255))  ) ) 
                        { 
                        __context__.SourceCodeLine = 34;
                        _83 = (ushort) ( (_83 + 1) ) ; 
                        __context__.SourceCodeLine = 34;
                        _80 [ _83] = (ushort) ( (((_84[ 1 ] << 4) | (_84[ 2 ] >> 2)) & 255) ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 34;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_84[ 3 ] != 255))  ) ) 
                        { 
                        __context__.SourceCodeLine = 34;
                        _83 = (ushort) ( (_83 + 1) ) ; 
                        __context__.SourceCodeLine = 34;
                        _80 [ _83] = (ushort) ( ((((_84[ 2 ] << 6) & 192) | _84[ 3 ]) & 255) ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 34;
                    _83 = (ushort) ( (_83 + 1) ) ; 
                    __context__.SourceCodeLine = 34;
                    } 
                
                __context__.SourceCodeLine = 34;
                short __FN_FORSTART_VAL__3 = (short) ( 0 ) ;
                short __FN_FOREND_VAL__3 = (short)27; 
                int __FN_FORSTEP_VAL__3 = (int)1; 
                for ( _85  = __FN_FORSTART_VAL__3; (__FN_FORSTEP_VAL__3 > 0)  ? ( (_85  >= __FN_FORSTART_VAL__3) && (_85  <= __FN_FOREND_VAL__3) ) : ( (_85  <= __FN_FORSTART_VAL__3) && (_85  >= __FN_FOREND_VAL__3) ) ; _85  += (short)__FN_FORSTEP_VAL__3) 
                    { 
                    __context__.SourceCodeLine = 34;
                    _87 = (ushort) ( Mod( _85 , 7 ) ) ; 
                    __context__.SourceCodeLine = 34;
                    _88 = (ushort) ( (_85 / 7) ) ; 
                    __context__.SourceCodeLine = 34;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ((_80[ _85 ] & 1) != 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 34;
                        _82 = (uint) ( (_82 | (1 << _85)) ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 34;
                    _80 [ _85] = (ushort) ( ((((_80[ (_85 + _88) ] & _93[ _87 ]) << _87) | ((_80[ ((_85 + _88) + 1) ] & _94[ _87 ]) >> (7 - _87))) & 255) ) ; 
                    __context__.SourceCodeLine = 34;
                    } 
                
                __context__.SourceCodeLine = 35;
                short __FN_FORSTART_VAL__4 = (short) ( 28 ) ;
                short __FN_FOREND_VAL__4 = (short)31; 
                int __FN_FORSTEP_VAL__4 = (int)1; 
                for ( _85  = __FN_FORSTART_VAL__4; (__FN_FORSTEP_VAL__4 > 0)  ? ( (_85  >= __FN_FORSTART_VAL__4) && (_85  <= __FN_FOREND_VAL__4) ) : ( (_85  <= __FN_FORSTART_VAL__4) && (_85  >= __FN_FOREND_VAL__4) ) ; _85  += (short)__FN_FORSTEP_VAL__4) 
                    { 
                    __context__.SourceCodeLine = 35;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ((_80[ _85 ] & 1) != 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 35;
                        _82 = (uint) ( (_82 ^ (1 << _85)) ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 35;
                    } 
                
                __context__.SourceCodeLine = 35;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _83 > 32 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 35;
                    short __FN_FORSTART_VAL__5 = (short) ( 32 ) ;
                    short __FN_FOREND_VAL__5 = (short)(_83 - 1); 
                    int __FN_FORSTEP_VAL__5 = (int)1; 
                    for ( _85  = __FN_FORSTART_VAL__5; (__FN_FORSTEP_VAL__5 > 0)  ? ( (_85  >= __FN_FORSTART_VAL__5) && (_85  <= __FN_FOREND_VAL__5) ) : ( (_85  <= __FN_FORSTART_VAL__5) && (_85  >= __FN_FOREND_VAL__5) ) ; _85  += (short)__FN_FORSTEP_VAL__5) 
                        { 
                        __context__.SourceCodeLine = 35;
                        _80 [ (_85 - 4)] = (ushort) ( _80[ _85 ] ) ; 
                        __context__.SourceCodeLine = 35;
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 35;
                _83 = (ushort) ( (_83 - 4) ) ; 
                __context__.SourceCodeLine = 35;
                _71 (  __context__ , (uint)( _82 ),   ref  _96 ,   ref  _97 ) ; 
                __context__.SourceCodeLine = 35;
                short __FN_FORSTART_VAL__6 = (short) ( 0 ) ;
                short __FN_FOREND_VAL__6 = (short)(_83 - 1); 
                int __FN_FORSTEP_VAL__6 = (int)1; 
                for ( _85  = __FN_FORSTART_VAL__6; (__FN_FORSTEP_VAL__6 > 0)  ? ( (_85  >= __FN_FORSTART_VAL__6) && (_85  <= __FN_FOREND_VAL__6) ) : ( (_85  <= __FN_FORSTART_VAL__6) && (_85  >= __FN_FOREND_VAL__6) ) ; _85  += (short)__FN_FORSTEP_VAL__6) 
                    { 
                    __context__.SourceCodeLine = 35;
                    _98 = (uint) ( (_83 - _85) ) ; 
                    __context__.SourceCodeLine = 35;
                    _81 [ _85] = (uint) ( (_70( __context__ , (uint[])( _96 ) , ref _97 ) >> 1) ) ; 
                    __context__.SourceCodeLine = 35;
                    _81 [ _85] = (uint) ( (Mod( _81[ _85 ] , _98 ) + _85) ) ; 
                    __context__.SourceCodeLine = 35;
                    _98 = (uint) ( _70( __context__ , (uint[])( _96 ) , ref _97 ) ) ; 
                    __context__.SourceCodeLine = 35;
                    _80 [ _85] = (ushort) ( (_80[ _85 ] ^ (_98 & 255)) ) ; 
                    __context__.SourceCodeLine = 35;
                    } 
                
                __context__.SourceCodeLine = 35;
                short __FN_FORSTART_VAL__7 = (short) ( (_83 - 1) ) ;
                short __FN_FOREND_VAL__7 = (short)0; 
                int __FN_FORSTEP_VAL__7 = (int)Functions.ToLongInteger( -( 1 ) ); 
                for ( _85  = __FN_FORSTART_VAL__7; (__FN_FORSTEP_VAL__7 > 0)  ? ( (_85  >= __FN_FORSTART_VAL__7) && (_85  <= __FN_FOREND_VAL__7) ) : ( (_85  <= __FN_FORSTART_VAL__7) && (_85  >= __FN_FOREND_VAL__7) ) ; _85  += (short)__FN_FORSTEP_VAL__7) 
                    { 
                    __context__.SourceCodeLine = 35;
                    _90 = (uint) ( _81[ _85 ] ) ; 
                    __context__.SourceCodeLine = 35;
                    _91 = (ushort) ( _80[ _90 ] ) ; 
                    __context__.SourceCodeLine = 35;
                    _80 [ _90] = (ushort) ( _80[ _85 ] ) ; 
                    __context__.SourceCodeLine = 35;
                    _80 [ _85] = (ushort) ( _91 ) ; 
                    __context__.SourceCodeLine = 35;
                    } 
                
                __context__.SourceCodeLine = 35;
                _85 = (short) ( 0 ) ; 
                __context__.SourceCodeLine = 35;
                _78 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 35;
                while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _85 < _83 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _78 < _75 ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 35;
                    _92 = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 35;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (_85 + 3) <= _83 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 35;
                        _76 [ _78] = (ushort) ( ((_80[ _85 ] << 8) | _80[ (_85 + 1) ]) ) ; 
                        __context__.SourceCodeLine = 35;
                        _92 = (ushort) ( _80[ (_85 + 2) ] ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 36;
                    _85 = (short) ( (_85 + 3) ) ; 
                    __context__.SourceCodeLine = 36;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (_85 + _92) > _83 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 36;
                        _78 = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 36;
                        break ; 
                        } 
                    
                    __context__.SourceCodeLine = 36;
                    _77 [ _78]  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 36;
                    short __FN_FORSTART_VAL__8 = (short) ( 0 ) ;
                    short __FN_FOREND_VAL__8 = (short)(_92 - 1); 
                    int __FN_FORSTEP_VAL__8 = (int)1; 
                    for ( _86  = __FN_FORSTART_VAL__8; (__FN_FORSTEP_VAL__8 > 0)  ? ( (_86  >= __FN_FORSTART_VAL__8) && (_86  <= __FN_FOREND_VAL__8) ) : ( (_86  <= __FN_FORSTART_VAL__8) && (_86  >= __FN_FOREND_VAL__8) ) ; _86  += (short)__FN_FORSTEP_VAL__8) 
                        { 
                        __context__.SourceCodeLine = 36;
                        _77 [ _78]  .UpdateValue ( _77 [ _78] + Functions.Chr (  (int) ( _80[ (_85 + _86) ] ) )  ) ; 
                        __context__.SourceCodeLine = 36;
                        } 
                    
                    __context__.SourceCodeLine = 36;
                    _78 = (ushort) ( (_78 + 1) ) ; 
                    __context__.SourceCodeLine = 36;
                    _85 = (short) ( (_85 + _92) ) ; 
                    __context__.SourceCodeLine = 35;
                    } 
                
                } 
            
            __context__.SourceCodeLine = 36;
            return (ushort)( _78) ; 
            
            }
            
        private CrestronString _73 (  SplusExecutionContext __context__, CrestronString _75 ) 
            { 
            CrestronString _76;
            CrestronString _77;
            _76  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
            _77  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
            
            ushort _78 = 0;
            ushort _79 = 0;
            
            
            __context__.SourceCodeLine = 36;
            _77  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 36;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( _75 ); 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( _78  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_78  >= __FN_FORSTART_VAL__1) && (_78  <= __FN_FOREND_VAL__1) ) : ( (_78  <= __FN_FORSTART_VAL__1) && (_78  >= __FN_FOREND_VAL__1) ) ; _78  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 36;
                _78 = (ushort) ( Functions.Find( ":" , _75 ) ) ; 
                __context__.SourceCodeLine = 36;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _78 > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 36;
                    _76  .UpdateValue ( Functions.Remove ( ":" , _75 )  ) ; 
                    __context__.SourceCodeLine = 36;
                    _76  .UpdateValue ( Functions.Left ( _76 ,  (int) ( (Functions.Length( _76 ) - 1) ) )  ) ; 
                    __context__.SourceCodeLine = 36;
                    _77  .UpdateValue ( _77 + _76  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 36;
                    _77  .UpdateValue ( _77 + _75  ) ; 
                    __context__.SourceCodeLine = 36;
                    break ; 
                    } 
                
                __context__.SourceCodeLine = 36;
                } 
            
            __context__.SourceCodeLine = 36;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( _77 , (int)( 1 ) ) == " "))  ) ) 
                {
                __context__.SourceCodeLine = 36;
                _77  .UpdateValue ( Functions.Right ( _77 ,  (int) ( (Functions.Length( _77 ) - 1) ) )  ) ; 
                __context__.SourceCodeLine = 36;
                }
            
            __context__.SourceCodeLine = 36;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Right( _77 , (int)( 1 ) ) == " "))  ) ) 
                {
                __context__.SourceCodeLine = 36;
                _77  .UpdateValue ( Functions.Left ( _77 ,  (int) ( (Functions.Length( _77 ) - 1) ) )  ) ; 
                __context__.SourceCodeLine = 36;
                }
            
            __context__.SourceCodeLine = 36;
            return ( Functions.Lower ( _77 ) ) ; 
            
            }
            
        private ushort _74 (  SplusExecutionContext __context__, CrestronString _76 , CrestronString _77 , CrestronString _78 , ushort _79 ) 
            { 
            ushort _80 = 0;
            ushort _81 = 0;
            ushort _82 = 0;
            
            CrestronString _83;
            CrestronString _84;
            _83  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
            _84  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
            
            ushort [] _85;
            _85  = new ushort[ 17 ];
            
            CrestronString [] _86;
            _86  = new CrestronString[ 17 ];
            for( uint i = 0; i < 17; i++ )
                _86 [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
            
            CrestronString _87;
            _87  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
            
            CrestronString _88;
            _88  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            
            ushort _89 = 0;
            
            
            __context__.SourceCodeLine = 37;
            _89 = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 37;
            _80 = (ushort) ( 16 ) ; 
            __context__.SourceCodeLine = 37;
            while ( Functions.TestForTrue  ( ( Functions.Find( "License Activation is :" , _78 ))  ) ) 
                { 
                __context__.SourceCodeLine = 37;
                _87  .UpdateValue ( Functions.Remove ( "License Activation is :" , _78 )  ) ; 
                __context__.SourceCodeLine = 37;
                } 
            
            __context__.SourceCodeLine = 37;
            _78  .UpdateValue ( Functions.Remove ( "\u000D" , _78 )  ) ; 
            __context__.SourceCodeLine = 37;
            _88  .UpdateValue ( Functions.Left ( _78 ,  (int) ( (Functions.Length( _78 ) - 1) ) )  ) ; 
            __context__.SourceCodeLine = 37;
            _81 = (ushort) ( _72( __context__ , _76 , (ushort)( _80 ) , ref _85 , ref _86 ) ) ; 
            __context__.SourceCodeLine = 37;
            Print( "JanusLicenceDecoder_checkLicense   result  {0:d}\r\n", (short)_81) ; 
            __context__.SourceCodeLine = 37;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)_81; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( _82  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_82  >= __FN_FORSTART_VAL__1) && (_82  <= __FN_FOREND_VAL__1) ) : ( (_82  <= __FN_FORSTART_VAL__1) && (_82  >= __FN_FOREND_VAL__1) ) ; _82  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 37;
                Print( "key[{0:d}]  {1}\r\n", (short)_85[ _82 ], _86 [ _82 ] ) ; 
                __context__.SourceCodeLine = 37;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_85[ _82 ] == 6) ) || Functions.TestForTrue ( Functions.BoolToInt (_85[ _82 ] == 2) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 38;
                    _83  .UpdateValue ( _73 (  __context__ , _86[ _82 ])  ) ; 
                    __context__.SourceCodeLine = 38;
                    _84  .UpdateValue ( _73 (  __context__ , _88)  ) ; 
                    __context__.SourceCodeLine = 38;
                    Print( "licenceValueClean  {0}\r\n", _83 ) ; 
                    __context__.SourceCodeLine = 38;
                    Print( "switchValueClean  {0}\r\n", _84 ) ; 
                    __context__.SourceCodeLine = 38;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_84 == _83))  ) ) 
                        { 
                        __context__.SourceCodeLine = 38;
                        _89 = (ushort) ( 1 ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 38;
                        _89 = (ushort) ( 0 ) ; 
                        } 
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 38;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_85[ _82 ] == 4))  ) ) 
                        { 
                        __context__.SourceCodeLine = 38;
                        Print( "licenceType  {0}\r\n", _86 [ _82 ] ) ; 
                        __context__.SourceCodeLine = 38;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_77 == _86[ _82 ]))  ) ) 
                            { 
                            __context__.SourceCodeLine = 38;
                            _89 = (ushort) ( 1 ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 38;
                            _89 = (ushort) ( 0 ) ; 
                            } 
                        
                        } 
                    
                    }
                
                __context__.SourceCodeLine = 37;
                } 
            
            __context__.SourceCodeLine = 38;
            return (ushort)( _89) ; 
            
            }
            
        private uint _75 (  SplusExecutionContext __context__ ) 
            { 
            uint _77 = 0;
            
            
            __context__.SourceCodeLine = 38;
            _77 = (uint) ( ((((Functions.GetMinutesNum() + (Functions.GetHourNum() * 60)) + ((Functions.GetDateNum() * 24) * 60)) + (((Functions.GetMonthNum() * 31) * 24) * 60)) + ((((Functions.GetYearNum() * 12) * 31) * 24) * 60)) ) ; 
            __context__.SourceCodeLine = 38;
            return (uint)( _77) ; 
            
            }
            
        private uint _76 (  SplusExecutionContext __context__, uint _78 ) 
            { 
            uint _79 = 0;
            uint _80 = 0;
            
            
            __context__.SourceCodeLine = 38;
            _79 = (uint) ( (_75( __context__ ) - _78) ) ; 
            __context__.SourceCodeLine = 39;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _79 > 30 ))  ) ) 
                {
                __context__.SourceCodeLine = 39;
                _80 = (uint) ( 0 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 39;
                _80 = (uint) ( (30 - _79) ) ; 
                }
            
            __context__.SourceCodeLine = 39;
            return (uint)( _80) ; 
            
            }
            
        private CrestronString _77 (  SplusExecutionContext __context__, ushort _79 , ushort _80 ) 
            { 
            CrestronString _81;
            _81  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            
            
            __context__.SourceCodeLine = 39;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_79 == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 39;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_80 == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 39;
                    _81  .UpdateValue ( "Invalid licence / Demo Expired"  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 39;
                    MakeString ( _81 , "Demo mode ({0:d} seconds remaining)", (short)_80) ; 
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 39;
                _81  .UpdateValue ( "Licence OK"  ) ; 
                } 
            
            __context__.SourceCodeLine = 39;
            return ( _81 ) ; 
            
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
        StringParameter P_SWITCHPORT;
        StringParameter P_SWITCHUSERNAME;
        StringParameter P_SWITCHPASSWORD;
        StringParameter P_SWITCHLICENCEKEY;
        _78 _86;
        _87 _93;
        _94 [] _101;
        _94 _102;
        _48 _103;
        ushort _104 = 0;
        ushort _105 = 0;
        ushort _106 = 0;
        ushort _107 = 0;
        ushort _108 = 0;
        CrestronString _109;
        ushort [] _110;
        CrestronString _111;
        ushort _112 = 0;
        ushort _113 = 0;
        CrestronString _114;
        CrestronString [] _115;
        CrestronString [] _116;
        ushort [,] _117;
        ushort _118 = 0;
        ushort _119 = 0;
        ushort _120 = 0;
        ushort _121 = 0;
        CrestronString [] _122;
        CrestronString [] _123;
        ushort _124 = 0;
        ushort _125 = 0;
        ushort _126 = 0;
        ushort _127 = 0;
        ushort _128 = 0;
        ushort _129 = 0;
        ushort _130 = 0;
        private void _131 (  SplusExecutionContext __context__, CrestronString _133 , CrestronString _134 ) 
            { 
            
            __context__.SourceCodeLine = 42;
            if ( Functions.TestForTrue  ( ( _108)  ) ) 
                {
                __context__.SourceCodeLine = 42;
                Print( "\r\n {0}: {1} \r\n", _133 , _134 ) ; 
                }
            
            
            }
            
        private CrestronString _132 (  SplusExecutionContext __context__, CrestronString _134 , ushort _10 , ushort _11 ) 
            { 
            ushort _135 = 0;
            
            CrestronString _136;
            _136  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 254, this );
            
            
            __context__.SourceCodeLine = 43;
            _135 = (ushort) ( (_11 - _10) ) ; 
            __context__.SourceCodeLine = 43;
            _136  .UpdateValue ( Functions.Mid ( _134 ,  (int) ( _10 ) ,  (int) ( _135 ) )  ) ; 
            __context__.SourceCodeLine = 43;
            return ( _136 ) ; 
            
            }
            
        private void _133 (  SplusExecutionContext __context__, ushort _84 ) 
            { 
            CrestronString _135;
            _135  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 128, this );
            
            ushort _136 = 0;
            
            
            __context__.SourceCodeLine = 43;
            _136 = (ushort) ( Functions.BoolToInt (_86._84 != _84) ) ; 
            __context__.SourceCodeLine = 43;
            _86 . _84 = (ushort) ( _84 ) ; 
            __context__.SourceCodeLine = 43;
            
                {
                int __SPLS_TMPVAR__SWTCH_6__ = ((int)_84);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 0) ) ) ) 
                        {
                        __context__.SourceCodeLine = 43;
                        _135  .UpdateValue ( "Not connected"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 1) ) ) ) 
                        {
                        __context__.SourceCodeLine = 43;
                        _135  .UpdateValue ( "Connecting"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 2) ) ) ) 
                        {
                        __context__.SourceCodeLine = 43;
                        _135  .UpdateValue ( "Logging in"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 3) ) ) ) 
                        {
                        __context__.SourceCodeLine = 43;
                        _135  .UpdateValue ( "Invalid username or password"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 4) ) ) ) 
                        {
                        __context__.SourceCodeLine = 43;
                        _135  .UpdateValue ( "Invalid privileged password"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 6) ) ) ) 
                        {
                        __context__.SourceCodeLine = 43;
                        _135  .UpdateValue ( "Configuring"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 5) ) ) ) 
                        {
                        __context__.SourceCodeLine = 43;
                        _135  .UpdateValue ( _86 . _85 + Functions.ItoA (  (int) ( _93._90 ) ) + " x " + Functions.ItoA (  (int) ( _93._91 ) )  ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 44;
                        _135  .UpdateValue ( "Unknown"  ) ; 
                        }
                    
                    } 
                    
                }
                
            
            __context__.SourceCodeLine = 44;
            OPERATIONFB__DOLLAR__  .UpdateValue ( _135  ) ; 
            
            }
            
        private void _134 (  SplusExecutionContext __context__, _94 _136 ) 
            { 
            ushort _137 = 0;
            
            CrestronString _138;
            _138  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
            
            
            __context__.SourceCodeLine = 44;
            _137 = (ushort) ( _62( __context__ , ref _103 ) ) ; 
            __context__.SourceCodeLine = 44;
            MakeString ( _138 , "enqueue iAddIndex={0:d} cmd={1}", (short)_137, _136 . _95 ) ; 
            __context__.SourceCodeLine = 44;
            _131 (  __context__ , "MsgQueue", _138) ; 
            __context__.SourceCodeLine = 44;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_137 != _103._53))  ) ) 
                { 
                __context__.SourceCodeLine = 44;
                _101 [ _137] . _95  .UpdateValue ( _136 . _95  ) ; 
                __context__.SourceCodeLine = 44;
                _101 [ _137] . _96  .UpdateValue ( _136 . _96  ) ; 
                __context__.SourceCodeLine = 44;
                _101 [ _137] . _97 = (ushort) ( _136._97 ) ; 
                __context__.SourceCodeLine = 44;
                _101 [ _137] . _98  .UpdateValue ( _136 . _98  ) ; 
                __context__.SourceCodeLine = 44;
                _101 [ _137] . _99 = (ushort) ( _136._99 ) ; 
                } 
            
            
            }
            
        private void _135 (  SplusExecutionContext __context__, ushort _137 , _94 _138 ) 
            { 
            
            __context__.SourceCodeLine = 44;
            _138 . _95  .UpdateValue ( _101 [ _137] . _95  ) ; 
            __context__.SourceCodeLine = 44;
            _138 . _96  .UpdateValue ( _101 [ _137] . _96  ) ; 
            __context__.SourceCodeLine = 44;
            _138 . _97 = (ushort) ( _101[ _137 ]._97 ) ; 
            __context__.SourceCodeLine = 44;
            _138 . _98  .UpdateValue ( _101 [ _137] . _98  ) ; 
            __context__.SourceCodeLine = 44;
            _138 . _99 = (ushort) ( _101[ _137 ]._99 ) ; 
            
            }
            
        private void _136 (  SplusExecutionContext __context__, ref _94 _138 ) 
            { 
            ushort _139 = 0;
            
            
            __context__.SourceCodeLine = 45;
            _139 = (ushort) ( _63( __context__ , _103 ) ) ; 
            __context__.SourceCodeLine = 45;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _139 < _103._53 ))  ) ) 
                { 
                __context__.SourceCodeLine = 45;
                _135 (  __context__ , (ushort)( _139 ), _138) ; 
                __context__.SourceCodeLine = 45;
                _101 [ _139] . _95  .UpdateValue ( "NULL STRING"  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 45;
                _131 (  __context__ , "Queue", "Queue:Error") ; 
                } 
            
            
            }
            
        private ushort _137 (  SplusExecutionContext __context__, CrestronString _139 ) 
            { 
            ushort _140 = 0;
            ushort _141 = 0;
            ushort _142 = 0;
            
            
            __context__.SourceCodeLine = 45;
            _142 = (ushort) ( 65535 ) ; 
            __context__.SourceCodeLine = 45;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( _139 ); 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( _140  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_140  >= __FN_FORSTART_VAL__1) && (_140  <= __FN_FOREND_VAL__1) ) : ( (_140  <= __FN_FORSTART_VAL__1) && (_140  >= __FN_FOREND_VAL__1) ) ; _140  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 45;
                _141 = (ushort) ( Byte( _139 , (int)( _140 ) ) ) ; 
                __context__.SourceCodeLine = 45;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _141 >= 48 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _141 <= 57 ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (_141 == 46) )) ))  ) ) 
                    { 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 45;
                    _142 = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 45;
                    break ; 
                    } 
                
                __context__.SourceCodeLine = 45;
                } 
            
            __context__.SourceCodeLine = 45;
            return (ushort)( _142) ; 
            
            }
            
        private ushort _138 (  SplusExecutionContext __context__, CrestronString _140 ) 
            { 
            ushort [] _141;
            _141  = new ushort[ 4 ];
            
            ushort [] _142;
            _142  = new ushort[ 5 ];
            
            CrestronString _143;
            _143  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
            
            
            __context__.SourceCodeLine = 45;
            _141 [ 1] = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 45;
            _141 [ 2] = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 45;
            _141 [ 3] = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 45;
            _142 [ 1] = (ushort) ( 256 ) ; 
            __context__.SourceCodeLine = 45;
            _142 [ 2] = (ushort) ( 256 ) ; 
            __context__.SourceCodeLine = 45;
            _142 [ 3] = (ushort) ( 256 ) ; 
            __context__.SourceCodeLine = 46;
            _142 [ 4] = (ushort) ( 256 ) ; 
            __context__.SourceCodeLine = 46;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( _140 ) <= 15 ) ) && Functions.TestForTrue ( _137( __context__ , _140 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 46;
                _141 [ 1] = (ushort) ( Functions.Find( "." , _140 ) ) ; 
                __context__.SourceCodeLine = 46;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _141[ 1 ] > 1 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 46;
                    _142 [ 1] = (ushort) ( Functions.Atoi( Functions.Left( _140 , (int)( (_141[ 1 ] - 1) ) ) ) ) ; 
                    __context__.SourceCodeLine = 46;
                    _141 [ 2] = (ushort) ( _6( __context__ , "." , _140 , (ushort)( (_141[ 1 ] + 1) ) ) ) ; 
                    __context__.SourceCodeLine = 46;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (_141[ 2 ] + 1) > _141[ 1 ] ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 46;
                        _142 [ 2] = (ushort) ( Functions.Atoi( Functions.Mid( _140 , (int)( (_141[ 1 ] + 1) ) , (int)( ((_141[ 2 ] - _141[ 1 ]) - 1) ) ) ) ) ; 
                        __context__.SourceCodeLine = 46;
                        _141 [ 3] = (ushort) ( _6( __context__ , "." , _140 , (ushort)( (_141[ 2 ] + 1) ) ) ) ; 
                        __context__.SourceCodeLine = 46;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (_141[ 3 ] + 1) > _141[ 2 ] ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 46;
                            _142 [ 3] = (ushort) ( Functions.Atoi( Functions.Mid( _140 , (int)( (_141[ 2 ] + 1) ) , (int)( ((_141[ 3 ] - _141[ 2 ]) - 1) ) ) ) ) ; 
                            __context__.SourceCodeLine = 46;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( _140 ) > _141[ 3 ] ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( _140 ) < (_141[ 3 ] + 4) ) )) ))  ) ) 
                                {
                                __context__.SourceCodeLine = 46;
                                _142 [ 4] = (ushort) ( Functions.Atoi( Functions.Right( _140 , (int)( (Functions.Length( _140 ) - _141[ 3 ]) ) ) ) ) ; 
                                }
                            
                            } 
                        
                        } 
                    
                    } 
                
                } 
            
            __context__.SourceCodeLine = 46;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _142[ 1 ] < 256 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _142[ 2 ] < 256 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _142[ 3 ] < 256 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _142[ 4 ] < 256 ) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 46;
                return (ushort)( 65535) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 47;
                return (ushort)( 0) ; 
                }
            
            
            return 0; // default return value (none specified in module)
            }
            
        private void _139 (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 47;
            _86 . _79  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 47;
            _86 . _80 = (ushort) ( 0 ) ; 
            
            }
            
        private void _140 (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 47;
            _131 (  __context__ , "MessageHandler g_MessageHandlerComms.connectState", Functions.ItoA( (int)( _86._84 ) )) ; 
            __context__.SourceCodeLine = 47;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _86._84 > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 47;
                _64 (  __context__ ,   ref  _103 ) ; 
                __context__.SourceCodeLine = 47;
                Functions.SocketDisconnectClient ( SWITCH_CLIENT ) ; 
                __context__.SourceCodeLine = 47;
                _133 (  __context__ , (ushort)( 0 )) ; 
                } 
            
            
            }
            
        private void _141 (  SplusExecutionContext __context__ ) 
            { 
            CrestronString _143;
            _143  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
            
            short _144 = 0;
            short _145 = 0;
            
            
            __context__.SourceCodeLine = 47;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_86._84 == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 47;
                _102 . _95  .UpdateValue ( "NULL STRING"  ) ; 
                __context__.SourceCodeLine = 47;
                _102 . _96  .UpdateValue ( "NULL STRING"  ) ; 
                __context__.SourceCodeLine = 47;
                _102 . _97 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 47;
                _102 . _98  .UpdateValue ( "NULL STRING"  ) ; 
                __context__.SourceCodeLine = 47;
                _102 . _99 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 47;
                _133 (  __context__ , (ushort)( 1 )) ; 
                __context__.SourceCodeLine = 47;
                _86 . _79  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 47;
                _86 . _80 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 47;
                if ( Functions.TestForTrue  ( ( _138( __context__ , P_SWITCHIP  ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 47;
                    _131 (  __context__ , "MessageHandler", "SocketConnectClient") ; 
                    __context__.SourceCodeLine = 48;
                    _144 = (short) ( Functions.SocketConnectClient( SWITCH_CLIENT , P_SWITCHIP  , (ushort)( Functions.Atoi( P_SWITCHPORT  ) ) , (ushort)( 1 ) ) ) ; 
                    __context__.SourceCodeLine = 48;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_144 == -7) ) || Functions.TestForTrue ( Functions.BoolToInt (_144 == -8) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 48;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_144 == -7))  ) ) 
                            {
                            __context__.SourceCodeLine = 48;
                            _131 (  __context__ , "MessageHandler", "Switch - Connected") ; 
                            }
                        
                        else 
                            {
                            __context__.SourceCodeLine = 48;
                            _131 (  __context__ , "MessageHandler", "Switch - Connection attempt in progress") ; 
                            }
                        
                        __context__.SourceCodeLine = 48;
                        return ; 
                        } 
                    
                    __context__.SourceCodeLine = 48;
                    Functions.Delay (  (int) ( 1000 ) ) ; 
                    __context__.SourceCodeLine = 48;
                    _145 = (short) ( Functions.SocketGetAddressAsRequested( SWITCH_CLIENT , ref _143 ) ) ; 
                    __context__.SourceCodeLine = 48;
                    _111  .UpdateValue ( "Switch - Attempting to Connect to device at " + P_SWITCHIP + ":" + P_SWITCHPORT  ) ; 
                    __context__.SourceCodeLine = 48;
                    _131 (  __context__ , "MessageHandler", _111) ; 
                    __context__.SourceCodeLine = 48;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_144 != 0) ) || Functions.TestForTrue ( Functions.BoolToInt (_145 != 0) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 49;
                        _111  .UpdateValue ( "Switch - IP Client Connect Error: " + Functions.ItoA (  (int) ( _144 ) ) + " , " + Functions.ItoA (  (int) ( _145 ) ) + " Address: " + _143  ) ; 
                        __context__.SourceCodeLine = 49;
                        _131 (  __context__ , "MessageHandler", _111) ; 
                        } 
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 49;
                    _111  .UpdateValue ( "Switch - Stored IP Address is Invalid: " + P_SWITCHIP  ) ; 
                    __context__.SourceCodeLine = 49;
                    _131 (  __context__ , "MessageHandler", _111) ; 
                    } 
                
                } 
            
            
            }
            
        private void _142 (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 49;
            _131 (  __context__ , "MessageHandler", "queueTimeOut") ; 
            __context__.SourceCodeLine = 49;
            _140 (  __context__  ) ; 
            __context__.SourceCodeLine = 49;
            _141 (  __context__  ) ; 
            
            }
            
        private void _143 (  SplusExecutionContext __context__, CrestronString _145 ) 
            { 
            CrestronString _146;
            _146  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5000, this );
            
            ushort _147 = 0;
            
            
            __context__.SourceCodeLine = 49;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_145 != "NULL STRING"))  ) ) 
                { 
                __context__.SourceCodeLine = 49;
                _147 = (ushort) ( Functions.Find( "#NULL#" , _145 ) ) ; 
                __context__.SourceCodeLine = 49;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _147 > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 49;
                    _146  .UpdateValue ( Functions.Left ( _145 ,  (int) ( (_147 - 1) ) )  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 49;
                    _146  .UpdateValue ( _145 + "\r\n"  ) ; 
                    } 
                
                __context__.SourceCodeLine = 49;
                _131 (  __context__ , "fnMessageHandler_sendLuxulCommand command ", _146) ; 
                __context__.SourceCodeLine = 50;
                Functions.SocketSend ( SWITCH_CLIENT , _146 ) ; 
                } 
            
            
            }
            
        private void _144 (  SplusExecutionContext __context__, _94 _146 ) 
            { 
            
            __context__.SourceCodeLine = 50;
            _102 . _95  .UpdateValue ( _146 . _95  ) ; 
            __context__.SourceCodeLine = 50;
            _102 . _96  .UpdateValue ( _146 . _96  ) ; 
            __context__.SourceCodeLine = 50;
            _102 . _97 = (ushort) ( _146._97 ) ; 
            __context__.SourceCodeLine = 50;
            _102 . _98  .UpdateValue ( _146 . _98  ) ; 
            __context__.SourceCodeLine = 50;
            _102 . _99 = (ushort) ( _146._99 ) ; 
            __context__.SourceCodeLine = 50;
            _107 = (ushort) ( (_107 + 1) ) ; 
            __context__.SourceCodeLine = 50;
            _129 = (ushort) ( 65535 ) ; 
            __context__.SourceCodeLine = 50;
            CreateWait ( "WAIT_FOR_RX_SEND" , 10000 , WAIT_FOR_RX_SEND_Callback ) ;
            __context__.SourceCodeLine = 50;
            _143 (  __context__ , _102._95) ; 
            
            }
            
        public void WAIT_FOR_RX_SEND_CallbackFn( object stateInfo )
        {
        
            try
            {
                Wait __LocalWait__ = (Wait)stateInfo;
                SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
                __LocalWait__.RemoveFromList();
                
            
            __context__.SourceCodeLine = 50;
            _142 (  __context__  ) ; 
            
        
        
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler(); }
            
        }
        
    private void _145 (  SplusExecutionContext __context__, CrestronString _147 ) 
        { 
        
        __context__.SourceCodeLine = 50;
        _133 (  __context__ , (ushort)( 3 )) ; 
        
        }
        
    private void _146 (  SplusExecutionContext __context__, CrestronString _148 ) 
        { 
        _94 _149;
        _149  = new _94( this, true );
        _149 .PopulateCustomAttributeList( false );
        
        
        __context__.SourceCodeLine = 50;
        _131 (  __context__ , "MessageHandler_sendPassword", "MessageHandler_sendPassword") ; 
        __context__.SourceCodeLine = 50;
        _149 . _95  .UpdateValue ( P_SWITCHPASSWORD  ) ; 
        __context__.SourceCodeLine = 50;
        _149 . _96  .UpdateValue ( "#"  ) ; 
        __context__.SourceCodeLine = 50;
        _149 . _97 = (ushort) ( 14 ) ; 
        __context__.SourceCodeLine = 50;
        _149 . _98  .UpdateValue ( "Username:"  ) ; 
        __context__.SourceCodeLine = 50;
        _149 . _99 = (ushort) ( 14 ) ; 
        __context__.SourceCodeLine = 50;
        _144 (  __context__ , _149) ; 
        
        }
        
    private void _147 (  SplusExecutionContext __context__, CrestronString _149 ) 
        { 
        _94 _150;
        _150  = new _94( this, true );
        _150 .PopulateCustomAttributeList( false );
        
        
        __context__.SourceCodeLine = 51;
        _131 (  __context__ , "MessageHandler_sendUsername", "MessageHandler_sendUsername") ; 
        __context__.SourceCodeLine = 51;
        _150 . _95  .UpdateValue ( P_SWITCHUSERNAME  ) ; 
        __context__.SourceCodeLine = 51;
        _150 . _96  .UpdateValue ( "Password:"  ) ; 
        __context__.SourceCodeLine = 51;
        _150 . _97 = (ushort) ( 2 ) ; 
        __context__.SourceCodeLine = 51;
        _150 . _98  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 51;
        _150 . _99 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 51;
        _144 (  __context__ , _150) ; 
        
        }
        
    private void _148 (  SplusExecutionContext __context__ ) 
        { 
        _94 _150;
        _150  = new _94( this, true );
        _150 .PopulateCustomAttributeList( false );
        
        
        __context__.SourceCodeLine = 51;
        _131 (  __context__ , "MessageHandler_beginLoginSequence", "MessageHandler_beginLoginSequence") ; 
        __context__.SourceCodeLine = 51;
        _150 . _95  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 51;
        _150 . _96  .UpdateValue ( "Username:"  ) ; 
        __context__.SourceCodeLine = 51;
        _150 . _97 = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 51;
        _150 . _98  .UpdateValue ( "#"  ) ; 
        __context__.SourceCodeLine = 51;
        _150 . _99 = (ushort) ( 14 ) ; 
        
        }
        
    private void _149 (  SplusExecutionContext __context__, ushort _151 ) 
        { 
        CrestronString _152;
        _152  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
        
        
        __context__.SourceCodeLine = 51;
        _152  .UpdateValue ( "Connection Status Changed. IsConnected = " + Functions.ItoA (  (int) ( _151 ) )  ) ; 
        __context__.SourceCodeLine = 51;
        _131 (  __context__ , "MessageHandler", _152) ; 
        __context__.SourceCodeLine = 51;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _151 > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 51;
            _133 (  __context__ , (ushort)( 2 )) ; 
            __context__.SourceCodeLine = 51;
            _148 (  __context__  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 51;
            _133 (  __context__ , (ushort)( 0 )) ; 
            __context__.SourceCodeLine = 52;
            _64 (  __context__ ,   ref  _103 ) ; 
            } 
        
        
        }
        
    private void _150 (  SplusExecutionContext __context__, CrestronString _152 , ushort _153 , CrestronString _154 , ushort _155 , CrestronString _156 ) 
        { 
        ushort _157 = 0;
        
        _94 _158;
        _158  = new _94( this, true );
        _158 .PopulateCustomAttributeList( false );
        
        
        __context__.SourceCodeLine = 52;
        _158 . _95  .UpdateValue ( _152  ) ; 
        __context__.SourceCodeLine = 52;
        _158 . _96  .UpdateValue ( _154  ) ; 
        __context__.SourceCodeLine = 52;
        _158 . _97 = (ushort) ( _153 ) ; 
        __context__.SourceCodeLine = 52;
        _158 . _98  .UpdateValue ( _156  ) ; 
        __context__.SourceCodeLine = 52;
        _158 . _99 = (ushort) ( _153 ) ; 
        __context__.SourceCodeLine = 52;
        _131 (  __context__ , "MessageHandler_sendMessage", _152) ; 
        __context__.SourceCodeLine = 52;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _86._84 >= 5 ) ) && Functions.TestForTrue ( Functions.BoolToInt (_102._95 == "NULL STRING") )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 52;
            _144 (  __context__ , _158) ; 
            __context__.SourceCodeLine = 52;
            _131 (  __context__ , "MessageHandler_sendMessage", "MessageHandler_sendNow") ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 52;
            _134 (  __context__ , _158) ; 
            __context__.SourceCodeLine = 52;
            _141 (  __context__  ) ; 
            } 
        
        
        }
        
    private void _151 (  SplusExecutionContext __context__, CrestronString _153 , ushort _154 , CrestronString _155 , ushort _156 , CrestronString _157 ) 
        { 
        ushort _158 = 0;
        
        _94 _159;
        _159  = new _94( this, true );
        _159 .PopulateCustomAttributeList( false );
        
        
        __context__.SourceCodeLine = 52;
        _159 . _95  .UpdateValue ( _153  ) ; 
        __context__.SourceCodeLine = 52;
        _159 . _96  .UpdateValue ( _155  ) ; 
        __context__.SourceCodeLine = 52;
        _159 . _97 = (ushort) ( _154 ) ; 
        __context__.SourceCodeLine = 53;
        _159 . _98  .UpdateValue ( _157  ) ; 
        __context__.SourceCodeLine = 53;
        _159 . _99 = (ushort) ( _154 ) ; 
        __context__.SourceCodeLine = 53;
        _134 (  __context__ , _159) ; 
        
        }
        
    private void _152 (  SplusExecutionContext __context__ ) 
        { 
        _94 _154;
        _154  = new _94( this, true );
        _154 .PopulateCustomAttributeList( false );
        
        
        __context__.SourceCodeLine = 53;
        _136 (  __context__ ,   ref  _154 ) ; 
        __context__.SourceCodeLine = 53;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_154._95 == "NULL STRING"))  ) ) 
            { 
            __context__.SourceCodeLine = 53;
            CreateWait ( "__SPLS_TMPVAR__WAITLABEL_15__" , 10 , __SPLS_TMPVAR__WAITLABEL_15___Callback ) ;
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 53;
            _144 (  __context__ , _154) ; 
            } 
        
        
        }
        
    public void __SPLS_TMPVAR__WAITLABEL_15___CallbackFn( object stateInfo )
    {
    
        try
        {
            Wait __LocalWait__ = (Wait)stateInfo;
            SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
            __LocalWait__.RemoveFromList();
            
            
            __context__.SourceCodeLine = 53;
            _131 (  __context__ , "Wait 10 - NULL_MESSAGE", "") ; 
            __context__.SourceCodeLine = 53;
            _152 (  __context__  ) ; 
            
        
        
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        
    }
    
private void _153 (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 53;
    _131 (  __context__ , "MessageHandler", "Closing TCP connection comms") ; 
    __context__.SourceCodeLine = 53;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_86._82 != ""))  ) ) 
        { 
        __context__.SourceCodeLine = 53;
        _86 . _82  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 53;
        _86 . _83  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 53;
        _64 (  __context__ ,   ref  _103 ) ; 
        __context__.SourceCodeLine = 53;
        _140 (  __context__  ) ; 
        __context__.SourceCodeLine = 53;
        _133 (  __context__ , (ushort)( 0 )) ; 
        } 
    
    
    }
    
private void _154 (  SplusExecutionContext __context__, CrestronString _82 , CrestronString _83 ) 
    { 
    
    __context__.SourceCodeLine = 53;
    _131 (  __context__ , "MessageHandler", "InitialiseComms") ; 
    __context__.SourceCodeLine = 53;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_86._84 != 0))  ) ) 
        { 
        __context__.SourceCodeLine = 53;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_86._82 != "") ) && Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_86._82 != _82) ) || Functions.TestForTrue ( Functions.BoolToInt (_86._83 != _83) )) ) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 53;
            _153 (  __context__  ) ; 
            }
        
        } 
    
    __context__.SourceCodeLine = 53;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_86._84 == 0))  ) ) 
        { 
        __context__.SourceCodeLine = 53;
        _86 . _82  .UpdateValue ( _82  ) ; 
        __context__.SourceCodeLine = 53;
        _86 . _83  .UpdateValue ( _83  ) ; 
        __context__.SourceCodeLine = 53;
        _141 (  __context__  ) ; 
        } 
    
    
    }
    
private void _155 (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 54;
    _150 (  __context__ , " ", (ushort)( 0 ), "#", (ushort)( 0 ), "") ; 
    
    }
    
private void _156 (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 54;
    _86 . _79  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 54;
    _86 . _80 = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 54;
    _86 . _81 = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 54;
    _86 . _82  .UpdateValue ( P_SWITCHIP  ) ; 
    __context__.SourceCodeLine = 54;
    _86 . _83  .UpdateValue ( P_SWITCHPORT  ) ; 
    __context__.SourceCodeLine = 54;
    _86 . _84 = (ushort) ( Functions.ToInteger( -( 1 ) ) ) ; 
    __context__.SourceCodeLine = 54;
    _133 (  __context__ , (ushort)( 0 )) ; 
    
    }
    
private void _157 (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 54;
    CreateWait ( "LICENCE_TEXT" , 1000 , LICENCE_TEXT_Callback ) ;
    
    }
    
public void LICENCE_TEXT_CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            CrestronString OPERATIONSTATE;
            OPERATIONSTATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 128, this );
            
            uint IMINUTESREMAINING = 0;
            
            __context__.SourceCodeLine = 54;
            IMINUTESREMAINING = (uint) ( _76( __context__ , (uint)( _93._89 ) ) ) ; 
            __context__.SourceCodeLine = 54;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_86._84 == 5))  ) ) 
                { 
                __context__.SourceCodeLine = 54;
                _86 . _85  .UpdateValue ( "DEMO (" + Functions.LtoA (  (int) ( IMINUTESREMAINING ) ) + " mins) "  ) ; 
                __context__.SourceCodeLine = 54;
                OPERATIONSTATE  .UpdateValue ( _86 . _85 + Functions.ItoA (  (int) ( _93._90 ) ) + " x " + Functions.ItoA (  (int) ( _93._91 ) )  ) ; 
                __context__.SourceCodeLine = 54;
                _131 (  __context__ , "DemoTimer", OPERATIONSTATE) ; 
                __context__.SourceCodeLine = 54;
                OPERATIONFB__DOLLAR__  .UpdateValue ( OPERATIONSTATE  ) ; 
                } 
            
            __context__.SourceCodeLine = 54;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IMINUTESREMAINING == 0))  ) ) 
                {
                __context__.SourceCodeLine = 54;
                _93 . _88 = (ushort) ( 3 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 54;
                _157 (  __context__  ) ; 
                }
            
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

private ushort _158 (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 55;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_93._88 == 1))  ) ) 
        {
        __context__.SourceCodeLine = 55;
        return (ushort)( 65535) ; 
        }
    
    __context__.SourceCodeLine = 55;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_76( __context__ , (uint)( _93._89 ) ) == 0))  ) ) 
        {
        __context__.SourceCodeLine = 55;
        return (ushort)( 0) ; 
        }
    
    __context__.SourceCodeLine = 55;
    CancelWait ( "LICENCE_TEXT" ) ; 
    __context__.SourceCodeLine = 55;
    _157 (  __context__  ) ; 
    __context__.SourceCodeLine = 55;
    return (ushort)( 65535) ; 
    
    }
    
private void _159 (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 55;
    _154 (  __context__ , P_SWITCHIP , P_SWITCHPORT ) ; 
    
    }
    
private void _160 (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 55;
    _131 (  __context__ , " fnLuxulSwitch_handleSaveStatus", "") ; 
    __context__.SourceCodeLine = 55;
    _150 (  __context__ , "copy running-config startup-config", (ushort)( 0 ), "Building configuration...", (ushort)( 0 ), "") ; 
    
    }
    
private ushort _161 (  SplusExecutionContext __context__, CrestronString _163 , short _164 , short [,] _165 , ref CrestronString [] _166 ) 
    { 
    short _167 = 0;
    
    ushort _168 = 0;
    ushort _169 = 0;
    ushort _170 = 0;
    ushort _171 = 0;
    ushort _172 = 0;
    ushort _173 = 0;
    ushort _174 = 0;
    ushort _175 = 0;
    ushort POS = 0;
    
    CrestronString _176;
    CrestronString _177;
    CrestronString _178;
    _176  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    _177  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 254, this );
    _178  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    
    _7 _179;
    _179  = new _7( this, true );
    _179 .PopulateCustomAttributeList( false );
    
    
    __context__.SourceCodeLine = 56;
    _167 = (short) ( 0 ) ; 
    __context__.SourceCodeLine = 56;
    _168 = (ushort) ( 1 ) ; 
    __context__.SourceCodeLine = 56;
    _169 = (ushort) ( Functions.Length( _163 ) ) ; 
    __context__.SourceCodeLine = 56;
    do 
        { 
        __context__.SourceCodeLine = 56;
        POS = (ushort) ( _6( __context__ , "," , _163 , (ushort)( _168 ) ) ) ; 
        __context__.SourceCodeLine = 56;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (POS == 0))  ) ) 
            {
            __context__.SourceCodeLine = 56;
            _170 = (ushort) ( _169 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 56;
            _170 = (ushort) ( POS ) ; 
            }
        
        __context__.SourceCodeLine = 56;
        _177  .UpdateValue ( "gi(%d*)/?(%d*)/?(%d*)-?(%d*)"  ) ; 
        __context__.SourceCodeLine = 56;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _44( __context__ , _163 , (ushort)( _170 ) , (short)( _168 ) , _177 , (ushort)( Functions.Length( _177 ) ) , ref _179 ) > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 56;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _179._11[ 3 ] > _179._10[ 3 ] ))  ) ) 
                { 
                __context__.SourceCodeLine = 56;
                _172 = (ushort) ( (Functions.Atoi( _132( __context__ , _163 , (ushort)( _179._10[ 1 ] ) , (ushort)( _179._11[ 1 ] ) ) ) - 1) ) ; 
                __context__.SourceCodeLine = 56;
                _173 = (ushort) ( 3 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 56;
                _172 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 56;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _179._11[ 2 ] > _179._10[ 2 ] ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 56;
                    _173 = (ushort) ( 2 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 56;
                    _173 = (ushort) ( 1 ) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 56;
            _174 = (ushort) ( Functions.Atoi( _132( __context__ , _163 , (ushort)( _179._10[ _173 ] ) , (ushort)( _179._11[ _173 ] ) ) ) ) ; 
            __context__.SourceCodeLine = 56;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _179._11[ 4 ] > _179._10[ 4 ] ))  ) ) 
                {
                __context__.SourceCodeLine = 56;
                _175 = (ushort) ( Functions.Atoi( _132( __context__ , _163 , (ushort)( _179._10[ 4 ] ) , (ushort)( _179._11[ 4 ] ) ) ) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 56;
                _175 = (ushort) ( _174 ) ; 
                }
            
            __context__.SourceCodeLine = 57;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _174 < 1 ) ) || Functions.TestForTrue ( Functions.BoolToInt ( _175 > 52 ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( _174 > _175 ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( _172 < 0 ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( _172 >= 8 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 57;
                _131 (  __context__ , "_recordPortsInMap", "Invalid port name in VLAN port list") ; 
                __context__.SourceCodeLine = 57;
                _167 = (short) ( Functions.ToSignedInteger( -( 1000 ) ) ) ; 
                __context__.SourceCodeLine = 57;
                break ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 57;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( _166[ _172 ] ) == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 57;
                    _166 [ _172]  .UpdateValue ( _163  ) ; 
                    __context__.SourceCodeLine = 57;
                    _166 [ _172]  .UpdateValue ( Functions.Mid ( _166 [ _172] ,  (int) ( _168 ) ,  (int) ( (_179._10[ _173 ] - _168) ) )  ) ; 
                    } 
                
                __context__.SourceCodeLine = 57;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( _174 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)_175; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( _171  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_171  >= __FN_FORSTART_VAL__1) && (_171  <= __FN_FOREND_VAL__1) ) : ( (_171  <= __FN_FORSTART_VAL__1) && (_171  >= __FN_FOREND_VAL__1) ) ; _171  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 57;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_165[ _172 , _171 ] == 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 57;
                        _165 [ _172 , _171] = (short) ( _164 ) ; 
                        __context__.SourceCodeLine = 57;
                        _167 = (short) ( (_167 + 1) ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 57;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_165[ _172 , _171 ] != Functions.ToSignedLongInteger( -( _164 ) )))  ) ) 
                            { 
                            __context__.SourceCodeLine = 57;
                            _131 (  __context__ , "_recordPortsInMap", "Port appears on more than one TX VLAN") ; 
                            __context__.SourceCodeLine = 57;
                            _167 = (short) ( Functions.ToSignedInteger( -( 1000 ) ) ) ; 
                            } 
                        
                        }
                    
                    __context__.SourceCodeLine = 57;
                    } 
                
                __context__.SourceCodeLine = 57;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _175 > _165[ _172 , 0 ] ))  ) ) 
                    {
                    __context__.SourceCodeLine = 57;
                    _165 [ _172 , 0] = (short) ( _175 ) ; 
                    }
                
                } 
            
            } 
        
        else 
            {
            __context__.SourceCodeLine = 57;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_170 != _168))  ) ) 
                { 
                __context__.SourceCodeLine = 58;
                _131 (  __context__ , "_recordPortsInMap", "Unexpected port list format") ; 
                __context__.SourceCodeLine = 58;
                _167 = (short) ( Functions.ToSignedInteger( -( 1000 ) ) ) ; 
                __context__.SourceCodeLine = 58;
                break ; 
                } 
            
            }
        
        __context__.SourceCodeLine = 58;
        _168 = (ushort) ( (_170 + 1) ) ; 
        } 
    while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (_170 == _169)) )); 
    __context__.SourceCodeLine = 58;
    return (ushort)( _167) ; 
    
    }
    
private void _162 (  SplusExecutionContext __context__, ushort _164 , CrestronString _165 ) 
    { 
    CrestronString _166;
    CrestronString _167;
    _166  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    _167  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
    
    
    __context__.SourceCodeLine = 58;
    if ( Functions.TestForTrue  ( ( Functions.Not( _158( __context__ ) ))  ) ) 
        {
        __context__.SourceCodeLine = 58;
        return ; 
        }
    
    __context__.SourceCodeLine = 58;
    _166  .UpdateValue ( "10," + Functions.ItoA (  (int) ( (_164 + 10) ) )  ) ; 
    __context__.SourceCodeLine = 58;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_165 != ""))  ) ) 
        { 
        __context__.SourceCodeLine = 58;
        _151 (  __context__ , "con ter", (ushort)( 0 ), "(config)#", (ushort)( 0 ), "") ; 
        __context__.SourceCodeLine = 58;
        MakeString ( _167 , "in gi {0}", _165 ) ; 
        __context__.SourceCodeLine = 58;
        _151 (  __context__ , _167, (ushort)( 0 ), "(config-if)#", (ushort)( 0 ), "") ; 
        __context__.SourceCodeLine = 58;
        MakeString ( _167 , "switch hy all vlan {0}", _166 ) ; 
        __context__.SourceCodeLine = 58;
        _151 (  __context__ , _167, (ushort)( 0 ), "(config-if)#", (ushort)( 0 ), "") ; 
        __context__.SourceCodeLine = 58;
        _151 (  __context__ , "end", (ushort)( 0 ), "#", (ushort)( 0 ), "") ; 
        __context__.SourceCodeLine = 58;
        _152 (  __context__  ) ; 
        } 
    
    
    }
    
private ushort _163 (  SplusExecutionContext __context__, ushort _165 , CrestronString [] _166 ) 
    { 
    CrestronString _167;
    CrestronString [] _168;
    _167  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    _168  = new CrestronString[ 9 ];
    for( uint i = 0; i < 9; i++ )
        _168 [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
    
    CrestronString _169;
    _169  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    
    ushort _170 = 0;
    ushort _171 = 0;
    ushort _172 = 0;
    
    
    __context__.SourceCodeLine = 59;
    MakeString ( _169 , "fnLuxulSwitch_MergeRanges inputLogical={0:d} physicalRange[1]={1}", (short)_165, _166 [ 1] ) ; 
    __context__.SourceCodeLine = 59;
    _131 (  __context__ , "Luxul", _169) ; 
    __context__.SourceCodeLine = 59;
    ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
    ushort __FN_FOREND_VAL__1 = (ushort)8; 
    int __FN_FORSTEP_VAL__1 = (int)1; 
    for ( _170  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_170  >= __FN_FORSTART_VAL__1) && (_170  <= __FN_FOREND_VAL__1) ) : ( (_170  <= __FN_FORSTART_VAL__1) && (_170  >= __FN_FOREND_VAL__1) ) ; _170  += (ushort)__FN_FORSTEP_VAL__1) 
        {
        __context__.SourceCodeLine = 59;
        _168 [ 8 ]  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 59;
        }
    
    __context__.SourceCodeLine = 59;
    _171 = (ushort) ( 1 ) ; 
    __context__.SourceCodeLine = 59;
    while ( Functions.TestForTrue  ( ( Functions.BoolToInt (_166[ _171 ] != ""))  ) ) 
        { 
        __context__.SourceCodeLine = 59;
        _167  .UpdateValue ( _166 [ _171]  ) ; 
        __context__.SourceCodeLine = 59;
        _172 = (ushort) ( Functions.Atoi( Functions.Remove( "/" , _167 , 1 ) ) ) ; 
        __context__.SourceCodeLine = 59;
        _168 [ _172 ]  .UpdateValue ( _168 [ _172 ] + "," + _167  ) ; 
        __context__.SourceCodeLine = 59;
        _171 = (ushort) ( (_171 + 1) ) ; 
        __context__.SourceCodeLine = 59;
        } 
    
    __context__.SourceCodeLine = 59;
    ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
    ushort __FN_FOREND_VAL__2 = (ushort)8; 
    int __FN_FORSTEP_VAL__2 = (int)1; 
    for ( _172  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (_172  >= __FN_FORSTART_VAL__2) && (_172  <= __FN_FOREND_VAL__2) ) : ( (_172  <= __FN_FORSTART_VAL__2) && (_172  >= __FN_FOREND_VAL__2) ) ; _172  += (ushort)__FN_FORSTEP_VAL__2) 
        { 
        __context__.SourceCodeLine = 59;
        MakeString ( _169 , "Range {0:d} is {1}", (short)_172, _168 [ _172 ] ) ; 
        __context__.SourceCodeLine = 59;
        _131 (  __context__ , "Luxul", _169) ; 
        __context__.SourceCodeLine = 59;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_168[ _172 ] == ""))  ) ) 
            {
            __context__.SourceCodeLine = 59;
            continue ; 
            }
        
        __context__.SourceCodeLine = 59;
        _168 [ _172 ]  .UpdateValue ( Functions.Right ( _168 [ _172 ] ,  (int) ( (Functions.Length( _168[ _172 ] ) - 1) ) )  ) ; 
        __context__.SourceCodeLine = 60;
        MakeString ( _167 , "{0:d}/{1}", (short)_172, _168 [ _172 ] ) ; 
        __context__.SourceCodeLine = 60;
        _162 (  __context__ , (ushort)( _165 ), _167) ; 
        __context__.SourceCodeLine = 59;
        } 
    
    
    return 0; // default return value (none specified in module)
    }
    
private void _164 (  SplusExecutionContext __context__, CrestronString _166 , CrestronString _83 , CrestronString _167 ) 
    { 
    CrestronString _168;
    CrestronString _169;
    CrestronString _170;
    _168  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 25, this );
    _169  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    _170  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    
    
    __context__.SourceCodeLine = 60;
    if ( Functions.TestForTrue  ( ( Functions.Not( _158( __context__ ) ))  ) ) 
        {
        __context__.SourceCodeLine = 60;
        return ; 
        }
    
    __context__.SourceCodeLine = 60;
    _168  .UpdateValue ( _166 + "/" + _83  ) ; 
    __context__.SourceCodeLine = 60;
    MakeString ( _169 , "fnLuxulSwitch_ChangePOE() sSwitchPort={0} action={1}", _168 , _167 ) ; 
    __context__.SourceCodeLine = 60;
    _131 (  __context__ , "Luxul", _168) ; 
    __context__.SourceCodeLine = 60;
    _151 (  __context__ , "con ter", (ushort)( 0 ), "(config)#", (ushort)( 0 ), "") ; 
    __context__.SourceCodeLine = 60;
    MakeString ( _170 , "in gi {0}", _168 ) ; 
    __context__.SourceCodeLine = 60;
    _151 (  __context__ , _170, (ushort)( 0 ), "(config-if)#", (ushort)( 0 ), "") ; 
    __context__.SourceCodeLine = 60;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_167 == "ON"))  ) ) 
        { 
        __context__.SourceCodeLine = 60;
        _151 (  __context__ , "poe mode plus", (ushort)( 0 ), "(config-if)#", (ushort)( 0 ), "") ; 
        __context__.SourceCodeLine = 60;
        _117 [ Functions.Atoi( _166 ) , Functions.Atoi( _83 )] = (ushort) ( 65535 ) ; 
        } 
    
    else 
        {
        __context__.SourceCodeLine = 60;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_167 == "OFF"))  ) ) 
            { 
            __context__.SourceCodeLine = 61;
            _151 (  __context__ , "no poe mode", (ushort)( 0 ), "(config-if)#", (ushort)( 0 ), "") ; 
            __context__.SourceCodeLine = 61;
            _117 [ Functions.Atoi( _166 ) , Functions.Atoi( _83 )] = (ushort) ( 0 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 61;
            _131 (  __context__ , "Luxul", "Invalid action.  PoE not changed") ; 
            } 
        
        }
    
    __context__.SourceCodeLine = 61;
    _151 (  __context__ , "end", (ushort)( 0 ), "#", (ushort)( 0 ), "") ; 
    __context__.SourceCodeLine = 61;
    _152 (  __context__  ) ; 
    
    }
    
private void _165 (  SplusExecutionContext __context__, ushort _167 , CrestronString _168 ) 
    { 
    ushort [] _169;
    ushort _170 = 0;
    ushort _171 = 0;
    ushort _172 = 0;
    _169  = new ushort[ 405 ];
    
    CrestronString _173;
    _173  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 404, this );
    
    CrestronString _174;
    _174  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 404, this );
    
    CrestronString _175;
    CrestronString [] _176;
    _175  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    _176  = new CrestronString[ 256 ];
    for( uint i = 0; i < 256; i++ )
        _176 [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    
    CrestronString _10;
    _10  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    
    CrestronString _11;
    _11  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
    
    ushort _177 = 0;
    
    ushort _178 = 0;
    
    CrestronString _179;
    _179  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    
    ushort _180 = 0;
    
    CrestronString [] _181;
    _181  = new CrestronString[ 101 ];
    for( uint i = 0; i < 101; i++ )
        _181 [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    
    CrestronString _182;
    _182  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    
    _7 _183;
    _183  = new _7( this, true );
    _183 .PopulateCustomAttributeList( false );
    
    
    __context__.SourceCodeLine = 61;
    if ( Functions.TestForTrue  ( ( Functions.Not( _158( __context__ ) ))  ) ) 
        {
        __context__.SourceCodeLine = 61;
        return ; 
        }
    
    __context__.SourceCodeLine = 61;
    _172 = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 61;
    _173  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 61;
    _174  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 61;
    _175  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 61;
    _10  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 61;
    _11  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 61;
    _177 = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 62;
    ushort __FN_FORSTART_VAL__1 = (ushort) ( 0 ) ;
    ushort __FN_FOREND_VAL__1 = (ushort)404; 
    int __FN_FORSTEP_VAL__1 = (int)1; 
    for ( _178  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_178  >= __FN_FORSTART_VAL__1) && (_178  <= __FN_FOREND_VAL__1) ) : ( (_178  <= __FN_FORSTART_VAL__1) && (_178  >= __FN_FOREND_VAL__1) ) ; _178  += (ushort)__FN_FORSTEP_VAL__1) 
        {
        __context__.SourceCodeLine = 62;
        _169 [ _178] = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 62;
        }
    
    __context__.SourceCodeLine = 62;
    MakeString ( _182 , " Input: {0:d} Output: {1}", (short)_167, _168 ) ; 
    __context__.SourceCodeLine = 62;
    _131 (  __context__ , "createRangeInterface()", _182) ; 
    __context__.SourceCodeLine = 62;
    do 
        { 
        __context__.SourceCodeLine = 62;
        _170 = (ushort) ( Functions.Find( "," , _168 ) ) ; 
        __context__.SourceCodeLine = 62;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _170 > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 62;
            _179  .UpdateValue ( Functions.Remove ( "," , _168 , 1)  ) ; 
            __context__.SourceCodeLine = 62;
            _179  .UpdateValue ( Functions.Left ( _179 ,  (int) ( (Functions.Length( _179 ) - 1) ) )  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 62;
            _179  .UpdateValue ( _168  ) ; 
            } 
        
        __context__.SourceCodeLine = 62;
        _178 = (ushort) ( Functions.Atoi( _179 ) ) ; 
        __context__.SourceCodeLine = 62;
        _169 [ _178] = (ushort) ( 1 ) ; 
        } 
    while (false == ( Functions.TestForTrue  ( Functions.BoolToInt ( _170 < 1 )) )); 
    __context__.SourceCodeLine = 62;
    MakeString ( _182 , " g_LuxulSwitch.readyForCommands = {0:d}", (short)_93._92) ; 
    __context__.SourceCodeLine = 62;
    _131 (  __context__ , "createRangeInterface()", _182) ; 
    __context__.SourceCodeLine = 62;
    ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
    ushort __FN_FOREND_VAL__2 = (ushort)(_106 + 1); 
    int __FN_FORSTEP_VAL__2 = (int)1; 
    for ( _178  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (_178  >= __FN_FORSTART_VAL__2) && (_178  <= __FN_FOREND_VAL__2) ) : ( (_178  <= __FN_FORSTART_VAL__2) && (_178  >= __FN_FOREND_VAL__2) ) ; _178  += (ushort)__FN_FORSTEP_VAL__2) 
        { 
        __context__.SourceCodeLine = 62;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( _169[ _178 ] ) && Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _178 <= _106 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _178 > 0 ) )) ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _167 <= _105 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _167 > 0 ) )) ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 62;
            OUTPUTFB [ _178]  .Value = (ushort) ( _167 ) ; 
            __context__.SourceCodeLine = 63;
            MakeString ( _182 , " g_rxPositionOnStack[{0:d}] = : {1}", (short)_178, _115 [ _178 ] ) ; 
            __context__.SourceCodeLine = 63;
            _131 (  __context__ , "createRangeInterface  ", _182) ; 
            __context__.SourceCodeLine = 63;
            _179  .UpdateValue ( _115 [ _178 ]  ) ; 
            __context__.SourceCodeLine = 63;
            _180 = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 63;
            do 
                { 
                __context__.SourceCodeLine = 63;
                _170 = (ushort) ( Functions.Find( "/" , _179 ) ) ; 
                __context__.SourceCodeLine = 63;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _170 > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 63;
                    _180 = (ushort) ( (_180 + 1) ) ; 
                    __context__.SourceCodeLine = 63;
                    _181 [ _180 ]  .UpdateValue ( Functions.Remove ( "/" , _179 , 1)  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 63;
                    _180 = (ushort) ( (_180 + 1) ) ; 
                    __context__.SourceCodeLine = 63;
                    _181 [ _180 ]  .UpdateValue ( _179  ) ; 
                    } 
                
                } 
            while (false == ( Functions.TestForTrue  ( Functions.BoolToInt ( _170 < 1 )) )); 
            __context__.SourceCodeLine = 63;
            MakeString ( _182 , " createRangeInterface()  - split2length {0:d}", (short)_180) ; 
            __context__.SourceCodeLine = 63;
            _131 (  __context__ , "createRangeInterface", _182) ; 
            __context__.SourceCodeLine = 63;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _180 > 1 ))  ) ) 
                { 
                __context__.SourceCodeLine = 63;
                _175  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 63;
                _173  .UpdateValue ( _181 [ _180 ]  ) ; 
                __context__.SourceCodeLine = 63;
                ushort __FN_FORSTART_VAL__3 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__3 = (ushort)(_180 - 1); 
                int __FN_FORSTEP_VAL__3 = (int)1; 
                for ( _171  = __FN_FORSTART_VAL__3; (__FN_FORSTEP_VAL__3 > 0)  ? ( (_171  >= __FN_FORSTART_VAL__3) && (_171  <= __FN_FOREND_VAL__3) ) : ( (_171  <= __FN_FORSTART_VAL__3) && (_171  >= __FN_FOREND_VAL__3) ) ; _171  += (ushort)__FN_FORSTEP_VAL__3) 
                    {
                    __context__.SourceCodeLine = 63;
                    _175  .UpdateValue ( _175 + _181 [ _171 ]  ) ; 
                    __context__.SourceCodeLine = 63;
                    }
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 63;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _45( __context__ , _115[ _178 ] , (short)( 1 ) , "gi(%d+)" , ref _183 ) > Functions.ToSignedLongInteger( -( 1 ) ) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 64;
                    _173  .UpdateValue ( _132 (  __context__ , _115[ _178 ], (ushort)( _183._10[ 1 ] ), (ushort)( _183._11[ 1 ] ))  ) ; 
                    __context__.SourceCodeLine = 64;
                    _175  .UpdateValue ( "gi"  ) ; 
                    } 
                
                }
            
            __context__.SourceCodeLine = 64;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_10 != ""))  ) ) 
                {
                __context__.SourceCodeLine = 64;
                _177 = (ushort) ( _45( __context__ , _10 , (short)( 1 ) , _175 , ref _183 ) ) ; 
                }
            
            __context__.SourceCodeLine = 64;
            MakeString ( _182 , "switchLogicalRange() - previousposOnSwitch: {0} posOnSwitch: {1} checkPrefix: {2:d} Prefix: {3} start:{4} ", _174 , _173 , (short)_177, _175 , _10 ) ; 
            __context__.SourceCodeLine = 64;
            _131 (  __context__ , "createRangeInterface", _182) ; 
            __context__.SourceCodeLine = 64;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ((Functions.Atoi( _174 ) + 1) == Functions.Atoi( _173 )) ) && Functions.TestForTrue ( Functions.BoolToInt (_177 != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (_10 == "") )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 64;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_10 == ""))  ) ) 
                    { 
                    __context__.SourceCodeLine = 64;
                    _10  .UpdateValue ( _115 [ _178 ]  ) ; 
                    __context__.SourceCodeLine = 64;
                    _11  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 64;
                    _174  .UpdateValue ( _173  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 64;
                    _11  .UpdateValue ( _173  ) ; 
                    __context__.SourceCodeLine = 64;
                    _174  .UpdateValue ( _173  ) ; 
                    } 
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 64;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_10 != ""))  ) ) 
                    { 
                    __context__.SourceCodeLine = 64;
                    _172 = (ushort) ( (_172 + 1) ) ; 
                    __context__.SourceCodeLine = 64;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_11 == ""))  ) ) 
                        {
                        __context__.SourceCodeLine = 64;
                        _176 [ _172 ]  .UpdateValue ( _10  ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 64;
                        _176 [ _172 ]  .UpdateValue ( _10 + "-" + _11  ) ; 
                        }
                    
                    __context__.SourceCodeLine = 64;
                    _10  .UpdateValue ( _115 [ _178 ]  ) ; 
                    __context__.SourceCodeLine = 64;
                    _11  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 64;
                    _174  .UpdateValue ( _173  ) ; 
                    } 
                
                }
            
            } 
        
        else 
            {
            __context__.SourceCodeLine = 65;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_10 != ""))  ) ) 
                { 
                __context__.SourceCodeLine = 65;
                _172 = (ushort) ( (_172 + 1) ) ; 
                __context__.SourceCodeLine = 65;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_11 == ""))  ) ) 
                    {
                    __context__.SourceCodeLine = 65;
                    _176 [ _172 ]  .UpdateValue ( _10  ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 65;
                    _176 [ _172 ]  .UpdateValue ( _10 + "-" + _11  ) ; 
                    }
                
                __context__.SourceCodeLine = 65;
                _10  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 65;
                _11  .UpdateValue ( ""  ) ; 
                } 
            
            }
        
        __context__.SourceCodeLine = 62;
        } 
    
    __context__.SourceCodeLine = 65;
    if ( Functions.TestForTrue  ( ( _163( __context__ , (ushort)( _167 ) , _176 ))  ) ) 
        { 
        } 
    
    
    }
    
private void _166 (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 65;
    CreateWait ( "__SPLS_TMPVAR__WAITLABEL_16__" , 200 , __SPLS_TMPVAR__WAITLABEL_16___Callback ) ;
    
    }
    
public void __SPLS_TMPVAR__WAITLABEL_16___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 65;
            REBOOTINGINPROGRESS  .Value = (ushort) ( 0 ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

private void _167 (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 65;
    _153 (  __context__  ) ; 
    __context__.SourceCodeLine = 65;
    _93 . _92 = (ushort) ( 0 ) ; 
    
    }
    
private void _168 (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 65;
    _131 (  __context__ , "startUp", "startUp") ; 
    __context__.SourceCodeLine = 65;
    _93 . _89 = (uint) ( _75( __context__ ) ) ; 
    __context__.SourceCodeLine = 65;
    _131 (  __context__ , "Boot time:", Functions.LtoA( (int)( _93._89 ) )) ; 
    __context__.SourceCodeLine = 65;
    _156 (  __context__  ) ; 
    __context__.SourceCodeLine = 65;
    _93 . _92 = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 65;
    _154 (  __context__ , P_SWITCHIP , P_SWITCHPORT ) ; 
    
    }
    
private void _169 (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 65;
    _93 . _88 = (ushort) ( 2 ) ; 
    __context__.SourceCodeLine = 65;
    _93 . _90 = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 65;
    _93 . _91 = (ushort) ( 0 ) ; 
    
    }
    
private ushort _170 (  SplusExecutionContext __context__, ushort _172 ) 
    { 
    ushort _173 = 0;
    ushort _174 = 0;
    ushort _175 = 0;
    ushort _176 = 0;
    ushort _177 = 0;
    
    CrestronString _178;
    CrestronString _179;
    _178  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
    _179  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
    
    
    __context__.SourceCodeLine = 65;
    if ( Functions.TestForTrue  ( ( Functions.Not( _158( __context__ ) ))  ) ) 
        {
        __context__.SourceCodeLine = 65;
        return (ushort)( 0) ; 
        }
    
    __context__.SourceCodeLine = 66;
    _131 (  __context__ , "fnLuxulSwitch_CreateCmdfromTables startFrom", Functions.ItoA( (int)( _172 ) )) ; 
    __context__.SourceCodeLine = 66;
    _131 (  __context__ , "fnLuxulSwitch_CreateCmdfromTables g_MessageHandlerComms.connectState", Functions.ItoA( (int)( _86._84 ) )) ; 
    __context__.SourceCodeLine = 66;
    _124 = (ushort) ( 65535 ) ; 
    __context__.SourceCodeLine = 66;
    _176 = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 66;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _86._84 >= 5 ))  ) ) 
        { 
        __context__.SourceCodeLine = 66;
        _173 = (ushort) ( _172 ) ; 
        __context__.SourceCodeLine = 66;
        while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _173 <= 1500 ))  ) ) 
            { 
            __context__.SourceCodeLine = 66;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_123[ _173 ] != _122[ _173 ]))  ) ) 
                { 
                __context__.SourceCodeLine = 66;
                _176 = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 66;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _173 < 404 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 66;
                    ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                    ushort __FN_FOREND_VAL__1 = (ushort)404; 
                    int __FN_FORSTEP_VAL__1 = (int)1; 
                    for ( _174  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_174  >= __FN_FORSTART_VAL__1) && (_174  <= __FN_FOREND_VAL__1) ) : ( (_174  <= __FN_FORSTART_VAL__1) && (_174  >= __FN_FOREND_VAL__1) ) ; _174  += (ushort)__FN_FORSTEP_VAL__1) 
                        { 
                        __context__.SourceCodeLine = 66;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_123[ _174 ] != _122[ _174 ]) ) && Functions.TestForTrue ( Functions.BoolToInt (_122[ _173 ] == _122[ _174 ]) )) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 66;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_178 != ""))  ) ) 
                                {
                                __context__.SourceCodeLine = 66;
                                _178  .UpdateValue ( _178 + "," + Functions.ItoA (  (int) ( _174 ) )  ) ; 
                                }
                            
                            else 
                                {
                                __context__.SourceCodeLine = 66;
                                _178  .UpdateValue ( Functions.ItoA (  (int) ( _174 ) )  ) ; 
                                }
                            
                            __context__.SourceCodeLine = 66;
                            _123 [ _174 ]  .UpdateValue ( _122 [ _174 ]  ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 66;
                        } 
                    
                    __context__.SourceCodeLine = 66;
                    _165 (  __context__ , (ushort)( Functions.Atoi( _123[ _173 ] ) ), _178) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 66;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _173 > (404 + 1) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _173 < 1380 ) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 66;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _173 >= 500 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _173 < 610 ) )) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 66;
                            _177 = (ushort) ( 1 ) ; 
                            __context__.SourceCodeLine = 67;
                            _175 = (ushort) ( (_173 - 500) ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 67;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _173 >= 610 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _173 < 720 ) )) ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 67;
                                _177 = (ushort) ( 2 ) ; 
                                __context__.SourceCodeLine = 67;
                                _175 = (ushort) ( (_173 - 610) ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 67;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _173 >= 720 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _173 < 830 ) )) ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 67;
                                    _177 = (ushort) ( 3 ) ; 
                                    __context__.SourceCodeLine = 67;
                                    _175 = (ushort) ( (_173 - 720) ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 67;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _173 >= 830 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _173 < 940 ) )) ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 67;
                                        _177 = (ushort) ( 4 ) ; 
                                        __context__.SourceCodeLine = 67;
                                        _175 = (ushort) ( (_173 - 830) ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 67;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _173 >= 940 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _173 < 1050 ) )) ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 67;
                                            _177 = (ushort) ( 5 ) ; 
                                            __context__.SourceCodeLine = 67;
                                            _175 = (ushort) ( (_173 - 940) ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 67;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _173 >= 1050 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _173 < 1160 ) )) ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 67;
                                                _177 = (ushort) ( 6 ) ; 
                                                __context__.SourceCodeLine = 67;
                                                _175 = (ushort) ( (_173 - 1050) ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 67;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _173 >= 1160 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _173 < 1270 ) )) ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 67;
                                                    _177 = (ushort) ( 7 ) ; 
                                                    __context__.SourceCodeLine = 67;
                                                    _175 = (ushort) ( (_173 - 1160) ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 67;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _173 >= 1270 ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 67;
                                                        _177 = (ushort) ( 8 ) ; 
                                                        __context__.SourceCodeLine = 67;
                                                        _175 = (ushort) ( (_173 - 1270) ) ; 
                                                        } 
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        __context__.SourceCodeLine = 67;
                        _131 (  __context__ , "fnLuxulSwitch_CreateCmdfromTables index", Functions.ItoA( (int)( _175 ) )) ; 
                        __context__.SourceCodeLine = 67;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _175 > 52 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 67;
                            _175 = (ushort) ( (_175 - 52) ) ; 
                            __context__.SourceCodeLine = 67;
                            _179  .UpdateValue ( "OFF"  ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 67;
                            _179  .UpdateValue ( "ON"  ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 67;
                        _122 [ _173 ]  .UpdateValue ( "0"  ) ; 
                        __context__.SourceCodeLine = 68;
                        _164 (  __context__ , Functions.ItoA( (int)( _177 ) ), Functions.ItoA( (int)( _175 ) ), _179) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 68;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_173 == 1381))  ) ) 
                            { 
                            __context__.SourceCodeLine = 68;
                            _119 = (ushort) ( 65535 ) ; 
                            __context__.SourceCodeLine = 68;
                            _150 (  __context__ , "show vlan", (ushort)( 11 ), "#", (ushort)( 0 ), "") ; 
                            __context__.SourceCodeLine = 68;
                            _122 [ _173 ]  .UpdateValue ( "0"  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 68;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_173 == 1382))  ) ) 
                                { 
                                __context__.SourceCodeLine = 68;
                                _150 (  __context__ , "show vlan", (ushort)( 11 ), "#", (ushort)( 0 ), "") ; 
                                __context__.SourceCodeLine = 68;
                                _122 [ _173 ]  .UpdateValue ( "0"  ) ; 
                                } 
                            
                            }
                        
                        }
                    
                    }
                
                __context__.SourceCodeLine = 68;
                break ; 
                } 
            
            __context__.SourceCodeLine = 68;
            _173 = (ushort) ( (_173 + 1) ) ; 
            __context__.SourceCodeLine = 68;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _173 > 1500 ))  ) ) 
                { 
                __context__.SourceCodeLine = 68;
                if ( Functions.TestForTrue  ( ( _127)  ) ) 
                    { 
                    __context__.SourceCodeLine = 68;
                    _127 = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 68;
                    _173 = (ushort) ( 1 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 68;
                    _113 = (ushort) ( 65535 ) ; 
                    __context__.SourceCodeLine = 68;
                    _124 = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 68;
                    _173 = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 68;
                    break ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 66;
            } 
        
        } 
    
    __context__.SourceCodeLine = 68;
    _131 (  __context__ , "fnLuxulSwitch_CreateCmdfromTables return i", Functions.ItoA( (int)( _173 ) )) ; 
    __context__.SourceCodeLine = 68;
    return (ushort)( _173) ; 
    
    }
    
private void _171 (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 68;
    if ( Functions.TestForTrue  ( ( Functions.Not( _158( __context__ ) ))  ) ) 
        {
        __context__.SourceCodeLine = 68;
        return ; 
        }
    
    __context__.SourceCodeLine = 68;
    _131 (  __context__ , "fnTriggerChangedStatus g_processingCmdTable", Functions.ItoA( (int)( _124 ) )) ; 
    __context__.SourceCodeLine = 68;
    if ( Functions.TestForTrue  ( ( _124)  ) ) 
        { 
        __context__.SourceCodeLine = 68;
        _127 = (ushort) ( 65535 ) ; 
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 68;
        _113 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 68;
        if ( Functions.TestForTrue  ( ( _93._92)  ) ) 
            {
            __context__.SourceCodeLine = 68;
            _125 = (ushort) ( _170( __context__ , (ushort)( 1 ) ) ) ; 
            }
        
        } 
    
    
    }
    
private void _172 (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 69;
    _131 (  __context__ , "fnLuxulSwitch_beginOperations ", "fnLuxulSwitch_beginOperations") ; 
    __context__.SourceCodeLine = 69;
    _133 (  __context__ , (ushort)( 6 )) ; 
    __context__.SourceCodeLine = 69;
    _131 (  __context__ , "fnLuxulSwitch_loggedOn", "fnLuxulSwitch_loggedOn") ; 
    __context__.SourceCodeLine = 69;
    _150 (  __context__ , "con ter", (ushort)( 0 ), "#", (ushort)( 0 ), "") ; 
    __context__.SourceCodeLine = 69;
    _150 (  __context__ , "ip routing", (ushort)( 0 ), "#", (ushort)( 0 ), "") ; 
    __context__.SourceCodeLine = 69;
    _150 (  __context__ , "exit", (ushort)( 0 ), "#", (ushort)( 0 ), "") ; 
    __context__.SourceCodeLine = 69;
    _150 (  __context__ , "terminal width 0", (ushort)( 0 ), "#", (ushort)( 0 ), "") ; 
    __context__.SourceCodeLine = 69;
    _150 (  __context__ , "terminal length 0", (ushort)( 0 ), "#", (ushort)( 0 ), "") ; 
    __context__.SourceCodeLine = 69;
    _150 (  __context__ , "show vlan", (ushort)( 10 ), "#", (ushort)( 0 ), "") ; 
    __context__.SourceCodeLine = 69;
    _150 (  __context__ , "show version", (ushort)( 12 ), "#", (ushort)( 0 ), "") ; 
    __context__.SourceCodeLine = 69;
    _150 (  __context__ , "show poe", (ushort)( 13 ), "#", (ushort)( 0 ), "") ; 
    
    }
    
private void _173 (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 69;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_93._88 == 1))  ) ) 
        {
        __context__.SourceCodeLine = 69;
        _86 . _85  .UpdateValue ( ""  ) ; 
        }
    
    else 
        {
        __context__.SourceCodeLine = 69;
        _86 . _85  .UpdateValue ( "DEMO "  ) ; 
        }
    
    __context__.SourceCodeLine = 69;
    _93 . _92 = (ushort) ( 65535 ) ; 
    __context__.SourceCodeLine = 69;
    _113 = (ushort) ( 65535 ) ; 
    __context__.SourceCodeLine = 69;
    _133 (  __context__ , (ushort)( 5 )) ; 
    __context__.SourceCodeLine = 69;
    _124 = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 69;
    _125 = (ushort) ( _170( __context__ , (ushort)( 1 ) ) ) ; 
    
    }
    
private void _174 (  SplusExecutionContext __context__ ) 
    { 
    ushort _176 = 0;
    ushort _177 = 0;
    
    CrestronString _178;
    CrestronString _179;
    CrestronString _180;
    CrestronString _181;
    _178  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    _179  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    _180  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5000, this );
    _181  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5000, this );
    
    CrestronString _182;
    CrestronString _183;
    _182  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
    _183  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    
    ushort _184 = 0;
    
    ushort _185 = 0;
    
    ushort [] _186;
    _186  = new ushort[ 17 ];
    
    CrestronString [] _187;
    _187  = new CrestronString[ 17 ];
    for( uint i = 0; i < 17; i++ )
        _187 [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    
    
    __context__.SourceCodeLine = 70;
    _180  .UpdateValue ( _114  ) ; 
    __context__.SourceCodeLine = 70;
    _131 (  __context__ , "checkLicence rxDataMac ", _180) ; 
    __context__.SourceCodeLine = 70;
    while ( Functions.TestForTrue  ( ( Functions.Find( "License Activation is :" , _180 ))  ) ) 
        {
        __context__.SourceCodeLine = 70;
        _181  .UpdateValue ( Functions.Remove ( "License Activation is :" , _180 )  ) ; 
        __context__.SourceCodeLine = 70;
        }
    
    __context__.SourceCodeLine = 70;
    _131 (  __context__ , "checkLicence rxDataMac1 ", _180) ; 
    __context__.SourceCodeLine = 70;
    _180  .UpdateValue ( Functions.Remove ( "\u000A\u000D" , _180 )  ) ; 
    __context__.SourceCodeLine = 70;
    _131 (  __context__ , "checkLicence rxDataMac2 ", _180) ; 
    __context__.SourceCodeLine = 70;
    _182  .UpdateValue ( Functions.Left ( _180 ,  (int) ( (Functions.Length( _180 ) - 2) ) )  ) ; 
    __context__.SourceCodeLine = 70;
    CRESTRONID__DOLLAR__  .UpdateValue ( _180  ) ; 
    __context__.SourceCodeLine = 70;
    _185 = (ushort) ( 16 ) ; 
    __context__.SourceCodeLine = 70;
    _184 = (ushort) ( _72( __context__ , P_SWITCHLICENCEKEY  , (ushort)( _185 ) , ref _186 , ref _187 ) ) ; 
    __context__.SourceCodeLine = 71;
    ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
    ushort __FN_FOREND_VAL__1 = (ushort)_184; 
    int __FN_FORSTEP_VAL__1 = (int)1; 
    for ( _177  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_177  >= __FN_FORSTART_VAL__1) && (_177  <= __FN_FOREND_VAL__1) ) : ( (_177  <= __FN_FORSTART_VAL__1) && (_177  >= __FN_FOREND_VAL__1) ) ; _177  += (ushort)__FN_FORSTEP_VAL__1) 
        { 
        __context__.SourceCodeLine = 71;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_186[ _177 ] == 6))  ) ) 
            { 
            __context__.SourceCodeLine = 71;
            _178  .UpdateValue ( _73 (  __context__ , _187[ _177 ])  ) ; 
            __context__.SourceCodeLine = 71;
            _179  .UpdateValue ( _73 (  __context__ , _182)  ) ; 
            __context__.SourceCodeLine = 71;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_179 == _178))  ) ) 
                {
                __context__.SourceCodeLine = 71;
                _93 . _88 = (ushort) ( 1 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 71;
                _93 . _88 = (ushort) ( 2 ) ; 
                }
            
            __context__.SourceCodeLine = 71;
            break ; 
            } 
        
        __context__.SourceCodeLine = 71;
        } 
    
    __context__.SourceCodeLine = 71;
    if ( Functions.TestForTrue  ( ( _93._88)  ) ) 
        { 
        __context__.SourceCodeLine = 71;
        _93 . _88 = (ushort) ( 2 ) ; 
        __context__.SourceCodeLine = 71;
        ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__2 = (ushort)_184; 
        int __FN_FORSTEP_VAL__2 = (int)1; 
        for ( _177  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (_177  >= __FN_FORSTART_VAL__2) && (_177  <= __FN_FOREND_VAL__2) ) : ( (_177  <= __FN_FORSTART_VAL__2) && (_177  >= __FN_FOREND_VAL__2) ) ; _177  += (ushort)__FN_FORSTEP_VAL__2) 
            { 
            __context__.SourceCodeLine = 71;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_186[ _177 ] == 4))  ) ) 
                { 
                __context__.SourceCodeLine = 71;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_187[ _177 ] == "JADDriver"))  ) ) 
                    {
                    __context__.SourceCodeLine = 71;
                    _93 . _88 = (ushort) ( 1 ) ; 
                    }
                
                __context__.SourceCodeLine = 71;
                break ; 
                } 
            
            __context__.SourceCodeLine = 71;
            } 
        
        } 
    
    __context__.SourceCodeLine = 71;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_93._88 == 1))  ) ) 
        {
        __context__.SourceCodeLine = 71;
        _183  .UpdateValue ( "Licensed"  ) ; 
        }
    
    else 
        {
        __context__.SourceCodeLine = 71;
        _183  .UpdateValue ( "Demo license"  ) ; 
        }
    
    __context__.SourceCodeLine = 71;
    _131 (  __context__ , "checkLicence", _183) ; 
    __context__.SourceCodeLine = 71;
    _93 . _90 = (ushort) ( _105 ) ; 
    __context__.SourceCodeLine = 71;
    _93 . _91 = (ushort) ( _106 ) ; 
    __context__.SourceCodeLine = 71;
    _112 = (ushort) ( (_105 + _106) ) ; 
    __context__.SourceCodeLine = 71;
    NUMOFINPUTS  .Value = (ushort) ( _93._90 ) ; 
    __context__.SourceCodeLine = 71;
    NUMOFOUTPUTS  .Value = (ushort) ( _93._91 ) ; 
    
    }
    
private void _175 (  SplusExecutionContext __context__, CrestronString _177 , CrestronString [] _178 , ushort _179 , ushort _180 ) 
    { 
    ushort _181 = 0;
    
    
    __context__.SourceCodeLine = 71;
    _178 [ 1]  .UpdateValue ( Functions.Mid ( _177 ,  (int) ( 1 ) ,  (int) ( (_179 - 1) ) )  ) ; 
    __context__.SourceCodeLine = 72;
    _178 [ 2]  .UpdateValue ( Functions.Mid ( _177 ,  (int) ( _179 ) ,  (int) ( ((_180 - _179) - 1) ) )  ) ; 
    __context__.SourceCodeLine = 72;
    _178 [ 3]  .UpdateValue ( Functions.Right ( _177 ,  (int) ( ((Functions.Length( _177 ) - _180) + 1) ) )  ) ; 
    __context__.SourceCodeLine = 72;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Right( _178[ 3 ] , (int)( 2 ) ) == "\r\n"))  ) ) 
        {
        __context__.SourceCodeLine = 72;
        _178 [ 3]  .UpdateValue ( Functions.Left ( _178 [ 3] ,  (int) ( (Functions.Length( _178[ 3 ] ) - 2) ) )  ) ; 
        }
    
    __context__.SourceCodeLine = 72;
    ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
    ushort __FN_FOREND_VAL__1 = (ushort)2; 
    int __FN_FORSTEP_VAL__1 = (int)1; 
    for ( _181  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_181  >= __FN_FORSTART_VAL__1) && (_181  <= __FN_FOREND_VAL__1) ) : ( (_181  <= __FN_FORSTART_VAL__1) && (_181  >= __FN_FOREND_VAL__1) ) ; _181  += (ushort)__FN_FORSTEP_VAL__1) 
        { 
        __context__.SourceCodeLine = 72;
        while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Right( _178[ _181 ] , (int)( 1 ) ) == " ") ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( _178[ _181 ] ) > 0 ) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 72;
            _178 [ _181]  .UpdateValue ( Functions.Left ( _178 [ _181] ,  (int) ( (Functions.Length( _178[ _181 ] ) - 1) ) )  ) ; 
            __context__.SourceCodeLine = 72;
            }
        
        __context__.SourceCodeLine = 72;
        } 
    
    
    }
    
private ushort _176 (  SplusExecutionContext __context__, CrestronString _178 , ushort _179 , CrestronString _180 , CrestronString _181 ) 
    { 
    CrestronString _182;
    _182  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
    
    ushort _183 = 0;
    
    
    __context__.SourceCodeLine = 72;
    _182  .UpdateValue ( _178  ) ; 
    __context__.SourceCodeLine = 72;
    _181  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 72;
    ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
    ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( _182 ); 
    int __FN_FORSTEP_VAL__1 = (int)1; 
    for ( _183  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_183  >= __FN_FORSTART_VAL__1) && (_183  <= __FN_FOREND_VAL__1) ) : ( (_183  <= __FN_FORSTART_VAL__1) && (_183  >= __FN_FOREND_VAL__1) ) ; _183  += (ushort)__FN_FORSTEP_VAL__1) 
        { 
        __context__.SourceCodeLine = 72;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( _182 , (int)( _183 ) ) == _179))  ) ) 
            { 
            __context__.SourceCodeLine = 72;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_180 != ""))  ) ) 
                {
                __context__.SourceCodeLine = 72;
                _181  .UpdateValue ( _181 + _180  ) ; 
                }
            
            } 
        
        else 
            {
            __context__.SourceCodeLine = 72;
            _181  .UpdateValue ( _181 + Functions.Chr (  (int) ( Byte( _182 , (int)( _183 ) ) ) )  ) ; 
            }
        
        __context__.SourceCodeLine = 72;
        } 
    
    
    return 0; // default return value (none specified in module)
    }
    
private ushort _177 (  SplusExecutionContext __context__, CrestronString _179 , ushort _180 , CrestronString [] _181 ) 
    { 
    CrestronString _182;
    _182  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
    
    ushort _183 = 0;
    ushort _184 = 0;
    
    
    __context__.SourceCodeLine = 73;
    _182  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 73;
    _184 = (ushort) ( 1 ) ; 
    __context__.SourceCodeLine = 73;
    ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
    ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( _179 ); 
    int __FN_FORSTEP_VAL__1 = (int)1; 
    for ( _183  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_183  >= __FN_FORSTART_VAL__1) && (_183  <= __FN_FOREND_VAL__1) ) : ( (_183  <= __FN_FORSTART_VAL__1) && (_183  >= __FN_FOREND_VAL__1) ) ; _183  += (ushort)__FN_FORSTEP_VAL__1) 
        { 
        __context__.SourceCodeLine = 73;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( _179 , (int)( _183 ) ) == _180))  ) ) 
            { 
            __context__.SourceCodeLine = 73;
            _181 [ _184]  .UpdateValue ( _182  ) ; 
            __context__.SourceCodeLine = 73;
            _184 = (ushort) ( (_184 + 1) ) ; 
            __context__.SourceCodeLine = 73;
            _182  .UpdateValue ( ""  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 73;
            _182  .UpdateValue ( _182 + Functions.Chr (  (int) ( Byte( _179 , (int)( _183 ) ) ) )  ) ; 
            } 
        
        __context__.SourceCodeLine = 73;
        } 
    
    __context__.SourceCodeLine = 73;
    _181 [ _184]  .UpdateValue ( _182  ) ; 
    __context__.SourceCodeLine = 73;
    return (ushort)( _184) ; 
    
    }
    
private ushort _178 (  SplusExecutionContext __context__, CrestronString _180 , ushort [] _181 ) 
    { 
    CrestronString _182;
    _182  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
    
    CrestronString [] _183;
    _183  = new CrestronString[ 101 ];
    for( uint i = 0; i < 101; i++ )
        _183 [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
    
    ushort _184 = 0;
    ushort _185 = 0;
    ushort _186 = 0;
    
    ushort _187 = 0;
    ushort _188 = 0;
    ushort _189 = 0;
    
    ushort _190 = 0;
    
    
    __context__.SourceCodeLine = 73;
    _190 = (ushort) ( 1 ) ; 
    __context__.SourceCodeLine = 73;
    _176 (  __context__ , _180, (ushort)( Byte( " " , (int)( 1 ) ) ), "", _182) ; 
    __context__.SourceCodeLine = 73;
    _189 = (ushort) ( _177( __context__ , _182 , (ushort)( Byte( "," , (int)( 1 ) ) ) , _183 ) ) ; 
    __context__.SourceCodeLine = 73;
    ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
    ushort __FN_FOREND_VAL__1 = (ushort)_189; 
    int __FN_FORSTEP_VAL__1 = (int)1; 
    for ( _188  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_188  >= __FN_FORSTART_VAL__1) && (_188  <= __FN_FOREND_VAL__1) ) : ( (_188  <= __FN_FORSTART_VAL__1) && (_188  >= __FN_FOREND_VAL__1) ) ; _188  += (ushort)__FN_FORSTEP_VAL__1) 
        { 
        __context__.SourceCodeLine = 74;
        _187 = (ushort) ( Functions.Find( "-" , _183[ _188 ] ) ) ; 
        __context__.SourceCodeLine = 74;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_187 == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 74;
            _184 = (ushort) ( Functions.Atoi( _183[ _188 ] ) ) ; 
            __context__.SourceCodeLine = 74;
            _181 [ _190] = (ushort) ( _184 ) ; 
            __context__.SourceCodeLine = 74;
            _190 = (ushort) ( (_190 + 1) ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 74;
            _185 = (ushort) ( Functions.Atoi( Functions.Left( _183[ _188 ] , (int)( _187 ) ) ) ) ; 
            __context__.SourceCodeLine = 74;
            _186 = (ushort) ( Functions.Atoi( Functions.Right( _183[ _188 ] , (int)( (Functions.Length( _183[ _188 ] ) - _187) ) ) ) ) ; 
            __context__.SourceCodeLine = 74;
            ushort __FN_FORSTART_VAL__2 = (ushort) ( _185 ) ;
            ushort __FN_FOREND_VAL__2 = (ushort)_186; 
            int __FN_FORSTEP_VAL__2 = (int)1; 
            for ( _184  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (_184  >= __FN_FORSTART_VAL__2) && (_184  <= __FN_FOREND_VAL__2) ) : ( (_184  <= __FN_FORSTART_VAL__2) && (_184  >= __FN_FOREND_VAL__2) ) ; _184  += (ushort)__FN_FORSTEP_VAL__2) 
                { 
                __context__.SourceCodeLine = 74;
                _181 [ _190] = (ushort) ( _184 ) ; 
                __context__.SourceCodeLine = 74;
                _190 = (ushort) ( (_190 + 1) ) ; 
                __context__.SourceCodeLine = 74;
                } 
            
            } 
        
        __context__.SourceCodeLine = 73;
        } 
    
    __context__.SourceCodeLine = 74;
    return (ushort)( (_190 - 1)) ; 
    
    }
    
private ushort _179 (  SplusExecutionContext __context__, CrestronString _181 ) 
    { 
    ushort _182 = 0;
    
    
    __context__.SourceCodeLine = 74;
    ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
    ushort __FN_FOREND_VAL__1 = (ushort)250; 
    int __FN_FORSTEP_VAL__1 = (int)1; 
    for ( _182  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_182  >= __FN_FORSTART_VAL__1) && (_182  <= __FN_FOREND_VAL__1) ) : ( (_182  <= __FN_FORSTART_VAL__1) && (_182  >= __FN_FOREND_VAL__1) ) ; _182  += (ushort)__FN_FORSTEP_VAL__1) 
        {
        __context__.SourceCodeLine = 74;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_115[ _182 ] == _181))  ) ) 
            {
            __context__.SourceCodeLine = 74;
            return (ushort)( _182) ; 
            }
        
        __context__.SourceCodeLine = 74;
        }
    
    __context__.SourceCodeLine = 74;
    return (ushort)( 0) ; 
    
    }
    
private ushort _180 (  SplusExecutionContext __context__, CrestronString _182 ) 
    { 
    ushort _183 = 0;
    
    
    __context__.SourceCodeLine = 74;
    ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
    ushort __FN_FOREND_VAL__1 = (ushort)250; 
    int __FN_FORSTEP_VAL__1 = (int)1; 
    for ( _183  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_183  >= __FN_FORSTART_VAL__1) && (_183  <= __FN_FOREND_VAL__1) ) : ( (_183  <= __FN_FORSTART_VAL__1) && (_183  >= __FN_FOREND_VAL__1) ) ; _183  += (ushort)__FN_FORSTEP_VAL__1) 
        {
        __context__.SourceCodeLine = 74;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_116[ _183 ] == _182))  ) ) 
            {
            __context__.SourceCodeLine = 74;
            return (ushort)( _183) ; 
            }
        
        __context__.SourceCodeLine = 74;
        }
    
    __context__.SourceCodeLine = 74;
    return (ushort)( 0) ; 
    
    }
    
private ushort _181 (  SplusExecutionContext __context__, CrestronString _183 ) 
    { 
    CrestronString _184;
    _184  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64000, this );
    
    CrestronString [] _185;
    CrestronString _186;
    CrestronString _187;
    _186  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
    _187  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
    _185  = new CrestronString[ 6 ];
    for( uint i = 0; i < 6; i++ )
        _185 [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    
    CrestronString [] _188;
    _188  = new CrestronString[ 501 ];
    for( uint i = 0; i < 501; i++ )
        _188 [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    
    CrestronString _189;
    _189  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    
    CrestronString _190;
    CrestronString _191;
    _190  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    _191  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    
    ushort _192 = 0;
    ushort _193 = 0;
    ushort _194 = 0;
    ushort _195 = 0;
    ushort _196 = 0;
    
    ushort [] _197;
    _197  = new ushort[ 51 ];
    
    ushort _198 = 0;
    
    ushort _199 = 0;
    ushort _200 = 0;
    ushort _201 = 0;
    
    ushort _202 = 0;
    ushort _203 = 0;
    
    
    __context__.SourceCodeLine = 75;
    _184  .UpdateValue ( _183  ) ; 
    __context__.SourceCodeLine = 75;
    _199 = (ushort) ( 65535 ) ; 
    __context__.SourceCodeLine = 75;
    _198 = (ushort) ( 1 ) ; 
    __context__.SourceCodeLine = 75;
    while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\r\n" , _184 , 1 ) > 0 ))  ) ) 
        { 
        __context__.SourceCodeLine = 75;
        _186  .UpdateValue ( Functions.Remove ( "\r\n" , _184 , 1)  ) ; 
        __context__.SourceCodeLine = 75;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_186 == "") ) || Functions.TestForTrue ( Functions.BoolToInt (_186 == "\r\n") )) ))  ) ) 
            {
            __context__.SourceCodeLine = 75;
            continue ; 
            }
        
        __context__.SourceCodeLine = 75;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( _186 , (int)( 4 ) ) == "VLAN"))  ) ) 
            { 
            __context__.SourceCodeLine = 75;
            _202 = (ushort) ( Functions.Find( "Name" , _186 , 1 ) ) ; 
            __context__.SourceCodeLine = 75;
            _203 = (ushort) ( Functions.Find( "Interface" , _186 , 1 ) ) ; 
            __context__.SourceCodeLine = 75;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_202 == 0) ) || Functions.TestForTrue ( Functions.BoolToInt (_203 == 0) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 75;
                _131 (  __context__ , "Luxul_FillPosition", "Couldn't find Name and Interface in VLAN table") ; 
                __context__.SourceCodeLine = 76;
                break ; 
                } 
            
            __context__.SourceCodeLine = 76;
            continue ; 
            } 
        
        __context__.SourceCodeLine = 76;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( _186 , (int)( 4 ) ) == "----"))  ) ) 
            {
            __context__.SourceCodeLine = 76;
            continue ; 
            }
        
        __context__.SourceCodeLine = 76;
        _175 (  __context__ , _186, _185, (ushort)( _202 ), (ushort)( _203 )) ; 
        __context__.SourceCodeLine = 76;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( _186 , (int)( 1 ) ) == " "))  ) ) 
            { 
            __context__.SourceCodeLine = 76;
            _185 [ 2 ]  .UpdateValue ( _189  ) ; 
            __context__.SourceCodeLine = 76;
            _201 = (ushort) ( 65535 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 76;
            _189  .UpdateValue ( _185 [ 2 ]  ) ; 
            __context__.SourceCodeLine = 76;
            _201 = (ushort) ( 0 ) ; 
            } 
        
        __context__.SourceCodeLine = 76;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( _185[ 2 ] , (int)( 4 ) ) == "JAP_"))  ) ) 
            { 
            __context__.SourceCodeLine = 76;
            if ( Functions.TestForTrue  ( ( Functions.Not( _201 ))  ) ) 
                { 
                __context__.SourceCodeLine = 76;
                _190  .UpdateValue ( Functions.Right ( _185 [ 2 ] ,  (int) ( (Functions.Length( _185[ 2 ] ) - 4) ) )  ) ; 
                __context__.SourceCodeLine = 76;
                _105 = (ushort) ( Functions.Atoi( Functions.Remove( "x" , _190 , 1 ) ) ) ; 
                __context__.SourceCodeLine = 76;
                _106 = (ushort) ( Functions.Atoi( _190 ) ) ; 
                __context__.SourceCodeLine = 76;
                MakeString ( _191 , "JAP found with {0:d} TX and {1:d} RX", (short)_105, (short)_106) ; 
                __context__.SourceCodeLine = 76;
                _131 (  __context__ , "Luxul_FillPosition", _191) ; 
                } 
            
            __context__.SourceCodeLine = 76;
            _190  .UpdateValue ( Functions.Right ( _185 [ 3 ] ,  (int) ( (Functions.Length( _185[ 3 ] ) - 3) ) )  ) ; 
            __context__.SourceCodeLine = 76;
            _193 = (ushort) ( Functions.Atoi( Functions.Remove( "/" , _190 , 1 ) ) ) ; 
            __context__.SourceCodeLine = 76;
            _195 = (ushort) ( _178( __context__ , _190 , (ushort[])( _197 ) ) ) ; 
            __context__.SourceCodeLine = 76;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)_195; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( _192  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_192  >= __FN_FORSTART_VAL__1) && (_192  <= __FN_FOREND_VAL__1) ) : ( (_192  <= __FN_FORSTART_VAL__1) && (_192  >= __FN_FOREND_VAL__1) ) ; _192  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 76;
                MakeString ( _190 , "{0:d}/{1:d}", (short)_193, (short)_197[ _192 ]) ; 
                __context__.SourceCodeLine = 77;
                _188 [ _198 ]  .UpdateValue ( _190  ) ; 
                __context__.SourceCodeLine = 77;
                MakeString ( _191 , "{0} added to possible interfaces", _190 ) ; 
                __context__.SourceCodeLine = 77;
                _131 (  __context__ , "Luxul_FillPosition", _191) ; 
                __context__.SourceCodeLine = 77;
                _198 = (ushort) ( (_198 + 1) ) ; 
                __context__.SourceCodeLine = 76;
                } 
            
            } 
        
        __context__.SourceCodeLine = 77;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Left( _185[ 2 ] , (int)( 3 ) ) == "TX_") ) && Functions.TestForTrue ( Functions.Not( _201 ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 77;
            _196 = (ushort) ( (Functions.Atoi( _185[ 1 ] ) - 10) ) ; 
            __context__.SourceCodeLine = 77;
            _190  .UpdateValue ( _185 [ 2 ]  ) ; 
            __context__.SourceCodeLine = 77;
            _191  .UpdateValue ( Functions.Remove ( "_" , _190 , 1)  ) ; 
            __context__.SourceCodeLine = 77;
            _191  .UpdateValue ( Functions.Remove ( "_gi" , _190 , 1)  ) ; 
            __context__.SourceCodeLine = 77;
            _116 [ _196 ]  .UpdateValue ( _190  ) ; 
            __context__.SourceCodeLine = 77;
            ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__2 = (ushort)_198; 
            int __FN_FORSTEP_VAL__2 = (int)1; 
            for ( _192  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (_192  >= __FN_FORSTART_VAL__2) && (_192  <= __FN_FOREND_VAL__2) ) : ( (_192  <= __FN_FORSTART_VAL__2) && (_192  >= __FN_FOREND_VAL__2) ) ; _192  += (ushort)__FN_FORSTEP_VAL__2) 
                { 
                __context__.SourceCodeLine = 77;
                _200 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 77;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_188[ _192 ] == _116[ _196 ]))  ) ) 
                    { 
                    __context__.SourceCodeLine = 77;
                    _188 [ _192 ]  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 77;
                    _200 = (ushort) ( 65535 ) ; 
                    __context__.SourceCodeLine = 77;
                    break ; 
                    } 
                
                __context__.SourceCodeLine = 77;
                } 
            
            __context__.SourceCodeLine = 77;
            if ( Functions.TestForTrue  ( ( Functions.Not( _200 ))  ) ) 
                { 
                __context__.SourceCodeLine = 77;
                MakeString ( _191 , "Couldn't find {0} in possible interfaces.  iNumPossibleInterfaces = {1:d}", _116 [ _196 ] , (short)_198) ; 
                __context__.SourceCodeLine = 77;
                _131 (  __context__ , "Luxul_FillPosition", _191) ; 
                __context__.SourceCodeLine = 77;
                _199 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 77;
                break ; 
                } 
            
            } 
        
        __context__.SourceCodeLine = 75;
        } 
    
    __context__.SourceCodeLine = 77;
    _194 = (ushort) ( 1 ) ; 
    __context__.SourceCodeLine = 78;
    ushort __FN_FORSTART_VAL__3 = (ushort) ( 1 ) ;
    ushort __FN_FOREND_VAL__3 = (ushort)_198; 
    int __FN_FORSTEP_VAL__3 = (int)1; 
    for ( _192  = __FN_FORSTART_VAL__3; (__FN_FORSTEP_VAL__3 > 0)  ? ( (_192  >= __FN_FORSTART_VAL__3) && (_192  <= __FN_FOREND_VAL__3) ) : ( (_192  <= __FN_FORSTART_VAL__3) && (_192  >= __FN_FOREND_VAL__3) ) ; _192  += (ushort)__FN_FORSTEP_VAL__3) 
        { 
        __context__.SourceCodeLine = 78;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_188[ _192 ] == ""))  ) ) 
            {
            __context__.SourceCodeLine = 78;
            continue ; 
            }
        
        __context__.SourceCodeLine = 78;
        _115 [ _194 ]  .UpdateValue ( _188 [ _192 ]  ) ; 
        __context__.SourceCodeLine = 78;
        _194 = (ushort) ( (_194 + 1) ) ; 
        __context__.SourceCodeLine = 78;
        } 
    
    __context__.SourceCodeLine = 78;
    if ( Functions.TestForTrue  ( ( Functions.Not( _199 ))  ) ) 
        {
        __context__.SourceCodeLine = 78;
        _131 (  __context__ , "Luxul", "Invalid config") ; 
        }
    
    __context__.SourceCodeLine = 78;
    return (ushort)( _199) ; 
    
    }
    
private ushort _182 (  SplusExecutionContext __context__, CrestronString _184 , ushort _185 ) 
    { 
    CrestronString [] _186;
    CrestronString _187;
    CrestronString _188;
    _187  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
    _188  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
    _186  = new CrestronString[ 6 ];
    for( uint i = 0; i < 6; i++ )
        _186 [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    
    CrestronString _189;
    _189  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    
    CrestronString _190;
    CrestronString _191;
    _190  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    _191  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    
    ushort _192 = 0;
    ushort _193 = 0;
    ushort _194 = 0;
    ushort _195 = 0;
    ushort _196 = 0;
    
    ushort [] _197;
    _197  = new ushort[ 51 ];
    
    ushort _198 = 0;
    ushort _199 = 0;
    ushort _200 = 0;
    
    ushort _201 = 0;
    ushort _202 = 0;
    
    
    __context__.SourceCodeLine = 78;
    if ( Functions.TestForTrue  ( ( _185)  ) ) 
        {
        __context__.SourceCodeLine = 78;
        _181 (  __context__ , _184) ; 
        }
    
    __context__.SourceCodeLine = 78;
    _198 = (ushort) ( 65535 ) ; 
    __context__.SourceCodeLine = 78;
    while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\r\n" , _184 , 1 ) > 0 ))  ) ) 
        { 
        __context__.SourceCodeLine = 78;
        _187  .UpdateValue ( Functions.Remove ( "\r\n" , _184 , 1)  ) ; 
        __context__.SourceCodeLine = 78;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_187 == "") ) || Functions.TestForTrue ( Functions.BoolToInt (_187 == "\r\n") )) ))  ) ) 
            {
            __context__.SourceCodeLine = 78;
            continue ; 
            }
        
        __context__.SourceCodeLine = 78;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( _187 , (int)( 4 ) ) == "VLAN"))  ) ) 
            { 
            __context__.SourceCodeLine = 79;
            _201 = (ushort) ( Functions.Find( "Name" , _187 , 1 ) ) ; 
            __context__.SourceCodeLine = 79;
            _202 = (ushort) ( Functions.Find( "Interface" , _187 , 1 ) ) ; 
            __context__.SourceCodeLine = 79;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_201 == 0) ) || Functions.TestForTrue ( Functions.BoolToInt (_202 == 0) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 79;
                _131 (  __context__ , "Luxul", "Couldn't find Name and Interface in VLAN table") ; 
                __context__.SourceCodeLine = 79;
                break ; 
                } 
            
            __context__.SourceCodeLine = 79;
            continue ; 
            } 
        
        __context__.SourceCodeLine = 79;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( _187 , (int)( 4 ) ) == "----"))  ) ) 
            {
            __context__.SourceCodeLine = 79;
            continue ; 
            }
        
        __context__.SourceCodeLine = 79;
        _175 (  __context__ , _187, _186, (ushort)( _201 ), (ushort)( _202 )) ; 
        __context__.SourceCodeLine = 79;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( _187 , (int)( 1 ) ) == " "))  ) ) 
            { 
            __context__.SourceCodeLine = 79;
            _186 [ 2 ]  .UpdateValue ( _189  ) ; 
            __context__.SourceCodeLine = 79;
            _200 = (ushort) ( 65535 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 79;
            _189  .UpdateValue ( _186 [ 2 ]  ) ; 
            __context__.SourceCodeLine = 79;
            _200 = (ushort) ( 0 ) ; 
            } 
        
        __context__.SourceCodeLine = 79;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( _186[ 2 ] , (int)( 4 ) ) == "JAP_"))  ) ) 
            {
            __context__.SourceCodeLine = 79;
            continue ; 
            }
        
        __context__.SourceCodeLine = 79;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Left( _186[ 2 ] , (int)( 3 ) ) == "TX_") ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Left( _186[ 3 ] , (int)( 3 ) ) == "Gi ") )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 79;
            _190  .UpdateValue ( Functions.Right ( _186 [ 3 ] ,  (int) ( (Functions.Length( _186[ 3 ] ) - 3) ) )  ) ; 
            __context__.SourceCodeLine = 79;
            _194 = (ushort) ( Functions.Atoi( Functions.Remove( "/" , _190 , 1 ) ) ) ; 
            __context__.SourceCodeLine = 79;
            _195 = (ushort) ( _178( __context__ , _190 , (ushort[])( _197 ) ) ) ; 
            __context__.SourceCodeLine = 79;
            if ( Functions.TestForTrue  ( ( Functions.Not( _200 ))  ) ) 
                {
                __context__.SourceCodeLine = 79;
                _193 = (ushort) ( (Functions.Atoi( _186[ 1 ] ) - 10) ) ; 
                }
            
            __context__.SourceCodeLine = 79;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)_195; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( _192  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_192  >= __FN_FORSTART_VAL__1) && (_192  <= __FN_FOREND_VAL__1) ) : ( (_192  <= __FN_FORSTART_VAL__1) && (_192  >= __FN_FOREND_VAL__1) ) ; _192  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 80;
                MakeString ( _190 , "{0:d}/{1:d}", (short)_194, (short)_197[ _192 ]) ; 
                __context__.SourceCodeLine = 80;
                _196 = (ushort) ( _179( __context__ , _190 ) ) ; 
                __context__.SourceCodeLine = 80;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_196 == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 80;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_180( __context__ , _190 ) == 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 80;
                        MakeString ( _191 , "Couldn't find mapping for {0}", _190 ) ; 
                        __context__.SourceCodeLine = 80;
                        _131 (  __context__ , "Luxul", _191) ; 
                        } 
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 80;
                    _123 [ _196 ]  .UpdateValue ( _116 [ _193 ]  ) ; 
                    __context__.SourceCodeLine = 80;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_185 == 65535))  ) ) 
                        {
                        __context__.SourceCodeLine = 80;
                        _122 [ _196 ]  .UpdateValue ( _116 [ _193 ]  ) ; 
                        }
                    
                    __context__.SourceCodeLine = 80;
                    MakeString ( _191 , "Output {0} = Input {1}", _190 , _123 [ _196 ] ) ; 
                    __context__.SourceCodeLine = 80;
                    _131 (  __context__ , "Luxul", _191) ; 
                    } 
                
                __context__.SourceCodeLine = 79;
                } 
            
            } 
        
        __context__.SourceCodeLine = 78;
        } 
    
    __context__.SourceCodeLine = 80;
    if ( Functions.TestForTrue  ( ( _198)  ) ) 
        { 
        __context__.SourceCodeLine = 80;
        ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__2 = (ushort)_106; 
        int __FN_FORSTEP_VAL__2 = (int)1; 
        for ( _192  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (_192  >= __FN_FORSTART_VAL__2) && (_192  <= __FN_FOREND_VAL__2) ) : ( (_192  <= __FN_FORSTART_VAL__2) && (_192  >= __FN_FOREND_VAL__2) ) ; _192  += (ushort)__FN_FORSTEP_VAL__2) 
            { 
            __context__.SourceCodeLine = 80;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_123[ _192 ] == ""))  ) ) 
                { 
                __context__.SourceCodeLine = 80;
                _198 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 80;
                MakeString ( _191 , "Output {0:d} is unassigned", (short)_192) ; 
                __context__.SourceCodeLine = 80;
                _131 (  __context__ , "Luxul", _191) ; 
                } 
            
            __context__.SourceCodeLine = 80;
            } 
        
        } 
    
    __context__.SourceCodeLine = 80;
    if ( Functions.TestForTrue  ( ( Functions.Not( _198 ))  ) ) 
        { 
        __context__.SourceCodeLine = 80;
        _131 (  __context__ , "Luxul", "Invalid config found") ; 
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 80;
        ushort __FN_FORSTART_VAL__3 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__3 = (ushort)_106; 
        int __FN_FORSTEP_VAL__3 = (int)1; 
        for ( _192  = __FN_FORSTART_VAL__3; (__FN_FORSTEP_VAL__3 > 0)  ? ( (_192  >= __FN_FORSTART_VAL__3) && (_192  <= __FN_FOREND_VAL__3) ) : ( (_192  <= __FN_FORSTART_VAL__3) && (_192  >= __FN_FOREND_VAL__3) ) ; _192  += (ushort)__FN_FORSTEP_VAL__3) 
            { 
            __context__.SourceCodeLine = 81;
            OUTPUTFB [ _192]  .Value = (ushort) ( _180( __context__ , _123[ _192 ] ) ) ; 
            __context__.SourceCodeLine = 81;
            MakeString ( _191 , "Output {0:d} on port {1} is set to input {2:d} on port {3}", (short)_192, _115 [ _192 ] , (short)_180( __context__ , _123[ _192 ] ), _123 [ _192 ] ) ; 
            __context__.SourceCodeLine = 81;
            _131 (  __context__ , "Luxul", _191) ; 
            __context__.SourceCodeLine = 80;
            } 
        
        } 
    
    __context__.SourceCodeLine = 81;
    return (ushort)( _198) ; 
    
    }
    
private void _183 (  SplusExecutionContext __context__, CrestronString _185 ) 
    { 
    
    __context__.SourceCodeLine = 81;
    if ( Functions.TestForTrue  ( ( _182( __context__ , _185 , (ushort)( 65535 ) ))  ) ) 
        { 
        __context__.SourceCodeLine = 81;
        REBOOTINGINPROGRESS  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 81;
        ERRORMSG__DOLLAR__  .UpdateValue ( "NONE"  ) ; 
        __context__.SourceCodeLine = 81;
        _174 (  __context__  ) ; 
        __context__.SourceCodeLine = 81;
        _126 = (ushort) ( 65535 ) ; 
        __context__.SourceCodeLine = 81;
        _173 (  __context__  ) ; 
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 81;
        if ( Functions.TestForTrue  ( ( Functions.Not( _118 ))  ) ) 
            { 
            __context__.SourceCodeLine = 81;
            _118 = (ushort) ( 65535 ) ; 
            __context__.SourceCodeLine = 81;
            REBOOTINGINPROGRESS  .Value = (ushort) ( 65535 ) ; 
            __context__.SourceCodeLine = 81;
            ERRORMSG__DOLLAR__  .UpdateValue ( "The module has detected an unusable configuration on the switch.\r\n\r\n" + "Restoring switch to default configuration.\r\n\r\nThis may take several minutes."  ) ; 
            __context__.SourceCodeLine = 82;
            _150 (  __context__ , "reload cold", (ushort)( 0 ), "% Cold reload in progress, please stand by.", (ushort)( 19 ), "Try Again Later") ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 82;
            REBOOTINGINPROGRESS  .Value = (ushort) ( 65535 ) ; 
            __context__.SourceCodeLine = 82;
            ERRORMSG__DOLLAR__  .UpdateValue ( "Bad Switch configuration\r\n\r\n Please run JAD CONFIG Again"  ) ; 
            __context__.SourceCodeLine = 82;
            CreateWait ( "__SPLS_TMPVAR__WAITLABEL_17__" , 200 , __SPLS_TMPVAR__WAITLABEL_17___Callback ) ;
            } 
        
        } 
    
    
    }
    
public void __SPLS_TMPVAR__WAITLABEL_17___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 82;
            REBOOTINGINPROGRESS  .Value = (ushort) ( 0 ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

private void _184 (  SplusExecutionContext __context__, CrestronString _186 ) 
    { 
    CrestronString _187;
    CrestronString _188;
    CrestronString _189;
    CrestronString _190;
    _187  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
    _188  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    _189  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
    _190  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    
    ushort _191 = 0;
    ushort _192 = 0;
    
    ushort _193 = 0;
    
    
    __context__.SourceCodeLine = 82;
    while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\r\n" , _186 , 1 ) > 0 ))  ) ) 
        { 
        __context__.SourceCodeLine = 82;
        _187  .UpdateValue ( Functions.Remove ( "\r\n" , _186 , 1)  ) ; 
        __context__.SourceCodeLine = 82;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_187 == "") ) || Functions.TestForTrue ( Functions.BoolToInt (_187 == "\r\n") )) ))  ) ) 
            {
            __context__.SourceCodeLine = 82;
            continue ; 
            }
        
        __context__.SourceCodeLine = 82;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( _187 , (int)( 9 ) ) == "Interface"))  ) ) 
            { 
            __context__.SourceCodeLine = 82;
            _193 = (ushort) ( Functions.Find( "Port Status" , _187 , 1 ) ) ; 
            __context__.SourceCodeLine = 82;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_193 == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 83;
                _131 (  __context__ , "Luxul", "Couldn't find Port Status in PoE table") ; 
                __context__.SourceCodeLine = 83;
                break ; 
                } 
            
            __context__.SourceCodeLine = 83;
            continue ; 
            } 
        
        __context__.SourceCodeLine = 83;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( _187 , (int)( 4 ) ) == "----"))  ) ) 
            {
            __context__.SourceCodeLine = 83;
            continue ; 
            }
        
        __context__.SourceCodeLine = 83;
        _188  .UpdateValue ( Functions.Left ( _187 ,  (int) ( _193 ) )  ) ; 
        __context__.SourceCodeLine = 83;
        _191 = (ushort) ( Functions.Atoi( Functions.Remove( "/" , _188 , 1 ) ) ) ; 
        __context__.SourceCodeLine = 83;
        _192 = (ushort) ( Functions.Atoi( Functions.Left( _188 , (int)( 3 ) ) ) ) ; 
        __context__.SourceCodeLine = 83;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_191 == 0) ) || Functions.TestForTrue ( Functions.BoolToInt (_192 == 0) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 83;
            continue ; 
            }
        
        __context__.SourceCodeLine = 83;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Mid( _187 , (int)( _193 ) , (int)( 12 ) ) == "PoE disabled") ) || Functions.TestForTrue ( Functions.BoolToInt (Functions.Mid( _187 , (int)( _193 ) , (int)( 13 ) ) == "No PoE client") )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 83;
            _117 [ _191 , _192] = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 83;
            _189  .UpdateValue ( "OFF"  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 83;
            _117 [ _191 , _192] = (ushort) ( 65535 ) ; 
            __context__.SourceCodeLine = 83;
            _189  .UpdateValue ( "ON"  ) ; 
            } 
        
        __context__.SourceCodeLine = 83;
        MakeString ( _190 , "PoE for port {0:d}/{1:d}:{2}", (short)_191, (short)_192, _189 ) ; 
        __context__.SourceCodeLine = 83;
        _131 (  __context__ , "Luxul", _190) ; 
        __context__.SourceCodeLine = 82;
        } 
    
    
    }
    
private void _185 (  SplusExecutionContext __context__, CrestronString _187 ) 
    { 
    
    __context__.SourceCodeLine = 83;
    if ( Functions.TestForTrue  ( ( _182( __context__ , _187 , (ushort)( 0 ) ))  ) ) 
        { 
        __context__.SourceCodeLine = 83;
        if ( Functions.TestForTrue  ( ( _119)  ) ) 
            { 
            __context__.SourceCodeLine = 83;
            _119 = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 83;
            _160 (  __context__  ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 83;
            if ( Functions.TestForTrue  ( ( _128)  ) ) 
                { 
                __context__.SourceCodeLine = 84;
                _128 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 84;
                _173 (  __context__  ) ; 
                } 
            
            }
        
        } 
    
    else 
        {
        __context__.SourceCodeLine = 84;
        if ( Functions.TestForTrue  ( ( _128)  ) ) 
            { 
            __context__.SourceCodeLine = 84;
            _118 = (ushort) ( 65535 ) ; 
            __context__.SourceCodeLine = 84;
            _126 = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 84;
            REBOOTINGINPROGRESS  .Value = (ushort) ( 65535 ) ; 
            __context__.SourceCodeLine = 84;
            ERRORMSG__DOLLAR__  .UpdateValue ( "The module has detected an unusable configuration on the switch.\r\n\r\n" + "Restoring switch to default configuration.\r\n\r\nThis may take several minutes."  ) ; 
            __context__.SourceCodeLine = 84;
            _150 (  __context__ , "reload cold", (ushort)( 0 ), "% Cold reload in progress, please stand by.", (ushort)( 19 ), "Try Again Later") ; 
            } 
        
        }
    
    
    }
    
private void _186 (  SplusExecutionContext __context__, ushort _188 , CrestronString _189 ) 
    { 
    
    __context__.SourceCodeLine = 84;
    _131 (  __context__ , "MsgActionSwitch - ", Functions.ItoA( (int)( _188 ) )) ; 
    __context__.SourceCodeLine = 84;
    
        {
        int __SPLS_TMPVAR__SWTCH_7__ = ((int)_188);
        
            { 
            if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 1) ) ) ) 
                { 
                __context__.SourceCodeLine = 84;
                _147 (  __context__ , _189) ; 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 2) ) ) ) 
                { 
                __context__.SourceCodeLine = 84;
                _146 (  __context__ , _189) ; 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 4) ) ) ) 
                { 
                __context__.SourceCodeLine = 84;
                _145 (  __context__ , _189) ; 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 10) ) ) ) 
                { 
                __context__.SourceCodeLine = 84;
                _183 (  __context__ , _189) ; 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 11) ) ) ) 
                { 
                __context__.SourceCodeLine = 85;
                _185 (  __context__ , _189) ; 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 12) ) ) ) 
                { 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 13) ) ) ) 
                { 
                __context__.SourceCodeLine = 85;
                _184 (  __context__ , _189) ; 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 14) ) ) ) 
                { 
                __context__.SourceCodeLine = 85;
                _172 (  __context__  ) ; 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 18) ) ) ) 
                { 
                __context__.SourceCodeLine = 85;
                CreateWait ( "__SPLS_TMPVAR__WAITLABEL_18__" , 2000 , __SPLS_TMPVAR__WAITLABEL_18___Callback ) ;
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 19) ) ) ) 
                { 
                __context__.SourceCodeLine = 85;
                _166 (  __context__  ) ; 
                } 
            
            } 
            
        }
        
    
    
    }
    
public void __SPLS_TMPVAR__WAITLABEL_18___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 85;
            _140 (  __context__  ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

private void _187 (  SplusExecutionContext __context__ ) 
    { 
    ushort _189 = 0;
    ushort _190 = 0;
    
    CrestronString _191;
    _191  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    
    
    __context__.SourceCodeLine = 85;
    _189 = (ushort) ( Functions.Find( "\u0027" , _86._79 , 1 ) ) ; 
    __context__.SourceCodeLine = 85;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _189 > 0 ))  ) ) 
        { 
        __context__.SourceCodeLine = 85;
        _191  .UpdateValue ( Functions.Mid ( _86 . _79 ,  (int) ( 1 ) ,  (int) ( _189 ) )  ) ; 
        __context__.SourceCodeLine = 85;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "#" , _86._79 , 1 ) > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 85;
            _86 . _80 = (ushort) ( (Functions.Length( _86._79 ) - _189) ) ; 
            __context__.SourceCodeLine = 85;
            _86 . _79  .UpdateValue ( Functions.Right ( _86 . _79 ,  (int) ( _86._80 ) )  ) ; 
            } 
        
        } 
    
    
    }
    
private void _188 (  SplusExecutionContext __context__ ) 
    { 
    CrestronString _190;
    _190  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
    
    _94 _191;
    _191  = new _94( this, true );
    _191 .PopulateCustomAttributeList( false );
    
    
    __context__.SourceCodeLine = 85;
    Functions.Pulse ( 10, __TRIGGER_START_HEARTBEAT_OUT ) ; 
    __context__.SourceCodeLine = 85;
    if ( Functions.TestForTrue  ( ( _56( __context__ , ref _103 ))  ) ) 
        { 
        __context__.SourceCodeLine = 85;
        _102 . _95  .UpdateValue ( "NULL STRING"  ) ; 
        __context__.SourceCodeLine = 85;
        if ( Functions.TestForTrue  ( ( _93._92)  ) ) 
            {
            __context__.SourceCodeLine = 85;
            _125 = (ushort) ( _170( __context__ , (ushort)( _125 ) ) ) ; 
            }
        
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 85;
        _136 (  __context__ ,   ref  _191 ) ; 
        __context__.SourceCodeLine = 85;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_191._95 == "NULL STRING"))  ) ) 
            {
            __context__.SourceCodeLine = 86;
            Functions.Pulse ( 5, __TRIGGER_SEND_NEXT_CMD_OUT ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 86;
            _144 (  __context__ , _191) ; 
            }
        
        } 
    
    
    }
    
private ushort _189 (  SplusExecutionContext __context__ ) 
    { 
    ushort _191 = 0;
    ushort _192 = 0;
    ushort _193 = 0;
    ushort _194 = 0;
    
    CrestronString _12;
    _12  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    
    ushort _195 = 0;
    
    CrestronString _196;
    CrestronString _197;
    _196  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10000, this );
    _197  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10000, this );
    
    ushort _198 = 0;
    
    ushort _199 = 0;
    
    
    __context__.SourceCodeLine = 86;
    _131 (  __context__ , "fnMessageHandler_onCommRx g_debugRXCommsCnt ", Functions.ItoA( (int)( _130 ) )) ; 
    __context__.SourceCodeLine = 86;
    _130 = (ushort) ( (_130 + 1) ) ; 
    __context__.SourceCodeLine = 86;
    _198 = (ushort) ( _107 ) ; 
    __context__.SourceCodeLine = 86;
    _187 (  __context__  ) ; 
    __context__.SourceCodeLine = 86;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "**** IDLE TIMEOUT ***\r\n\r\n\r\n" , _86._79 , 1 ) > 0 ))  ) ) 
        { 
        __context__.SourceCodeLine = 86;
        SWITCH_CLIENT .  SocketRxBuf  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 86;
        _191 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 86;
        _140 (  __context__  ) ; 
        __context__.SourceCodeLine = 86;
        _141 (  __context__  ) ; 
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 86;
        _12  .UpdateValue ( _102 . _96  ) ; 
        __context__.SourceCodeLine = 86;
        _131 (  __context__ , "fnMessageHandler_onCommRx ok pattern = ", _12) ; 
        __context__.SourceCodeLine = 87;
        _131 (  __context__ , "fnMessageHandler_onCommRx g_MessageHandlerComms.inputString ", _86._79) ; 
        __context__.SourceCodeLine = 87;
        _131 (  __context__ , "fnMessageHandler_onCommRx g_MessageHandlerComms.inputLength ", Functions.ItoA( (int)( _86._80 ) )) ; 
        __context__.SourceCodeLine = 87;
        _191 = (ushort) ( Functions.Find( _12 , _86._79 ) ) ; 
        __context__.SourceCodeLine = 87;
        _131 (  __context__ , "fnMessageHandler_onCommRx pos ", Functions.ItoA( (int)( _191 ) )) ; 
        __context__.SourceCodeLine = 87;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _191 > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 87;
            _195 = (ushort) ( _102._97 ) ; 
            __context__.SourceCodeLine = 87;
            CreateWait ( "__SPLS_TMPVAR__WAITLABEL_19__" , 10 , __SPLS_TMPVAR__WAITLABEL_19___Callback ) ;
            } 
        
        else 
            {
            __context__.SourceCodeLine = 87;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( _102._98 ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 87;
                _12  .UpdateValue ( _102 . _98  ) ; 
                __context__.SourceCodeLine = 87;
                _191 = (ushort) ( Functions.Find( _12 , _86._79 ) ) ; 
                __context__.SourceCodeLine = 87;
                _131 (  __context__ , "fnMessageHandler_onCommRx fail pos ", Functions.ItoA( (int)( _191 ) )) ; 
                __context__.SourceCodeLine = 87;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _191 > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 87;
                    _195 = (ushort) ( _102._99 ) ; 
                    __context__.SourceCodeLine = 87;
                    if ( Functions.TestForTrue  ( ( _129)  ) ) 
                        { 
                        __context__.SourceCodeLine = 87;
                        _129 = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 87;
                        CancelWait ( "WAIT_FOR_RX_SEND" ) ; 
                        } 
                    
                    } 
                
                } 
            
            }
        
        __context__.SourceCodeLine = 88;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _191 > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 88;
            _193 = (ushort) ( Functions.Find( _102._95 , _86._79 ) ) ; 
            __context__.SourceCodeLine = 88;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _193 > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 88;
                _196  .UpdateValue ( Functions.Mid ( _86 . _79 ,  (int) ( (_193 + Functions.Length( _102._95 )) ) ,  (int) ( (Functions.Length( _86._79 ) - ((_193 + Functions.Length( _102._95 )) - 1)) ) )  ) ; 
                } 
            
            __context__.SourceCodeLine = 88;
            _191 = (ushort) ( ((_191 + Functions.Length( _12 )) - 1) ) ; 
            __context__.SourceCodeLine = 88;
            _197  .UpdateValue ( Functions.Remove ( _191, _86 . _79 )  ) ; 
            __context__.SourceCodeLine = 88;
            _86 . _80 = (ushort) ( (_86._80 - _191) ) ; 
            __context__.SourceCodeLine = 88;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _195 > 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 88;
                _186 (  __context__ , (ushort)( _195 ), _196) ; 
                }
            
            __context__.SourceCodeLine = 88;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_198 == _107))  ) ) 
                {
                __context__.SourceCodeLine = 88;
                Functions.Pulse ( 1, __TRIGGER_SEND_NEXT_CMD_OUT ) ; 
                }
            
            } 
        
        } 
    
    __context__.SourceCodeLine = 88;
    return (ushort)( _191) ; 
    
    }
    
public void __SPLS_TMPVAR__WAITLABEL_19___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 87;
            if ( Functions.TestForTrue  ( ( _129)  ) ) 
                { 
                __context__.SourceCodeLine = 87;
                _129 = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 87;
                CancelWait ( "WAIT_FOR_RX_SEND" ) ; 
                } 
            
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

private ushort _190 (  SplusExecutionContext __context__ ) 
    { 
    ushort _192 = 0;
    
    
    __context__.SourceCodeLine = 88;
    _192 = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 88;
    while ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.GetC( _109 ) != 65535))  ) ) 
        {
        __context__.SourceCodeLine = 88;
        _192 = (ushort) ( 65535 ) ; 
        __context__.SourceCodeLine = 88;
        }
    
    __context__.SourceCodeLine = 88;
    return (ushort)( _192) ; 
    
    }
    
private void _191 (  SplusExecutionContext __context__, CrestronString _95 ) 
    { 
    ushort _193 = 0;
    ushort _194 = 0;
    ushort _195 = 0;
    
    CrestronString _196;
    CrestronString _197;
    CrestronString _198;
    CrestronString _199;
    CrestronString _200;
    CrestronString ACTION;
    CrestronString _83;
    CrestronString STACKSWITCHNUMBER;
    _196  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
    _197  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
    _198  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
    _199  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    _200  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    ACTION  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
    _83  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
    STACKSWITCHNUMBER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
    
    
    __context__.SourceCodeLine = 89;
    _131 (  __context__ , "ExtractPOECommand cmd", _95) ; 
    __context__.SourceCodeLine = 89;
    _196  .UpdateValue ( Functions.Remove ( " " , _95 , 1)  ) ; 
    __context__.SourceCodeLine = 89;
    _196  .UpdateValue ( Functions.Left ( _196 ,  (int) ( (Functions.Length( _196 ) - 1) ) )  ) ; 
    __context__.SourceCodeLine = 89;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_196 == "POE"))  ) ) 
        { 
        __context__.SourceCodeLine = 89;
        _193 = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 89;
        while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( ";" , _95 , 1 ) > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 89;
            _199  .UpdateValue ( Functions.Remove ( ";" , _95 , 1)  ) ; 
            __context__.SourceCodeLine = 89;
            _199  .UpdateValue ( Functions.Left ( _199 ,  (int) ( (Functions.Length( _199 ) - 1) ) )  ) ; 
            __context__.SourceCodeLine = 89;
            _200  .UpdateValue ( Functions.Remove ( "=" , _199 , 1)  ) ; 
            __context__.SourceCodeLine = 89;
            _200  .UpdateValue ( Functions.Left ( _200 ,  (int) ( (Functions.Length( _200 ) - 1) ) )  ) ; 
            __context__.SourceCodeLine = 89;
            ACTION  .UpdateValue ( _199  ) ; 
            __context__.SourceCodeLine = 89;
            STACKSWITCHNUMBER  .UpdateValue ( Functions.Remove ( "," , _200 , 1)  ) ; 
            __context__.SourceCodeLine = 89;
            STACKSWITCHNUMBER  .UpdateValue ( Functions.Left ( STACKSWITCHNUMBER ,  (int) ( (Functions.Length( STACKSWITCHNUMBER ) - 1) ) )  ) ; 
            __context__.SourceCodeLine = 89;
            _83  .UpdateValue ( _200  ) ; 
            __context__.SourceCodeLine = 89;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (STACKSWITCHNUMBER != "") ) && Functions.TestForTrue ( Functions.BoolToInt (_83 != "") )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 89;
                
                    {
                    int __SPLS_TMPVAR__SWTCH_8__ = ((int)Functions.Atoi( STACKSWITCHNUMBER ));
                    
                        { 
                        if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 1) ) ) ) 
                            {
                            __context__.SourceCodeLine = 89;
                            _195 = (ushort) ( (500 + Functions.Atoi( _83 )) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 2) ) ) ) 
                            {
                            __context__.SourceCodeLine = 90;
                            _195 = (ushort) ( (610 + Functions.Atoi( _83 )) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 3) ) ) ) 
                            {
                            __context__.SourceCodeLine = 90;
                            _195 = (ushort) ( (720 + Functions.Atoi( _83 )) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 4) ) ) ) 
                            {
                            __context__.SourceCodeLine = 90;
                            _195 = (ushort) ( (830 + Functions.Atoi( _83 )) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 5) ) ) ) 
                            {
                            __context__.SourceCodeLine = 90;
                            _195 = (ushort) ( (940 + Functions.Atoi( _83 )) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 6) ) ) ) 
                            {
                            __context__.SourceCodeLine = 90;
                            _195 = (ushort) ( (1050 + Functions.Atoi( _83 )) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 7) ) ) ) 
                            {
                            __context__.SourceCodeLine = 90;
                            _195 = (ushort) ( (1160 + Functions.Atoi( _83 )) ) ; 
                            }
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 8) ) ) ) 
                            {
                            __context__.SourceCodeLine = 90;
                            _195 = (ushort) ( (1270 + Functions.Atoi( _83 )) ) ; 
                            }
                        
                        } 
                        
                    }
                    
                
                __context__.SourceCodeLine = 90;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ACTION == "ON"))  ) ) 
                    { 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 90;
                    _195 = (ushort) ( (_195 + 52) ) ; 
                    } 
                
                __context__.SourceCodeLine = 90;
                _131 (  __context__ , "ExtractPOECommand StackSwitchNumber", STACKSWITCHNUMBER) ; 
                __context__.SourceCodeLine = 90;
                _131 (  __context__ , "ExtractPOECommand index", Functions.ItoA( (int)( _195 ) )) ; 
                __context__.SourceCodeLine = 90;
                _131 (  __context__ , "ExtractPOECommand Action", ACTION) ; 
                __context__.SourceCodeLine = 90;
                _122 [ _195 ]  .UpdateValue ( "1"  ) ; 
                __context__.SourceCodeLine = 90;
                _171 (  __context__  ) ; 
                } 
            
            __context__.SourceCodeLine = 89;
            } 
        
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 90;
        _131 (  __context__ , "ExtractPOECommand", "UNKNOWN COMMAND") ; 
        } 
    
    
    }
    
private void _192 (  SplusExecutionContext __context__, CrestronString _95 ) 
    { 
    ushort _194 = 0;
    ushort _195 = 0;
    ushort _196 = 0;
    ushort _197 = 0;
    ushort _198 = 0;
    
    CrestronString _199;
    CrestronString _200;
    CrestronString _201;
    CrestronString _202;
    CrestronString _203;
    _199  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    _200  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    _201  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
    _202  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
    _203  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    
    
    __context__.SourceCodeLine = 91;
    _194 = (ushort) ( 1 ) ; 
    __context__.SourceCodeLine = 91;
    while ( Functions.TestForTrue  ( ( Functions.BoolToInt (_194 != 0))  ) ) 
        { 
        __context__.SourceCodeLine = 91;
        _194 = (ushort) ( Functions.Find( ";" , _95 , 1 ) ) ; 
        __context__.SourceCodeLine = 91;
        _199  .UpdateValue ( Functions.Remove ( ";" , _95 , 1)  ) ; 
        __context__.SourceCodeLine = 91;
        _199  .UpdateValue ( Functions.Left ( _199 ,  (int) ( (Functions.Length( _199 ) - 1) ) )  ) ; 
        __context__.SourceCodeLine = 91;
        _200  .UpdateValue ( Functions.Remove ( "SW " , _199 , 1)  ) ; 
        __context__.SourceCodeLine = 91;
        _200  .UpdateValue ( Functions.Remove ( "=" , _199 , 1)  ) ; 
        __context__.SourceCodeLine = 91;
        _200  .UpdateValue ( Functions.Left ( _200 ,  (int) ( (Functions.Length( _200 ) - 1) ) )  ) ; 
        __context__.SourceCodeLine = 91;
        _201  .UpdateValue ( _199  ) ; 
        __context__.SourceCodeLine = 91;
        _198 = (ushort) ( Functions.Atoi( _201 ) ) ; 
        __context__.SourceCodeLine = 91;
        _195 = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 91;
        do 
            { 
            __context__.SourceCodeLine = 91;
            _196 = (ushort) ( Functions.Find( "," , _200 , 1 ) ) ; 
            __context__.SourceCodeLine = 91;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _196 > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 91;
                _203  .UpdateValue ( Functions.Remove ( "," , _200 , 1)  ) ; 
                __context__.SourceCodeLine = 91;
                _203  .UpdateValue ( Functions.Left ( _203 ,  (int) ( (Functions.Length( _203 ) - 1) ) )  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 91;
                _203  .UpdateValue ( _200  ) ; 
                } 
            
            __context__.SourceCodeLine = 91;
            _197 = (ushort) ( Functions.Atoi( _203 ) ) ; 
            __context__.SourceCodeLine = 91;
            _131 (  __context__ , "ExtractInputAndOutputForSwitch iOutputPort;", Functions.ItoA( (int)( _197 ) )) ; 
            __context__.SourceCodeLine = 91;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _197 <= _106 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _197 > 0 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _198 <= _105 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _198 > 0 ) )) ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 91;
                _123 [ _197 ]  .UpdateValue ( "0"  ) ; 
                __context__.SourceCodeLine = 92;
                _122 [ _197 ]  .UpdateValue ( _201  ) ; 
                } 
            
            } 
        while (false == ( Functions.TestForTrue  ( Functions.BoolToInt ( _196 < 1 )) )); 
        __context__.SourceCodeLine = 92;
        _171 (  __context__  ) ; 
        __context__.SourceCodeLine = 91;
        } 
    
    
    }
    
private void _193 (  SplusExecutionContext __context__, ushort _195 , ushort _196 ) 
    { 
    
    __context__.SourceCodeLine = 92;
    _131 (  __context__ , "fnLuxulSwitch_handleSetInput input", Functions.ItoA( (int)( _195 ) )) ; 
    __context__.SourceCodeLine = 92;
    _131 (  __context__ , "fnLuxulSwitch_handleSetInput ioutput", Functions.ItoA( (int)( _196 ) )) ; 
    __context__.SourceCodeLine = 92;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _196 <= _106 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _196 > 0 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _195 <= _105 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _195 > 0 ) )) ) )) ))  ) ) 
        { 
        __context__.SourceCodeLine = 92;
        _123 [ _196 ]  .UpdateValue ( "0"  ) ; 
        __context__.SourceCodeLine = 92;
        _122 [ _196 ]  .UpdateValue ( Functions.ItoA (  (int) ( _195 ) )  ) ; 
        __context__.SourceCodeLine = 92;
        _171 (  __context__  ) ; 
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 92;
        _131 (  __context__ , "fnLuxulSwitch_handleSetInput ", "Cant Process this in demo mode") ; 
        } 
    
    
    }
    
private void _194 (  SplusExecutionContext __context__, CrestronString _196 ) 
    { 
    ushort _197 = 0;
    
    
    __context__.SourceCodeLine = 92;
    _197 = (ushort) ( 1 ) ; 
    __context__.SourceCodeLine = 92;
    while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _197 < Functions.Length( _196 ) ))  ) ) 
        { 
        __context__.SourceCodeLine = 92;
        Print( "{0}", Functions.Mid ( _196 ,  (int) ( _197 ) ,  (int) ( 100 ) ) ) ; 
        __context__.SourceCodeLine = 92;
        _197 = (ushort) ( (_197 + 100) ) ; 
        __context__.SourceCodeLine = 92;
        } 
    
    
    }
    
object START_MODULE_OnPush_0 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 92;
        _169 (  __context__  ) ; 
        __context__.SourceCodeLine = 93;
        _168 (  __context__  ) ; 
        
        
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
        
        __context__.SourceCodeLine = 93;
        if ( Functions.TestForTrue  ( ( _93._92)  ) ) 
            { 
            __context__.SourceCodeLine = 93;
            _122 [ 1382 ]  .UpdateValue ( "1"  ) ; 
            __context__.SourceCodeLine = 93;
            _171 (  __context__  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 93;
            _131 (  __context__ , "refresh_status", "g_LuxulSwitch.readyForCommands = false") ; 
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
        
        __context__.SourceCodeLine = 93;
        if ( Functions.TestForTrue  ( ( _93._92)  ) ) 
            { 
            __context__.SourceCodeLine = 93;
            _122 [ 1381 ]  .UpdateValue ( "1"  ) ; 
            __context__.SourceCodeLine = 93;
            _171 (  __context__  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 93;
            _131 (  __context__ , "send_save", "g_LuxulSwitch.readyForCommands = false") ; 
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
        
        __context__.SourceCodeLine = 93;
        _191 (  __context__ , POE_CMD) ; 
        
        
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
        
        __context__.SourceCodeLine = 93;
        _192 (  __context__ , FAVOUTITE_CMD) ; 
        
        
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
        
        __context__.SourceCodeLine = 93;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DEBUGENABLE == "enable debug"))  ) ) 
            {
            __context__.SourceCodeLine = 93;
            _108 = (ushort) ( 65535 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 93;
            _108 = (ushort) ( 0 ) ; 
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
        
        __context__.SourceCodeLine = 93;
        _114  .UpdateValue ( _114 + CRESTRON_MAC  ) ; 
        
        
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
        
        
        __context__.SourceCodeLine = 94;
        OUTPUTPORT = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 94;
        INPUTPORT = (ushort) ( OUTPUT[ OUTPUTPORT ] .UshortValue ) ; 
        __context__.SourceCodeLine = 94;
        _131 (  __context__ , "Output Switching", "") ; 
        __context__.SourceCodeLine = 94;
        _193 (  __context__ , (ushort)( INPUTPORT ), (ushort)( OUTPUTPORT )) ; 
        
        
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
        
        __context__.SourceCodeLine = 94;
        _102 . _96  .UpdateValue ( "Username:"  ) ; 
        __context__.SourceCodeLine = 94;
        _102 . _97 = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 94;
        _102 . _98  .UpdateValue ( "#"  ) ; 
        __context__.SourceCodeLine = 94;
        _102 . _99 = (ushort) ( 14 ) ; 
        __context__.SourceCodeLine = 94;
        _111  .UpdateValue ( "Client Connect Event. Connected to: " + P_SWITCHIP + ":" + P_SWITCHPORT  ) ; 
        __context__.SourceCodeLine = 94;
        _131 (  __context__ , "socket", _111) ; 
        __context__.SourceCodeLine = 94;
        _149 (  __context__ , (ushort)( 1 )) ; 
        __context__.SourceCodeLine = 94;
        _64 (  __context__ ,   ref  _103 ) ; 
        
        
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
        
        __context__.SourceCodeLine = 94;
        _131 (  __context__ , "socket", "Client Disconnect Event") ; 
        __context__.SourceCodeLine = 94;
        _149 (  __context__ , (ushort)( 0 )) ; 
        __context__.SourceCodeLine = 94;
        _120 = (ushort) ( 0 ) ; 
        
        
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
        
        
        __context__.SourceCodeLine = 94;
        STATUS = (short) ( __SocketInfo__.SocketStatus ) ; 
        __context__.SourceCodeLine = 95;
        _131 (  __context__ , "The SocketGetStatus returns:", Functions.ItoA( (int)( STATUS ) )) ; 
        __context__.SourceCodeLine = 95;
        _131 (  __context__ , "The MyClient.SocketStatus returns:", Functions.ItoA( (int)( SWITCH_CLIENT.SocketStatus ) )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SocketInfo__ ); }
    return this;
    
}

private void _195 (  SplusExecutionContext __context__ ) 
    { 
    ushort _197 = 0;
    
    
    __context__.SourceCodeLine = 95;
    if ( Functions.TestForTrue  ( ( _104)  ) ) 
        { 
        __context__.SourceCodeLine = 95;
        Functions.Pulse ( 10, __SOCKET_RECEIVE_BUSY ) ; 
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 95;
        _104 = (ushort) ( 65535 ) ; 
        __context__.SourceCodeLine = 95;
        _197 = (ushort) ( Functions.Length( SWITCH_CLIENT.SocketRxBuf ) ) ; 
        __context__.SourceCodeLine = 95;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _197 > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 95;
            _86 . _79  .UpdateValue ( _86 . _79 + Functions.Remove ( _197, SWITCH_CLIENT .  SocketRxBuf )  ) ; 
            __context__.SourceCodeLine = 95;
            _86 . _80 = (ushort) ( (_86._80 + _197) ) ; 
            __context__.SourceCodeLine = 95;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _189( __context__ ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 95;
                } 
            
            } 
        
        __context__.SourceCodeLine = 95;
        _104 = (ushort) ( 0 ) ; 
        } 
    
    
    }
    
object __TRIGGER_PROCESS_SOCKET_RECEIVE_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 95;
        _195 (  __context__  ) ; 
        
        
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
        
        __context__.SourceCodeLine = 95;
        _188 (  __context__  ) ; 
        
        
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
        
        __context__.SourceCodeLine = 95;
        if ( Functions.TestForTrue  ( ( Functions.Not( _93._92 ))  ) ) 
            {
            __context__.SourceCodeLine = 95;
            _155 (  __context__  ) ; 
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
        
        __context__.SourceCodeLine = 96;
        _195 (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SocketInfo__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    ushort _197 = 0;
    
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 96;
        _104 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 96;
        _114  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 96;
        _113 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 96;
        _65 (  __context__ ,   ref  _103 , (ushort)( 1000 )) ; 
        __context__.SourceCodeLine = 96;
        VERSION__DOLLAR__  .UpdateValue ( "V1_04"  ) ; 
        __context__.SourceCodeLine = 96;
        ERRORMSG__DOLLAR__  .UpdateValue ( "NONE"  ) ; 
        __context__.SourceCodeLine = 96;
        _107 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 96;
        _119 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 96;
        _108 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 96;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)1500; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( _197  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_197  >= __FN_FORSTART_VAL__1) && (_197  <= __FN_FOREND_VAL__1) ) : ( (_197  <= __FN_FORSTART_VAL__1) && (_197  >= __FN_FOREND_VAL__1) ) ; _197  += (ushort)__FN_FORSTEP_VAL__1) 
            {
            __context__.SourceCodeLine = 96;
            _122 [ _197 ]  .UpdateValue ( "0"  ) ; 
            __context__.SourceCodeLine = 96;
            }
        
        __context__.SourceCodeLine = 96;
        ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__2 = (ushort)1500; 
        int __FN_FORSTEP_VAL__2 = (int)1; 
        for ( _197  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (_197  >= __FN_FORSTART_VAL__2) && (_197  <= __FN_FOREND_VAL__2) ) : ( (_197  <= __FN_FORSTART_VAL__2) && (_197  >= __FN_FOREND_VAL__2) ) ; _197  += (ushort)__FN_FORSTEP_VAL__2) 
            {
            __context__.SourceCodeLine = 96;
            _123 [ _197 ]  .UpdateValue ( "0"  ) ; 
            __context__.SourceCodeLine = 96;
            }
        
        __context__.SourceCodeLine = 96;
        _127 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 96;
        _120 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 96;
        _124 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 96;
        _125 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 96;
        _126 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 96;
        _130 = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    _110  = new ushort[ 81 ];
    _117  = new ushort[ 9,53 ];
    _109  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
    _111  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
    _114  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
    _115  = new CrestronString[ 405 ];
    for( uint i = 0; i < 405; i++ )
        _115 [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    _116  = new CrestronString[ 405 ];
    for( uint i = 0; i < 405; i++ )
        _116 [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    _122  = new CrestronString[ 1501 ];
    for( uint i = 0; i < 1501; i++ )
        _122 [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
    _123  = new CrestronString[ 1501 ];
    for( uint i = 0; i < 1501; i++ )
        _123 [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
    SWITCH_CLIENT  = new SplusTcpClient ( 64000, this );
    _86  = new _78( this, true );
    _86 .PopulateCustomAttributeList( false );
    _93  = new _87( this, true );
    _93 .PopulateCustomAttributeList( false );
    _102  = new _94( this, true );
    _102 .PopulateCustomAttributeList( false );
    _103  = new _48( this, true );
    _103 .PopulateCustomAttributeList( false );
    _101  = new _94[ 1001 ];
    for( uint i = 0; i < 1001; i++ )
    {
        _101 [i] = new _94( this, true );
        _101 [i].PopulateCustomAttributeList( false );
        
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
    
    P_SWITCHPORT = new StringParameter( P_SWITCHPORT__Parameter__, this );
    m_ParameterList.Add( P_SWITCHPORT__Parameter__, P_SWITCHPORT );
    
    P_SWITCHUSERNAME = new StringParameter( P_SWITCHUSERNAME__Parameter__, this );
    m_ParameterList.Add( P_SWITCHUSERNAME__Parameter__, P_SWITCHUSERNAME );
    
    P_SWITCHPASSWORD = new StringParameter( P_SWITCHPASSWORD__Parameter__, this );
    m_ParameterList.Add( P_SWITCHPASSWORD__Parameter__, P_SWITCHPASSWORD );
    
    P_SWITCHLICENCEKEY = new StringParameter( P_SWITCHLICENCEKEY__Parameter__, this );
    m_ParameterList.Add( P_SWITCHLICENCEKEY__Parameter__, P_SWITCHLICENCEKEY );
    
    WAIT_FOR_RX_SEND_Callback = new WaitFunction( WAIT_FOR_RX_SEND_CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_15___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_15___CallbackFn );
    LICENCE_TEXT_Callback = new WaitFunction( LICENCE_TEXT_CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_16___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_16___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_17___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_17___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_18___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_18___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_19___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_19___CallbackFn );
    
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

public UserModuleClass_JAP_AVSWITCH_LUXUL_V1_04 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction WAIT_FOR_RX_SEND_Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_15___Callback;
private WaitFunction LICENCE_TEXT_Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_16___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_17___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_18___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_19___Callback;


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
const uint P_SWITCHPORT__Parameter__ = 11;
const uint P_SWITCHUSERNAME__Parameter__ = 12;
const uint P_SWITCHPASSWORD__Parameter__ = 13;
const uint P_SWITCHLICENCEKEY__Parameter__ = 14;

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
public class _7 : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public CrestronString  _8;
    
    [SplusStructAttribute(1, false, false)]
    public ushort  _9 = 0;
    
    [SplusStructAttribute(2, false, false)]
    public ushort  [] _10;
    
    [SplusStructAttribute(3, false, false)]
    public ushort  [] _11;
    
    [SplusStructAttribute(4, false, false)]
    public CrestronString  _12;
    
    [SplusStructAttribute(5, false, false)]
    public ushort  _13 = 0;
    
    [SplusStructAttribute(6, false, false)]
    public ushort  _14 = 0;
    
    [SplusStructAttribute(7, false, false)]
    public ushort  _15 = 0;
    
    [SplusStructAttribute(8, false, false)]
    public ushort  _16 = 0;
    
    [SplusStructAttribute(9, false, false)]
    public ushort  [] _17;
    
    [SplusStructAttribute(10, false, false)]
    public short  [] _18;
    
    
    public _7( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        _10  = new ushort[ 11 ];
        _11  = new ushort[ 11 ];
        _17  = new ushort[ 11 ];
        _18  = new short[ 11 ];
        _8  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 80, Owner );
        _12  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, Owner );
        
        
    }
    
}
[SplusStructAttribute(-1, true, false)]
public class _48 : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public ushort  _49 = 0;
    
    [SplusStructAttribute(1, false, false)]
    public ushort  _50 = 0;
    
    [SplusStructAttribute(2, false, false)]
    public ushort  _51 = 0;
    
    [SplusStructAttribute(3, false, false)]
    public ushort  _52 = 0;
    
    [SplusStructAttribute(4, false, false)]
    public ushort  _53 = 0;
    
    [SplusStructAttribute(5, false, false)]
    public ushort  _54 = 0;
    
    
    public _48( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        
        
    }
    
}
[SplusStructAttribute(-1, true, false)]
public class _78 : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public CrestronString  _79;
    
    [SplusStructAttribute(1, false, false)]
    public ushort  _80 = 0;
    
    [SplusStructAttribute(2, false, false)]
    public ushort  _81 = 0;
    
    [SplusStructAttribute(3, false, false)]
    public CrestronString  _82;
    
    [SplusStructAttribute(4, false, false)]
    public CrestronString  _83;
    
    [SplusStructAttribute(5, false, false)]
    public ushort  _84 = 0;
    
    [SplusStructAttribute(6, false, false)]
    public CrestronString  _85;
    
    
    public _78( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        _79  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64000, Owner );
        _82  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 15, Owner );
        _83  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, Owner );
        _85  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, Owner );
        
        
    }
    
}
[SplusStructAttribute(-1, true, false)]
public class _87 : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public ushort  _88 = 0;
    
    [SplusStructAttribute(1, false, false)]
    public uint  _89 = 0;
    
    [SplusStructAttribute(2, false, false)]
    public ushort  _90 = 0;
    
    [SplusStructAttribute(3, false, false)]
    public ushort  _91 = 0;
    
    [SplusStructAttribute(4, false, false)]
    public ushort  _92 = 0;
    
    
    public _87( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        
        
    }
    
}
[SplusStructAttribute(-1, true, false)]
public class _94 : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public CrestronString  _95;
    
    [SplusStructAttribute(1, false, false)]
    public CrestronString  _96;
    
    [SplusStructAttribute(2, false, false)]
    public ushort  _97 = 0;
    
    [SplusStructAttribute(3, false, false)]
    public CrestronString  _98;
    
    [SplusStructAttribute(4, false, false)]
    public ushort  _99 = 0;
    
    [SplusStructAttribute(5, false, false)]
    public CrestronString  _100;
    
    
    public _94( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        _95  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5000, Owner );
        _96  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, Owner );
        _98  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, Owner );
        _100  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, Owner );
        
        
    }
    
}

}
