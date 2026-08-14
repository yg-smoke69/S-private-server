using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2004150")]
public class UIListAnimQueueHelper : MonoBehaviour
{
	[Token(Token = "0x401B686")]
	[FieldOffset(Offset = "0xC")]
	public float PlayInterval;

	[Token(Token = "0x401B687")]
	[FieldOffset(Offset = "0x10")]
	private uint m_TotalItemCnt;

	[Token(Token = "0x401B688")]
	[FieldOffset(Offset = "0x14")]
	private float m_LastPlayTime;

	[Token(Token = "0x401B689")]
	[FieldOffset(Offset = "0x18")]
	private int m_LastPlayIndex;

	[Token(Token = "0x601AAF1")]
	[Address(RVA = "0x2CA4CC0", Offset = "0x2CA4CC0", VA = "0x2CA4CC0")]
	public UIListAnimQueueHelper()
	{
	}

	[Token(Token = "0x601AAF2")]
	[Address(RVA = "0x2CA129C", Offset = "0x2CA129C", VA = "0x2CA129C")]
	public void PlayItemAnimQueue(UIEasyListItemController[] itemCtrls, uint totalItemCnt)
	{
	}

	[Token(Token = "0x601AAF3")]
	[Address(RVA = "0x2CA4ED8", Offset = "0x2CA4ED8", VA = "0x2CA4ED8")]
	private void Update()
	{
	}

	[Token(Token = "0x601AAF4")]
	[Address(RVA = "0x2CA4F3C", Offset = "0x2CA4F3C", VA = "0x2CA4F3C")]
	private int _003CPlayItemAnimQueue_003Em__0()
	{
		return default(int);
	}
}
