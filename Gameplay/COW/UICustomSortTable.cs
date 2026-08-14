using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003344")]
public class UICustomSortTable : UITable
{
	[Token(Token = "0x6015C75")]
	[Address(RVA = "0x11EF410", Offset = "0x11EF410", VA = "0x11EF410")]
	public UICustomSortTable()
	{
	}

	[Token(Token = "0x6015C76")]
	[Address(RVA = "0x11EF418", Offset = "0x11EF418", VA = "0x11EF418", Slot = "4")]
	protected override void Sort(List<Transform> list)
	{
	}

	[Token(Token = "0x6015C77")]
	[Address(RVA = "0x11EF524", Offset = "0x11EF524", VA = "0x11EF524")]
	private int SortBySortId(Transform g1, Transform g2)
	{
		return default(int);
	}

	[Token(Token = "0x6015C78")]
	[Address(RVA = "0x11EF664", Offset = "0x11EF664", VA = "0x11EF664")]
	public void _003C_003EiFixBaseProxy_Sort(List<Transform> P0)
	{
	}
}
