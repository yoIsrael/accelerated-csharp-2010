using System;
using System.Text;

public class EntryPoint
{
    static void Main() {
        string leUnicodeStr = "здорово!";

        Encoding leUnicode = Encoding.Unicode;
        Encoding beUnicode = Encoding.BigEndianUnicode;
        Encoding utf8 = Encoding.UTF8;

        byte[] leUnicodeBytes = leUnicode.GetBytes(leUnicodeStr);
        byte[] beUnicodeBytes = Encoding.Convert( leUnicode,
                                                  beUnicode,
                                                  leUnicodeBytes);
        byte[] utf8Bytes = Encoding.Convert( leUnicode,
                                             utf8,
                                             leUnicodeBytes );

        Console.WriteLine( "Orig. String: {0}\n", leUnicodeStr );
        Console.WriteLine( "Little Endian Unicode Bytes:" );
        StringBuilder sb = new StringBuilder();
        foreach( byte b in leUnicodeBytes ) {
            sb.Append( b ).Append(" : ");
        }
        Console.WriteLine( "{0}\n", sb.ToString() );

        Console.WriteLine( "Big Endian Unicode Bytes:" );
        sb = new StringBuilder();
        foreach( byte b in beUnicodeBytes ) {
            sb.Append( b ).Append(" : ");
        }
        Console.WriteLine( "{0}\n", sb.ToString() );

        Console.WriteLine( "UTF Bytes:" );
        sb = new StringBuilder();
        foreach( byte b in utf8Bytes ) {
            sb.Append( b ).Append(" : ");
        }
        Console.WriteLine( sb.ToString() );
    }
}
