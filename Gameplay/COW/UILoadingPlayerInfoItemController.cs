using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using tcp;

namespace COW;

[Token(Token = "0x200290F")]
public class UILoadingPlayerInfoItemController : MonoBehaviour
{
	[Token(Token = "0x400FCD6")]
	[FieldOffset(Offset = "0xC")]
	private UILoadingPlayerInfoItemView m_View;

	[Token(Token = "0x400FCD7")]
	private const string NAME_ANIM_REFRESH = "FF_CSLoadinginfo_on";

	[Token(Token = "0x400FCD8")]
	[FieldOffset(Offset = "0x10")]
	private uint m_DataType;

	[Token(Token = "0x6010476")]
	[Address(RVA = "0x215B5E4", Offset = "0x215B5E4", VA = "0x215B5E4")]
	public UILoadingPlayerInfoItemController()
	{
	}

	[Token(Token = "0x6010477")]
	[Address(RVA = "0x215B57C", Offset = "0x215B57C", VA = "0x215B57C")]
	public void SetView(UILoadingPlayerInfoItemView view)
	{
	}

	[Token(Token = "0x6010478")]
	[Address(RVA = "0x215B1FC", Offset = "0x215B1FC", VA = "0x215B1FC")]
	public void SetViewData(uint dataType, [Optional] StatsInfo statsInfo, bool showRefreshAnim = false)
	{
	}
}
