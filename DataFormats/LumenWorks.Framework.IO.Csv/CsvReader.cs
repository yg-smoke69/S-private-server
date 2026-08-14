using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace LumenWorks.Framework.IO.Csv;

[Token(Token = "0x2003B8D")]
public class CsvReader : _Attribute, IConvertible, IComparable<int>, IFormattable
{
	[Token(Token = "0x2003B8E")]
	private enum DataReaderValidations
	{
		[Token(Token = "0x4019637")]
		None,
		[Token(Token = "0x4019638")]
		IsInitialized,
		[Token(Token = "0x4019639")]
		IsNotClosed
	}

	[Token(Token = "0x2003B8F")]
	public struct RecordEnumerator : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x401963A")]
		[FieldOffset(Offset = "0x0")]
		private CsvReader _reader;

		[Token(Token = "0x401963B")]
		[FieldOffset(Offset = "0x4")]
		private string[] _current;

		[Token(Token = "0x401963C")]
		[FieldOffset(Offset = "0x8")]
		private long _currentRecordIndex;

		[Token(Token = "0x1700188E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6017C75")]
			[Address(RVA = "0x93C368", Offset = "0x93C368", VA = "0x93C368", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700188F")]
		public string[] Current
		{
			[Token(Token = "0x6017C72")]
			[Address(RVA = "0x93C350", Offset = "0x93C350", VA = "0x93C350", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6017C71")]
		[Address(RVA = "0x93C348", Offset = "0x93C348", VA = "0x93C348")]
		public RecordEnumerator(CsvReader reader)
		{
		}

		[Token(Token = "0x6017C73")]
		[Address(RVA = "0x93C358", Offset = "0x93C358", VA = "0x93C358", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6017C74")]
		[Address(RVA = "0x93C360", Offset = "0x93C360", VA = "0x93C360", Slot = "7")]
		public void Reset()
		{
		}

		[Token(Token = "0x6017C76")]
		[Address(RVA = "0x93C370", Offset = "0x93C370", VA = "0x93C370", Slot = "8")]
		public void Dispose()
		{
		}
	}

	[Token(Token = "0x4019610")]
	[FieldOffset(Offset = "0x0")]
	public static readonly int DefaultBufferSize;

	[Token(Token = "0x4019611")]
	public const char DefaultDelimiter = ',';

	[Token(Token = "0x4019612")]
	public const char DefaultQuote = '"';

	[Token(Token = "0x4019613")]
	public const char DefaultEscape = '"';

	[Token(Token = "0x4019614")]
	public const char DefaultComment = '#';

	[Token(Token = "0x4019615")]
	[FieldOffset(Offset = "0x4")]
	private static readonly StringComparer _fieldHeaderComparer;

	[Token(Token = "0x4019616")]
	[FieldOffset(Offset = "0x8")]
	private TextReader _reader;

	[Token(Token = "0x4019617")]
	[FieldOffset(Offset = "0xC")]
	private int _bufferSize;

	[Token(Token = "0x4019618")]
	[FieldOffset(Offset = "0x10")]
	private char _comment;

	[Token(Token = "0x4019619")]
	[FieldOffset(Offset = "0x12")]
	private char _escape;

	[Token(Token = "0x401961A")]
	[FieldOffset(Offset = "0x14")]
	private char _delimiter;

	[Token(Token = "0x401961B")]
	[FieldOffset(Offset = "0x16")]
	private char _quote;

	[Token(Token = "0x401961C")]
	[FieldOffset(Offset = "0x18")]
	private ValueTrimmingOptions _trimmingOptions;

	[Token(Token = "0x401961D")]
	[FieldOffset(Offset = "0x1C")]
	private bool _hasHeaders;

	[Token(Token = "0x401961E")]
	[FieldOffset(Offset = "0x20")]
	private ParseErrorAction _defaultParseErrorAction;

	[Token(Token = "0x401961F")]
	[FieldOffset(Offset = "0x24")]
	private MissingFieldAction _missingFieldAction;

	[Token(Token = "0x4019620")]
	[FieldOffset(Offset = "0x28")]
	private bool _supportsMultiline;

	[Token(Token = "0x4019621")]
	[FieldOffset(Offset = "0x29")]
	private bool _skipEmptyLines;

	[Token(Token = "0x4019622")]
	[FieldOffset(Offset = "0x2A")]
	private bool _initialized;

	[Token(Token = "0x4019623")]
	[FieldOffset(Offset = "0x2C")]
	private string[] _fieldHeaders;

	[Token(Token = "0x4019624")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<string, int> _fieldHeaderIndexes;

	[Token(Token = "0x4019625")]
	[FieldOffset(Offset = "0x38")]
	private long _currentRecordIndex;

	[Token(Token = "0x4019626")]
	[FieldOffset(Offset = "0x40")]
	private int _nextFieldStart;

	[Token(Token = "0x4019627")]
	[FieldOffset(Offset = "0x44")]
	private int _nextFieldIndex;

	[Token(Token = "0x4019628")]
	[FieldOffset(Offset = "0x48")]
	private string[] _fields;

	[Token(Token = "0x4019629")]
	[FieldOffset(Offset = "0x4C")]
	private int _fieldCount;

	[Token(Token = "0x401962A")]
	[FieldOffset(Offset = "0x50")]
	private char[] _buffer;

	[Token(Token = "0x401962B")]
	[FieldOffset(Offset = "0x54")]
	private int _bufferLength;

	[Token(Token = "0x401962C")]
	[FieldOffset(Offset = "0x58")]
	private bool _eof;

	[Token(Token = "0x401962D")]
	[FieldOffset(Offset = "0x59")]
	private bool _eol;

	[Token(Token = "0x401962E")]
	[FieldOffset(Offset = "0x5A")]
	private bool _firstRecordInCache;

	[Token(Token = "0x401962F")]
	[FieldOffset(Offset = "0x5B")]
	private bool _missingFieldFlag;

	[Token(Token = "0x4019630")]
	[FieldOffset(Offset = "0x5C")]
	private bool _parseErrorFlag;

	[Token(Token = "0x4019632")]
	[FieldOffset(Offset = "0x64")]
	private string _003CDefaultHeaderName_003Ek__BackingField;

	[Token(Token = "0x4019633")]
	[FieldOffset(Offset = "0x68")]
	private bool _isDisposed;

	[Token(Token = "0x4019634")]
	[FieldOffset(Offset = "0x6C")]
	private readonly object _lock;

	[Token(Token = "0x17001878")]
	public char Comment
	{
		[Token(Token = "0x6017C37")]
		[Address(RVA = "0x1C64A9C", Offset = "0x1C64A9C", VA = "0x1C64A9C")]
		get
		{
			return default(char);
		}
	}

	[Token(Token = "0x17001879")]
	public char Escape
	{
		[Token(Token = "0x6017C38")]
		[Address(RVA = "0x1C64AA4", Offset = "0x1C64AA4", VA = "0x1C64AA4")]
		get
		{
			return default(char);
		}
	}

	[Token(Token = "0x1700187A")]
	public char Delimiter
	{
		[Token(Token = "0x6017C39")]
		[Address(RVA = "0x1C64AAC", Offset = "0x1C64AAC", VA = "0x1C64AAC")]
		get
		{
			return default(char);
		}
	}

	[Token(Token = "0x1700187B")]
	public char Quote
	{
		[Token(Token = "0x6017C3A")]
		[Address(RVA = "0x1C64AB4", Offset = "0x1C64AB4", VA = "0x1C64AB4")]
		get
		{
			return default(char);
		}
	}

	[Token(Token = "0x1700187C")]
	public bool HasHeaders
	{
		[Token(Token = "0x6017C3B")]
		[Address(RVA = "0x1C64ABC", Offset = "0x1C64ABC", VA = "0x1C64ABC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700187D")]
	public ValueTrimmingOptions TrimmingOption
	{
		[Token(Token = "0x6017C3C")]
		[Address(RVA = "0x1C64AC4", Offset = "0x1C64AC4", VA = "0x1C64AC4")]
		get
		{
			return default(ValueTrimmingOptions);
		}
	}

	[Token(Token = "0x1700187E")]
	public int BufferSize
	{
		[Token(Token = "0x6017C3D")]
		[Address(RVA = "0x1C64ACC", Offset = "0x1C64ACC", VA = "0x1C64ACC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700187F")]
	public ParseErrorAction DefaultParseErrorAction
	{
		[Token(Token = "0x6017C3E")]
		[Address(RVA = "0x1C64AD4", Offset = "0x1C64AD4", VA = "0x1C64AD4")]
		get
		{
			return default(ParseErrorAction);
		}
		[Token(Token = "0x6017C3F")]
		[Address(RVA = "0x1C64ADC", Offset = "0x1C64ADC", VA = "0x1C64ADC")]
		set
		{
		}
	}

	[Token(Token = "0x17001880")]
	public MissingFieldAction MissingFieldAction
	{
		[Token(Token = "0x6017C40")]
		[Address(RVA = "0x1C64AE4", Offset = "0x1C64AE4", VA = "0x1C64AE4")]
		get
		{
			return default(MissingFieldAction);
		}
		[Token(Token = "0x6017C41")]
		[Address(RVA = "0x1C64AEC", Offset = "0x1C64AEC", VA = "0x1C64AEC")]
		set
		{
		}
	}

	[Token(Token = "0x17001881")]
	public bool SupportsMultiline
	{
		[Token(Token = "0x6017C42")]
		[Address(RVA = "0x1C64AF4", Offset = "0x1C64AF4", VA = "0x1C64AF4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6017C43")]
		[Address(RVA = "0x1C64AFC", Offset = "0x1C64AFC", VA = "0x1C64AFC")]
		set
		{
		}
	}

	[Token(Token = "0x17001882")]
	public bool SkipEmptyLines
	{
		[Token(Token = "0x6017C44")]
		[Address(RVA = "0x1C64B04", Offset = "0x1C64B04", VA = "0x1C64B04")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6017C45")]
		[Address(RVA = "0x1C64B0C", Offset = "0x1C64B0C", VA = "0x1C64B0C")]
		set
		{
		}
	}

	[Token(Token = "0x17001883")]
	public string DefaultHeaderName
	{
		[Token(Token = "0x6017C46")]
		[Address(RVA = "0x1C64B14", Offset = "0x1C64B14", VA = "0x1C64B14")]
		get
		{
			return null;
		}
		[Token(Token = "0x6017C47")]
		[Address(RVA = "0x1C64804", Offset = "0x1C64804", VA = "0x1C64804")]
		set
		{
		}
	}

	[Token(Token = "0x17001884")]
	public int FieldCount
	{
		[Token(Token = "0x6017C48")]
		[Address(RVA = "0x1C64B1C", Offset = "0x1C64B1C", VA = "0x1C64B1C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001885")]
	public virtual bool EndOfStream
	{
		[Token(Token = "0x6017C49")]
		[Address(RVA = "0x1C64B8C", Offset = "0x1C64B8C", VA = "0x1C64B8C", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001886")]
	public virtual long CurrentRecordIndex
	{
		[Token(Token = "0x6017C4B")]
		[Address(RVA = "0x1C64CEC", Offset = "0x1C64CEC", VA = "0x1C64CEC", Slot = "10")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17001887")]
	public bool MissingFieldFlag
	{
		[Token(Token = "0x6017C4C")]
		[Address(RVA = "0x1C64CF4", Offset = "0x1C64CF4", VA = "0x1C64CF4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001888")]
	public bool ParseErrorFlag
	{
		[Token(Token = "0x6017C4D")]
		[Address(RVA = "0x1C64CFC", Offset = "0x1C64CFC", VA = "0x1C64CFC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001889")]
	public string Item
	{
		[Token(Token = "0x6017C4E")]
		[Address(RVA = "0x1C64D04", Offset = "0x1C64D04", VA = "0x1C64D04")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700188A")]
	public string Item
	{
		[Token(Token = "0x6017C4F")]
		[Address(RVA = "0x1C65248", Offset = "0x1C65248", VA = "0x1C65248")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700188B")]
	public string Item
	{
		[Token(Token = "0x6017C50")]
		[Address(RVA = "0x1C64F9C", Offset = "0x1C64F9C", VA = "0x1C64F9C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700188C")]
	public virtual string Item
	{
		[Token(Token = "0x6017C51")]
		[Address(RVA = "0x1C65654", Offset = "0x1C65654", VA = "0x1C65654", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700188D")]
	public bool IsDisposed
	{
		[Token(Token = "0x6017C6A")]
		[Address(RVA = "0x1C68F98", Offset = "0x1C68F98", VA = "0x1C68F98")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x14000007")]
	public event EventHandler<ParseErrorEventArgs> ParseError
	{
		[Token(Token = "0x6017C34")]
		[Address(RVA = "0x1C6480C", Offset = "0x1C6480C", VA = "0x1C6480C")]
		add
		{
		}
		[Token(Token = "0x6017C35")]
		[Address(RVA = "0x1C64918", Offset = "0x1C64918", VA = "0x1C64918")]
		remove
		{
		}
	}

	[Token(Token = "0x14000008")]
	public event EventHandler Disposed
	{
		[Token(Token = "0x6017C68")]
		[Address(RVA = "0x1C68D80", Offset = "0x1C68D80", VA = "0x1C68D80")]
		add
		{
		}
		[Token(Token = "0x6017C69")]
		[Address(RVA = "0x1C68E8C", Offset = "0x1C68E8C", VA = "0x1C68E8C")]
		remove
		{
		}
	}

	[Token(Token = "0x6017C2E")]
	[Address(RVA = "0x1C64188", Offset = "0x1C64188", VA = "0x1C64188")]
	public CsvReader(TextReader reader, bool hasHeaders)
	{
	}

	[Token(Token = "0x6017C2F")]
	[Address(RVA = "0x1C6453C", Offset = "0x1C6453C", VA = "0x1C6453C")]
	public CsvReader(TextReader reader, bool hasHeaders, int bufferSize)
	{
	}

	[Token(Token = "0x6017C30")]
	[Address(RVA = "0x1C64574", Offset = "0x1C64574", VA = "0x1C64574")]
	public CsvReader(TextReader reader, bool hasHeaders, char delimiter)
	{
	}

	[Token(Token = "0x6017C31")]
	[Address(RVA = "0x1C6464C", Offset = "0x1C6464C", VA = "0x1C6464C")]
	public CsvReader(TextReader reader, bool hasHeaders, char delimiter, int bufferSize)
	{
	}

	[Token(Token = "0x6017C32")]
	[Address(RVA = "0x1C64688", Offset = "0x1C64688", VA = "0x1C64688")]
	public CsvReader(TextReader reader, bool hasHeaders, char delimiter, char quote, char escape, char comment, ValueTrimmingOptions trimmingOptions)
	{
	}

	[Token(Token = "0x6017C33")]
	[Address(RVA = "0x1C6425C", Offset = "0x1C6425C", VA = "0x1C6425C")]
	public CsvReader(TextReader reader, bool hasHeaders, char delimiter, char quote, char escape, char comment, ValueTrimmingOptions trimmingOptions, int bufferSize)
	{
	}

	[Token(Token = "0x6017C36")]
	[Address(RVA = "0x1C64A24", Offset = "0x1C64A24", VA = "0x1C64A24", Slot = "8")]
	protected virtual void OnParseError(ParseErrorEventArgs e)
	{
	}

	[Token(Token = "0x6017C4A")]
	[Address(RVA = "0x1C64B94", Offset = "0x1C64B94", VA = "0x1C64B94")]
	public string[] GetFieldHeaders()
	{
		return null;
	}

	[Token(Token = "0x6017C52")]
	[Address(RVA = "0x1C64B58", Offset = "0x1C64B58", VA = "0x1C64B58")]
	private void EnsureInitialize()
	{
	}

	[Token(Token = "0x6017C53")]
	[Address(RVA = "0x1C654EC", Offset = "0x1C654EC", VA = "0x1C654EC")]
	public int GetFieldIndex(string header)
	{
		return default(int);
	}

	[Token(Token = "0x6017C54")]
	[Address(RVA = "0x1C66A8C", Offset = "0x1C66A8C", VA = "0x1C66A8C")]
	public void CopyCurrentRecordTo(string[] array)
	{
	}

	[Token(Token = "0x6017C55")]
	[Address(RVA = "0x1C66A94", Offset = "0x1C66A94", VA = "0x1C66A94")]
	public void CopyCurrentRecordTo(string[] array, int index)
	{
	}

	[Token(Token = "0x6017C56")]
	[Address(RVA = "0x1C66ED4", Offset = "0x1C66ED4", VA = "0x1C66ED4")]
	public string GetCurrentRawData()
	{
		return null;
	}

	[Token(Token = "0x6017C57")]
	[Address(RVA = "0x1C66FA0", Offset = "0x1C66FA0", VA = "0x1C66FA0")]
	private bool IsWhiteSpace(char c)
	{
		return default(bool);
	}

	[Token(Token = "0x6017C58")]
	[Address(RVA = "0x1C67000", Offset = "0x1C67000", VA = "0x1C67000", Slot = "12")]
	public virtual bool MoveTo(long record)
	{
		return default(bool);
	}

	[Token(Token = "0x6017C59")]
	[Address(RVA = "0x1C6709C", Offset = "0x1C6709C", VA = "0x1C6709C")]
	private bool ParseNewLine(ref int pos)
	{
		return default(bool);
	}

	[Token(Token = "0x6017C5A")]
	[Address(RVA = "0x1C672CC", Offset = "0x1C672CC", VA = "0x1C672CC")]
	private bool IsNewLine(int pos)
	{
		return default(bool);
	}

	[Token(Token = "0x6017C5B")]
	[Address(RVA = "0x1C67234", Offset = "0x1C67234", VA = "0x1C67234")]
	private bool ReadBuffer()
	{
		return default(bool);
	}

	[Token(Token = "0x6017C5C")]
	[Address(RVA = "0x1C65674", Offset = "0x1C65674", VA = "0x1C65674")]
	private string ReadField(int field, bool initializing, bool discardValue)
	{
		return null;
	}

	[Token(Token = "0x6017C5D")]
	[Address(RVA = "0x1C67084", Offset = "0x1C67084", VA = "0x1C67084")]
	public bool ReadNextRecord()
	{
		return default(bool);
	}

	[Token(Token = "0x6017C5E")]
	[Address(RVA = "0x1C6805C", Offset = "0x1C6805C", VA = "0x1C6805C", Slot = "13")]
	protected virtual bool ReadNextRecord(bool onlyReadHeaders, bool skipToNextLine)
	{
		return default(bool);
	}

	[Token(Token = "0x6017C5F")]
	[Address(RVA = "0x1C68730", Offset = "0x1C68730", VA = "0x1C68730")]
	private bool SkipEmptyAndCommentedLines(ref int pos)
	{
		return default(bool);
	}

	[Token(Token = "0x6017C60")]
	[Address(RVA = "0x1C68838", Offset = "0x1C68838", VA = "0x1C68838")]
	private void DoSkipEmptyAndCommentedLines(ref int pos)
	{
	}

	[Token(Token = "0x6017C61")]
	[Address(RVA = "0x1C67974", Offset = "0x1C67974", VA = "0x1C67974")]
	private bool SkipWhiteSpaces(ref int pos)
	{
		return default(bool);
	}

	[Token(Token = "0x6017C62")]
	[Address(RVA = "0x1C687C8", Offset = "0x1C687C8", VA = "0x1C687C8")]
	private bool SkipToNextLine(ref int pos)
	{
		return default(bool);
	}

	[Token(Token = "0x6017C63")]
	[Address(RVA = "0x1C67A7C", Offset = "0x1C67A7C", VA = "0x1C67A7C")]
	private void HandleParseError(MalformedCsvException error, ref int pos)
	{
	}

	[Token(Token = "0x6017C64")]
	[Address(RVA = "0x1C674AC", Offset = "0x1C674AC", VA = "0x1C674AC")]
	private string HandleMissingField(string value, int fieldIndex, ref int currentPosition)
	{
		return null;
	}

	[Token(Token = "0x6017C65")]
	[Address(RVA = "0x1C68B8C", Offset = "0x1C68B8C", VA = "0x1C68B8C")]
	public RecordEnumerator GetEnumerator()
	{
		return default(RecordEnumerator);
	}

	[Token(Token = "0x6017C66")]
	[Address(RVA = "0x1C68C68", Offset = "0x1C68C68", VA = "0x1C68C68", Slot = "4")]
	private IEnumerator<string[]> System_002ECollections_002EGeneric_002EIEnumerable_003Cstring_005B_005D_003E_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6017C67")]
	[Address(RVA = "0x1C68CF4", Offset = "0x1C68CF4", VA = "0x1C68CF4", Slot = "5")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6017C6B")]
	[Address(RVA = "0x1C68FA0", Offset = "0x1C68FA0", VA = "0x1C68FA0", Slot = "14")]
	protected virtual void OnDisposed(EventArgs e)
	{
	}

	[Token(Token = "0x6017C6C")]
	[Address(RVA = "0x1C67340", Offset = "0x1C67340", VA = "0x1C67340")]
	protected void CheckDisposed()
	{
	}

	[Token(Token = "0x6017C6D")]
	[Address(RVA = "0x1C68FBC", Offset = "0x1C68FBC", VA = "0x1C68FBC", Slot = "6")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6017C6E")]
	[Address(RVA = "0x1C68FFC", Offset = "0x1C68FFC", VA = "0x1C68FFC", Slot = "15")]
	protected virtual void Dispose(bool disposing)
	{
	}

	[Token(Token = "0x6017C6F")]
	[Address(RVA = "0x1C692B0", Offset = "0x1C692B0", VA = "0x1C692B0", Slot = "1")]
	~CsvReader()
	{
	}
}
