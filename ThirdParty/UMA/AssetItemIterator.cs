using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UMA;

[Token(Token = "0x2003CFB")]
public class AssetItemIterator<T> : _Attribute, IConvertible, IComparable<int>, IFormattable, IComparable where T : class
{
	[Token(Token = "0x4019E4A")]
	[FieldOffset(Offset = "0x0")]
	private Dictionary<string, UMAAssetIndexer.AssetItem>.ValueCollection.Enumerator m_iterator;

	[Token(Token = "0x170019C5")]
	private object System_002ECollections_002EIEnumerator_002ECurrent
	{
		[Token(Token = "0x60186C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170019C6")]
	public T Current
	{
		[Token(Token = "0x60186BF")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60186BB")]
	public AssetItemIterator(UMAAssetIndexer index)
	{
	}

	[Token(Token = "0x60186BC")]
	public AssetItemIterator(Dictionary<string, UMAAssetIndexer.AssetItem>.ValueCollection values)
	{
	}

	[Token(Token = "0x60186BD")]
	private IEnumerator<T> System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x60186BE")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x60186C1")]
	public void Dispose()
	{
	}

	[Token(Token = "0x60186C2")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Token(Token = "0x60186C3")]
	public void Reset()
	{
	}
}
