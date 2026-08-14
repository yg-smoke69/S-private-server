using System;
using System.Collections;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UMA;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000088")]
internal class ArenaNPCPlayer : MonoBehaviour
{
	[Token(Token = "0x2000089")]
	private sealed class _003CUpdateTopPlayerAvatar_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x40002D1")]
		[FieldOffset(Offset = "0x8")]
		internal ArenaNPCPlayer _0024this;

		[Token(Token = "0x40002D2")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x40002D3")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x40002D4")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x17000074")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6000333")]
			[Address(RVA = "0x14CC79C", Offset = "0x14CC79C", VA = "0x14CC79C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000075")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x14CC7A4", Offset = "0x14CC7A4", VA = "0x14CC7A4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x14CC560", Offset = "0x14CC560", VA = "0x14CC560")]
		public _003CUpdateTopPlayerAvatar_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x14CC568", Offset = "0x14CC568", VA = "0x14CC568", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x14CC7AC", Offset = "0x14CC7AC", VA = "0x14CC7AC", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x14CC7C0", Offset = "0x14CC7C0", VA = "0x14CC7C0", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x40002CE")]
	[FieldOffset(Offset = "0xC")]
	private AvatarManager m_AvatarManager;

	[Token(Token = "0x40002CF")]
	[FieldOffset(Offset = "0x10")]
	private EPPlayerInfo m_PlayerInfo;

	[Token(Token = "0x40002D0")]
	[FieldOffset(Offset = "0x14")]
	private ResourceID m_ResourceID;

	[Token(Token = "0x600032D")]
	[Address(RVA = "0x14CBD24", Offset = "0x14CBD24", VA = "0x14CBD24")]
	public ArenaNPCPlayer()
	{
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0x14CBDC4", Offset = "0x14CBDC4", VA = "0x14CBDC4")]
	public void CreatePlayer(EPPlayerInfo playerInfo, ResourceID animID)
	{
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0x14CC3E8", Offset = "0x14CC3E8", VA = "0x14CC3E8")]
	private void RerenderAfterUMAChanged(UMAData data)
	{
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0x14CC31C", Offset = "0x14CC31C", VA = "0x14CC31C")]
	protected IEnumerator UpdateTopPlayerAvatar()
	{
		return null;
	}
}
