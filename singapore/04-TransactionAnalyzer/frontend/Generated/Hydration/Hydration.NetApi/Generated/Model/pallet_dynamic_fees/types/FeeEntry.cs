//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Attributes;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace Hydration.NetApi.Generated.Model.pallet_dynamic_fees.types
{
    
    
    /// <summary>
    /// >> 590 - Composite[pallet_dynamic_fees.types.FeeEntry]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class FeeEntry : BaseType
    {
        
        /// <summary>
        /// >> asset_fee
        /// </summary>
        public Hydration.NetApi.Generated.Model.sp_arithmetic.per_things.Permill AssetFee { get; set; }
        /// <summary>
        /// >> protocol_fee
        /// </summary>
        public Hydration.NetApi.Generated.Model.sp_arithmetic.per_things.Permill ProtocolFee { get; set; }
        /// <summary>
        /// >> timestamp
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 Timestamp { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "FeeEntry";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(AssetFee.Encode());
            result.AddRange(ProtocolFee.Encode());
            result.AddRange(Timestamp.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            AssetFee = new Hydration.NetApi.Generated.Model.sp_arithmetic.per_things.Permill();
            AssetFee.Decode(byteArray, ref p);
            ProtocolFee = new Hydration.NetApi.Generated.Model.sp_arithmetic.per_things.Permill();
            ProtocolFee.Decode(byteArray, ref p);
            Timestamp = new Substrate.NetApi.Model.Types.Primitive.U32();
            Timestamp.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}