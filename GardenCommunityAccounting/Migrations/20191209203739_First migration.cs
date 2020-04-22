using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GardenCommunityAccounting.Migrations
{
    public partial class Firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_Land_LandId",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Person_LandId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "LandId",
                table: "Person");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCommunityMember",
                table: "Person",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPrivate",
                table: "Land",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Land",
                columns: new[] { "Id", "IsPrivate", "Number", "OwnerId" },
                values: new object[,]
                {
                    { new Guid("7699449c-8967-4f32-9f22-766dda450cf3"), false, 0, null },
                    { new Guid("c3bc3490-4856-40e7-88a4-aeb336f76ed4"), false, 217, null },
                    { new Guid("93bd3310-f4b0-410a-a64b-da3383e47484"), false, 216, null },
                    { new Guid("e1c5e50d-c853-4248-9021-2337e4acd79f"), false, 215, null },
                    { new Guid("4bfc1e94-e127-4db6-be1e-c0c47544652c"), false, 214, null },
                    { new Guid("7c9a52dd-b51d-4e5e-b703-8c5716787f8d"), false, 213, null },
                    { new Guid("aba73a63-dc3f-4826-a3d2-6b2042a5a962"), false, 212, null },
                    { new Guid("de0be467-005f-43e5-9728-eda34809ee65"), false, 211, null },
                    { new Guid("d0d67377-506f-4b01-8cdf-0b0accaa1fc7"), false, 218, null },
                    { new Guid("2f5ba82a-565a-484f-b783-321ec30b67f7"), false, 210, null },
                    { new Guid("a49f53ff-c2a4-4c74-9c5d-0842c71d0744"), false, 208, null },
                    { new Guid("eb5b6524-a7ce-4e64-8bf8-f81ed695dbc0"), false, 207, null },
                    { new Guid("f56a91ea-5ac9-4c45-8b13-4a1f4c590ee6"), false, 206, null },
                    { new Guid("d916cd17-71be-4014-b1e8-3ccbdff954b1"), false, 205, null },
                    { new Guid("2072ba83-ee9d-409c-a51a-e65438e639d5"), false, 204, null },
                    { new Guid("59c334f1-a2f8-4184-841b-88f235cf01e8"), false, 203, null },
                    { new Guid("cc666b36-e7db-4dc0-90e4-2936421cfb11"), false, 202, null },
                    { new Guid("59d9294b-4da8-46b7-ade8-7d911a70fbb5"), false, 209, null },
                    { new Guid("71c0fa99-181c-430e-b3bd-837fe57f2849"), false, 201, null },
                    { new Guid("ad8b1d8a-736b-4da4-985e-4be3e3bc4fa4"), false, 219, null },
                    { new Guid("f95d1379-405a-4f99-bfa6-c9550640ba38"), false, 221, null },
                    { new Guid("edc5a54b-4d05-4cab-82d4-d828ce4d9a44"), false, 237, null },
                    { new Guid("2cc4ecd6-f069-49c8-bd9e-56f073197d49"), false, 236, null },
                    { new Guid("18ec54f9-90dd-46e2-94a3-642ad369a89a"), false, 235, null },
                    { new Guid("f98ffa0a-f21b-4187-b96d-97851457035f"), false, 234, null },
                    { new Guid("26a9be73-3878-42f9-8b1b-edc1d1139f66"), false, 233, null },
                    { new Guid("7f0ab849-ed42-4da5-b849-80ccb9b95cf6"), false, 232, null },
                    { new Guid("0a7e68d9-3104-43c7-b4c0-ad157eb26500"), false, 231, null },
                    { new Guid("d1077ae6-965f-4cb3-9b06-c6e91cc1952d"), false, 220, null },
                    { new Guid("e542a120-8f15-4267-b6a5-4bed92e977eb"), false, 230, null },
                    { new Guid("c3811c1f-a149-455f-a3d0-6a649d09537b"), false, 228, null },
                    { new Guid("a8e91189-e535-4534-a7b1-3ee9cc4d6953"), false, 227, null },
                    { new Guid("6d63e97a-68d5-4e5d-bf95-7a7c0458df1f"), false, 226, null },
                    { new Guid("ef27b446-7881-43df-b7c2-3a00e4ec83cf"), false, 225, null },
                    { new Guid("30ab23fe-13b5-4dd2-bc25-e9ae9ea06633"), false, 224, null },
                    { new Guid("63ab92c7-7587-4ac6-b226-c363cf0c7eae"), false, 223, null },
                    { new Guid("54eb1b14-deaf-4cfa-a52b-1f9408da6dfa"), false, 222, null },
                    { new Guid("3326e92a-4871-4d53-a8aa-3674cb236912"), false, 229, null },
                    { new Guid("eb1bb3d6-66c1-489e-9f6f-025023f5e4a8"), false, 238, null },
                    { new Guid("1844c975-ba08-4bf9-85bb-0665521976d2"), false, 200, null },
                    { new Guid("db050a84-18a0-4f03-b362-5b6154577b34"), false, 198, null },
                    { new Guid("5b695226-7628-4e76-b861-191bf3e01462"), false, 177, null },
                    { new Guid("84556a79-65b3-4e3e-92ca-f103452400b5"), false, 176, null },
                    { new Guid("bcfbaa8f-7a7d-43c7-9cab-00446f740769"), false, 175, null },
                    { new Guid("63187bf6-d789-4b2e-b97a-8676d2654949"), false, 174, null },
                    { new Guid("42a290ed-dd3f-4c05-82a1-67d2c9ab2feb"), false, 173, null },
                    { new Guid("8b687635-f1f9-49af-b4aa-d7d043a1a7be"), false, 172, null },
                    { new Guid("65688c73-e36f-4fff-9332-d77083437954"), false, 171, null },
                    { new Guid("aa199bcb-a3e0-4ff3-adb1-cd2c3f14f533"), false, 178, null },
                    { new Guid("9ce4e76b-c998-43d2-aa95-455d6360147a"), false, 170, null },
                    { new Guid("d82201c4-fcc1-4903-b7c9-ef6934b15554"), false, 168, null },
                    { new Guid("e44dbb19-1fbd-45ea-b6c4-b6d49a8d5114"), false, 167, null },
                    { new Guid("123a1b21-a5fe-4192-9f96-d862e8940d5e"), false, 166, null },
                    { new Guid("863b4fc1-2dcb-47f1-b081-267d42fae210"), false, 165, null },
                    { new Guid("0b3ee0e4-6cdb-4056-b37e-dd5191d94de0"), false, 164, null },
                    { new Guid("7bd8fe95-9d1a-4b5a-a79f-767a5e71e413"), false, 163, null },
                    { new Guid("fb8cf12e-91d3-4e15-a1e0-ecfde210591f"), false, 162, null },
                    { new Guid("11dff56a-141a-4e11-bd97-22d880a828d3"), false, 169, null },
                    { new Guid("fcfc1d0b-375e-4cb5-b148-2fe05af7107c"), false, 199, null },
                    { new Guid("f89eee4b-5cdf-414b-82c6-df013a825ccd"), false, 179, null },
                    { new Guid("7918e89c-6430-4a38-8d48-f4b4574e3d2b"), false, 181, null },
                    { new Guid("6d0b29f6-7b1a-4f04-b9dc-0033072165e7"), false, 197, null },
                    { new Guid("b4bffb5e-2089-4c53-8431-7188eacf0e97"), false, 196, null },
                    { new Guid("092ec4f5-d214-41f9-b7d2-4f2bc65d1d1a"), false, 195, null },
                    { new Guid("8a6bdc51-3459-49ec-98d2-23050998fb04"), false, 194, null },
                    { new Guid("3f9db785-9d60-4bc5-ad36-95f55ceb5f13"), false, 193, null },
                    { new Guid("e22512fe-cc47-467e-8250-f545b0e68786"), false, 192, null },
                    { new Guid("cb516b6d-2b55-4983-a2a6-6e66f354e5f7"), false, 191, null },
                    { new Guid("6783e7c1-5a55-467b-bc5f-c6b1d74e68e3"), false, 180, null },
                    { new Guid("151ac4e8-0425-4c59-81be-ab30729ab096"), false, 190, null },
                    { new Guid("d33871a1-fe8b-422b-9080-b559bb143ff1"), false, 188, null },
                    { new Guid("bca0b6aa-d36c-447a-a59b-4f733af57836"), false, 187, null },
                    { new Guid("aecd3e64-15ce-488e-8811-edf166ee4aad"), false, 186, null },
                    { new Guid("84454959-928d-4413-b0b7-134282107bea"), false, 185, null },
                    { new Guid("4cf91a88-5f38-4632-8220-6131ee15e1e2"), false, 184, null },
                    { new Guid("e9eb1306-55b2-468e-9c50-f4419fccaedd"), false, 183, null },
                    { new Guid("55209bec-f37d-491b-8d7e-b3b64fcfaf16"), false, 182, null },
                    { new Guid("8a3563ba-3ecf-48a3-9bf7-e556c2a7d1bd"), false, 189, null },
                    { new Guid("64653a88-cc10-40fa-ad44-546298c925a3"), false, 161, null },
                    { new Guid("a2975a59-be53-4d2d-99a6-b492b64badbe"), false, 239, null },
                    { new Guid("465268b4-86b3-4da3-b070-8b88b1f2f2bb"), false, 241, null },
                    { new Guid("e2e62db0-8810-456d-9f26-947480408607"), false, 297, null },
                    { new Guid("63db17fa-2a85-45b7-91eb-e849ceb39406"), false, 296, null },
                    { new Guid("456f439b-7074-40e3-9246-bba2b4d2cdcb"), false, 295, null },
                    { new Guid("352d61cd-ce02-4845-af00-95bc9d85d7b6"), false, 294, null },
                    { new Guid("ce2f3c5e-c1b8-46e3-8f9e-9d5b97fb5240"), false, 293, null },
                    { new Guid("216d3a71-bfd3-4083-be3d-4039dbb89684"), false, 292, null },
                    { new Guid("321a277c-c986-47fb-a0ba-5f62ca0f2467"), false, 291, null },
                    { new Guid("76129175-d891-47ee-95d7-f6ba5dfdd78a"), false, 298, null },
                    { new Guid("e20416c0-7c37-4b24-b9e5-0f3fbfc8cf90"), false, 290, null },
                    { new Guid("af7d407a-c70e-4702-bf3e-4e5739a31e89"), false, 288, null },
                    { new Guid("9fc6d672-161f-4086-877a-c6d4b617626b"), false, 287, null },
                    { new Guid("e4cd457c-2f29-4783-852f-face0d71776e"), false, 286, null },
                    { new Guid("0dcb0d91-6952-4d51-85d0-b12272d5bfdd"), false, 285, null },
                    { new Guid("e0d25b72-7b73-47a1-b5a6-463ced0bccb0"), false, 284, null },
                    { new Guid("8ff9c32c-f112-48c1-9593-7451d78af591"), false, 283, null },
                    { new Guid("47511e10-d729-4b51-8af5-8376640648e3"), false, 282, null },
                    { new Guid("f485f89c-a26f-485c-81f5-c4286a1fff13"), false, 289, null },
                    { new Guid("624cf43c-9021-489b-a634-61f6ca731832"), false, 281, null },
                    { new Guid("9c4b6ebc-1cc9-4d73-a9d5-20ae03102a60"), false, 299, null },
                    { new Guid("d9be3c52-eb3a-4b5b-a924-d0e4cb6ddf50"), false, 301, null },
                    { new Guid("76f9a776-4bb6-4c62-92d7-aca96e6d431e"), false, 317, null },
                    { new Guid("680adf98-2a9a-4f43-a171-6acc994bc247"), false, 316, null },
                    { new Guid("1210e1bc-058c-4c47-8697-34b0d77284f8"), false, 315, null },
                    { new Guid("9da7219b-1855-4662-a63e-cb390a2e2087"), false, 314, null },
                    { new Guid("b422bad4-cdab-43d8-96c9-60ade55fe7cd"), false, 313, null },
                    { new Guid("76fd94b7-1338-49af-9c96-5cb35e4e0dbe"), false, 312, null },
                    { new Guid("f53f2917-dd4e-4b02-b0f2-09f72f129d17"), false, 311, null },
                    { new Guid("68800b48-c4bc-4be8-aecc-a71f0d30fa92"), false, 300, null },
                    { new Guid("4e1a3e33-91a8-4c47-9f96-dae105f5d64b"), false, 310, null },
                    { new Guid("606515b7-e7e9-47b5-824f-05ab92f51394"), false, 308, null },
                    { new Guid("fa8bdd99-22ec-4eda-b09d-339b7fe85929"), false, 307, null },
                    { new Guid("2e624466-e7b1-4097-ae9f-d23609960fe9"), false, 306, null },
                    { new Guid("b9b14357-6f7d-44a2-a9e9-ab0d3988e616"), false, 305, null },
                    { new Guid("72f904f3-cc91-4bb0-99d6-eeae0619f7de"), false, 304, null },
                    { new Guid("6af7102c-81a4-43df-adb3-e9bc1754e1fc"), false, 303, null },
                    { new Guid("100bf6c2-aef6-457f-944d-2450dd0ff568"), false, 302, null },
                    { new Guid("f2dd5422-1724-4030-8e32-987f645c06b3"), false, 309, null },
                    { new Guid("a673ea77-adf0-4107-be57-b2dcfa8296d4"), false, 240, null },
                    { new Guid("6eca3803-5b59-472a-b98a-61a9544c36f5"), false, 280, null },
                    { new Guid("39d7ae66-af75-4857-8952-34bc3f56f96a"), false, 278, null },
                    { new Guid("92192638-40e1-4ba8-9c17-fbfa00156845"), false, 257, null },
                    { new Guid("40c4f13c-88f9-453b-af1a-8aac176a6753"), false, 256, null },
                    { new Guid("6e8dac9c-3fc8-46f5-a592-92e03a2b4eb8"), false, 255, null },
                    { new Guid("9cf02303-5cfd-4e69-b18b-9bc4260f35f7"), false, 254, null },
                    { new Guid("dff79e8c-960f-4c85-965f-c406e3ac043b"), false, 253, null },
                    { new Guid("cf913d0f-6f5f-449c-8231-358f9a9eb607"), false, 252, null },
                    { new Guid("a654022d-ad8e-40e4-a85f-4581e2cbadc5"), false, 251, null },
                    { new Guid("56effdf7-069f-4d20-b6ed-5b23713e9012"), false, 258, null },
                    { new Guid("f83a91a7-da53-41e9-8faf-0d7b254c7b7f"), false, 250, null },
                    { new Guid("8e35c869-f6d3-4abb-b549-3323e66430f3"), false, 248, null },
                    { new Guid("a2c67e40-880d-4540-90b6-da4f8b7349b8"), false, 247, null },
                    { new Guid("f8117f89-6a74-47db-8c1d-0bd1b58c7ffd"), false, 246, null },
                    { new Guid("9b349299-4414-47b0-a695-929412b7a759"), false, 245, null },
                    { new Guid("86f97ee8-0574-49c0-9a1a-3a7db0314c89"), false, 244, null },
                    { new Guid("0e5b24c0-d6de-4c12-b682-39f650938c07"), false, 243, null },
                    { new Guid("7288eb21-9e00-40e4-b5fe-0571397c63d2"), false, 242, null },
                    { new Guid("1b9caa82-cef2-4da9-9656-3c9badda5ef6"), false, 249, null },
                    { new Guid("c420119a-240e-4135-9c9b-81a6b411958c"), false, 279, null },
                    { new Guid("8f2a7173-ad59-4fe0-942e-d65ea7f40893"), false, 259, null },
                    { new Guid("deda8c4b-f5d3-46c5-8da3-bb015294daed"), false, 261, null },
                    { new Guid("d48264e8-565b-49ed-bcdb-7b06325fa20c"), false, 277, null },
                    { new Guid("a7eac536-a844-40dd-8b49-b743224c0f06"), false, 276, null },
                    { new Guid("5e5b796f-834d-45ba-a05c-716b43001630"), false, 275, null },
                    { new Guid("ae14de62-3578-4e82-afec-743164182f11"), false, 274, null },
                    { new Guid("f66a8c82-1a40-462d-be52-28cac60338f0"), false, 273, null },
                    { new Guid("c5a1f299-558b-4d9d-935e-c29101c85b20"), false, 272, null },
                    { new Guid("96c12bed-cb7e-4ade-9eeb-b82b290317a9"), false, 271, null },
                    { new Guid("2229b384-2395-4ae4-8219-61a0ea555bef"), false, 260, null },
                    { new Guid("9f507dd6-b954-4b61-9b7c-ac7faa220aa8"), false, 270, null },
                    { new Guid("ee9f0d35-2f28-488b-9061-4aea6796bd98"), false, 268, null },
                    { new Guid("f292b60a-2ac0-435d-9a4b-efab1db7979a"), false, 267, null },
                    { new Guid("42d67c5f-e2d7-4d0e-b260-af46d778f50e"), false, 266, null },
                    { new Guid("773dc8bf-ff42-4ff8-a395-c2743d269590"), false, 265, null },
                    { new Guid("b43add60-e34a-47d2-9e1a-620dd86251af"), false, 264, null },
                    { new Guid("f1a26e12-6365-448e-81f8-45515cb2f73f"), false, 263, null },
                    { new Guid("7043308d-35f9-485d-9e7e-e58beefaf913"), false, 262, null },
                    { new Guid("cdc529aa-f35e-4ec8-901a-cf9ee10777e2"), false, 269, null },
                    { new Guid("d523bb45-00b3-4836-a356-30d8a5cc646d"), false, 160, null },
                    { new Guid("8f0fc1ab-e10e-4f2e-9336-7c62bb383064"), false, 159, null },
                    { new Guid("4aafd4dd-ace2-4deb-a9e9-3c48bf9ac576"), false, 158, null },
                    { new Guid("aea935e3-c65b-4ffb-ac0f-567378d88175"), false, 56, null },
                    { new Guid("f002b868-7d9f-4b80-b56a-58fce67324f8"), false, 55, null },
                    { new Guid("a7054d54-9aba-49eb-b62e-6756b9d4e299"), false, 54, null },
                    { new Guid("fe62e398-6723-4172-8bfe-d634030e018d"), false, 53, null },
                    { new Guid("6ed9d5a9-2a9e-426f-b857-d2b6ecfe2a21"), false, 52, null },
                    { new Guid("507f0524-cc95-4a27-a155-ab5039523d58"), false, 51, null },
                    { new Guid("2721bab0-0a35-4494-a82c-1b27678c7c38"), false, 50, null },
                    { new Guid("21770242-3ba8-43c6-b420-5a6b1679b36e"), false, 57, null },
                    { new Guid("f3835868-41c0-482f-ad1f-0760c856512a"), false, 49, null },
                    { new Guid("94ac8e4d-6fdd-441f-a451-fc3c00999fe8"), false, 47, null },
                    { new Guid("5a5b0a6c-300b-43a2-bb42-ea83289571c7"), false, 46, null },
                    { new Guid("5e07742b-03cc-4938-95f7-9952251a1836"), false, 45, null },
                    { new Guid("b282e7bb-9b89-4b6f-aadf-319e693c4dc6"), false, 44, null },
                    { new Guid("aae0fce0-6c42-4355-87dd-9935d7aa1e53"), false, 43, null },
                    { new Guid("a778d93b-7d0e-47cf-b4c7-62f63d4e91e8"), false, 42, null },
                    { new Guid("3cdeba34-b5f2-475b-8499-3ae3285f7d4f"), false, 41, null },
                    { new Guid("b9f27a1c-cf6d-4ebd-9387-8d56469d4755"), false, 48, null },
                    { new Guid("2c54cba2-69b2-4101-9130-ec91bbe4a8ca"), false, 40, null },
                    { new Guid("0bebe0a6-b422-4d8b-a766-146f79fea397"), false, 58, null },
                    { new Guid("96665f51-0339-4d39-8eb0-88e21b26de9c"), false, 60, null },
                    { new Guid("6be51480-8cbc-4d2b-8604-4ad14aa0c73b"), false, 76, null },
                    { new Guid("eb09211e-e582-455e-af29-ab028a428da4"), false, 75, null },
                    { new Guid("ca1292f2-0f07-4a20-ae39-7dae7dce30c7"), false, 74, null },
                    { new Guid("b1958675-fb78-442f-8998-ef55b2477745"), false, 73, null },
                    { new Guid("cc9c2fa9-eb9d-42c3-8e95-409e5ff6bf7c"), false, 72, null },
                    { new Guid("8ba05c88-05c6-4b65-8ee9-fd4eb985580d"), false, 71, null },
                    { new Guid("99a421d8-1c89-42ac-bce1-24baaf9d4a41"), false, 70, null },
                    { new Guid("13a997e3-1dc7-46a6-ac19-b5e4902a2a35"), false, 59, null },
                    { new Guid("bc8d24a9-022b-4902-88a6-1c0e92e16794"), false, 69, null },
                    { new Guid("8b9886ee-881c-4566-91d8-18bdae5d6f0f"), false, 67, null },
                    { new Guid("291d3080-f5ec-4fe4-a4b5-0b2ead87e2e6"), false, 66, null },
                    { new Guid("461dec01-27f7-4a11-9675-dd42815fef45"), false, 65, null },
                    { new Guid("06d5f6b9-aa97-4795-8b34-c93fe3b306ae"), false, 64, null },
                    { new Guid("003c343d-f005-4146-b9e1-3eede10367d5"), false, 63, null },
                    { new Guid("e78271e4-4ae4-4a98-838a-84a71b307543"), false, 62, null },
                    { new Guid("90b9b2aa-33b8-4dda-820b-7192e3b0da6a"), false, 61, null },
                    { new Guid("3d9165c9-7b1f-4639-b6da-9a0efad9c682"), false, 68, null },
                    { new Guid("db291a39-3d07-4029-a840-14f8a1004bba"), false, 77, null },
                    { new Guid("7e62eedc-ae61-4ce8-9250-0c60f683a4e2"), false, 39, null },
                    { new Guid("a24d41ca-4421-4126-8f12-b5e560c33267"), false, 37, null },
                    { new Guid("2be47ab1-16bb-4bdc-8b19-aa17e920798b"), false, 16, null },
                    { new Guid("d6edcf5e-0cbb-48f4-acde-3dd62374a8ad"), false, 15, null },
                    { new Guid("1a960576-2f72-44b0-99f9-98a55dfdef74"), false, 14, null },
                    { new Guid("e488cc28-0d2e-474c-95d7-e644e2ea7185"), false, 13, null },
                    { new Guid("a9b84240-4d18-42ab-8577-9fd25af8d630"), false, 12, null },
                    { new Guid("6d8386cc-0ad1-429c-b85c-3bf37d0bfb54"), false, 11, null },
                    { new Guid("2491e790-f170-4dba-89fc-f312e4509b9c"), false, 10, null },
                    { new Guid("e474e0f6-d416-4346-a0a8-0fed81b4a4bd"), false, 17, null },
                    { new Guid("ad04ca8b-1564-4844-b26c-be2a2e0e1412"), false, 9, null },
                    { new Guid("f6218a18-0b44-4284-ac42-7b68ab2162bb"), false, 7, null },
                    { new Guid("13d12bfe-5633-440d-8d47-a7fec064b80a"), false, 6, null },
                    { new Guid("db903bbc-00b7-4e27-8c99-660e2af61f4e"), false, 5, null },
                    { new Guid("7732bdbd-3491-4064-8ffb-933dc688b344"), false, 4, null },
                    { new Guid("c9fa3893-003e-4fb5-8f3d-d24e90436530"), false, 3, null },
                    { new Guid("31f4005c-2347-4b78-bc81-4939e1d91d80"), false, 2, null },
                    { new Guid("aa09e0bc-1070-485b-aed7-1e6563935bed"), false, 1, null },
                    { new Guid("dc08efdb-09c9-499d-bdcd-88e556e8a9be"), false, 8, null },
                    { new Guid("27110072-9065-46af-b4c3-a0847f7cfa6d"), false, 38, null },
                    { new Guid("51a7a24b-11d2-465a-9e56-de5639aa2907"), false, 18, null },
                    { new Guid("c553d218-9c02-4cd2-95f4-17e0718ddbce"), false, 20, null },
                    { new Guid("fa2b0cac-035f-48de-9121-e2106b9bb8ce"), false, 36, null },
                    { new Guid("9e356f1c-9432-4a34-a117-ec8bbee2d195"), false, 35, null },
                    { new Guid("bf3574ff-e1b9-4d16-8981-2aec361d0272"), false, 34, null },
                    { new Guid("50c571a7-c872-4f6e-b550-a179f6a00f36"), false, 33, null },
                    { new Guid("976c157a-4589-4c16-8a92-00c94e1a620b"), false, 32, null },
                    { new Guid("631112a8-09e9-4515-8238-184f88950bab"), false, 31, null },
                    { new Guid("75c59b31-30f8-4f33-949e-295725c2b453"), false, 30, null },
                    { new Guid("95614f93-2840-465a-9b5b-4a239a46464a"), false, 19, null },
                    { new Guid("54eae395-0ba8-4fa0-b1c1-3709813513e4"), false, 29, null },
                    { new Guid("6b91fae1-a71b-4b8b-88c1-14e9641e3cee"), false, 27, null },
                    { new Guid("de016bd1-6b67-4680-942e-1f318600e865"), false, 26, null },
                    { new Guid("ea8683ba-4043-4488-8fc8-4ba8f4f7a7b2"), false, 25, null },
                    { new Guid("93b4c06c-570f-4293-af65-71c8aeb36a4d"), false, 24, null },
                    { new Guid("5fed2a98-e12f-4ff9-9c93-8c56c1e0a77f"), false, 23, null },
                    { new Guid("fd798780-9cc7-49c8-bd18-3c8a5a8e00f4"), false, 22, null },
                    { new Guid("3f5e9d16-335a-49cd-9232-bd93b290607b"), false, 21, null },
                    { new Guid("c208386a-3541-4665-9299-456c6af2b991"), false, 28, null },
                    { new Guid("b2d0e857-0aef-4bc8-b2e7-e04b013404b9"), false, 78, null },
                    { new Guid("0d68bf76-9287-4de0-a53d-59060adaa8eb"), false, 79, null },
                    { new Guid("f593e7d2-c940-4987-a74b-9ca55dc5d6d9"), false, 80, null },
                    { new Guid("16d92d08-88b0-4b31-82b8-9456e9cda4d8"), false, 137, null },
                    { new Guid("3c609127-e531-411a-b3ec-1b9cb0e4bb55"), false, 136, null },
                    { new Guid("2df77a5a-d944-4eb3-be32-8a23a1e4bb7e"), false, 135, null },
                    { new Guid("2cd191e7-5d76-45e1-8979-87e7f9b60bf3"), false, 134, null },
                    { new Guid("4693b7ea-1409-4e68-bb73-44ae443fc131"), false, 133, null },
                    { new Guid("7c7772a1-c68a-4a4b-a2f6-ef659e1bfcee"), false, 132, null },
                    { new Guid("4653df6c-338d-48c6-9cd3-a0c1da70752a"), false, 131, null },
                    { new Guid("1e2dd678-441b-471b-a988-d82c741edbfd"), false, 138, null },
                    { new Guid("2e4d2ed9-9f10-4427-94bc-3905dae9d242"), false, 130, null },
                    { new Guid("040b3814-d91a-4cb2-835f-07894f4819b9"), false, 128, null },
                    { new Guid("38696b71-15ef-43fc-aee4-613a20ca4bcc"), false, 127, null },
                    { new Guid("fd15e57f-0b82-41ce-91dc-2ed72664aeef"), false, 126, null },
                    { new Guid("10a3b585-5fbd-407d-a28d-9d29ed9b3ef7"), false, 125, null },
                    { new Guid("4a8cbb09-b3e3-4dda-9e82-20671d05d75a"), false, 124, null },
                    { new Guid("dafe7386-fcae-4089-8939-797d3be170db"), false, 123, null },
                    { new Guid("7267063f-e902-4d97-888d-08fb4bc7dad3"), false, 122, null },
                    { new Guid("28107bcb-65ff-4d75-bdb6-4ac68fb68e6d"), false, 129, null },
                    { new Guid("4d0905da-ff72-4bee-be89-0f4b23f626cd"), false, 121, null },
                    { new Guid("9c0cc85e-fad7-4951-b0d4-8e54e3308a7c"), false, 139, null },
                    { new Guid("a96ac3a2-2a75-4496-b046-1dc8a5031eeb"), false, 141, null },
                    { new Guid("7b794d99-87b8-44ad-b027-9490a2d0d053"), false, 157, null },
                    { new Guid("05309995-ec05-4160-b136-6014539190be"), false, 156, null },
                    { new Guid("1724cf54-5134-4210-a20e-23b07b9bb5d1"), false, 155, null },
                    { new Guid("98d21c82-0df3-426f-9754-c2791e60b0bc"), false, 154, null },
                    { new Guid("b9e524e1-0c47-42c5-be8e-6288fc3a27f7"), false, 153, null },
                    { new Guid("53134df4-f499-465b-982e-4c97c954738c"), false, 152, null },
                    { new Guid("144e68ad-f321-42b0-9977-20c4f3c5171e"), false, 151, null },
                    { new Guid("76002ca2-412b-4f77-8906-79b15e607fc9"), false, 140, null },
                    { new Guid("213eb937-9ec1-439b-958e-2419c388ccf3"), false, 150, null },
                    { new Guid("0823addc-bd64-4d42-8fd1-96ddaaff677a"), false, 148, null },
                    { new Guid("77e6737f-4ca8-4f0a-a97f-01b038d6cf56"), false, 147, null },
                    { new Guid("2dea9cf2-15e3-4eba-906f-7fb2bed6f2b3"), false, 146, null },
                    { new Guid("feff9898-272e-4691-8e04-5248fd1c3055"), false, 145, null },
                    { new Guid("dd490eb7-8042-41d6-85a7-3a80d6dbfb8d"), false, 144, null },
                    { new Guid("b543ac02-8a2b-4628-9ae1-3b5fcfbec4e1"), false, 143, null },
                    { new Guid("5a76e755-0a46-451e-a183-f978c50ecf68"), false, 142, null },
                    { new Guid("51345bee-68d4-4af7-95a1-df8a1e05ab1f"), false, 149, null },
                    { new Guid("12a4fb7d-af45-413d-8b60-dc4f32f23260"), false, 120, null },
                    { new Guid("3af7b85a-110a-4f5c-b1d9-ce1d3f107e55"), false, 119, null },
                    { new Guid("fb01e187-3acb-41e0-b080-7e50c2912a98"), false, 118, null },
                    { new Guid("4ba02a79-f70d-4727-a80d-e9dfa6a1c029"), false, 96, null },
                    { new Guid("31499f96-ee95-4ffd-90bf-6bbede2d5a24"), false, 95, null },
                    { new Guid("27ee074c-915a-4fc0-a4e5-c0e523c20f72"), false, 94, null },
                    { new Guid("fb98c1f6-9357-43c8-a07f-8a40826b952f"), false, 93, null },
                    { new Guid("7ed2a9a7-137a-4ac2-8112-c5706b1a2018"), false, 92, null },
                    { new Guid("ad4f5636-3164-48da-ab55-71aecd365ad6"), false, 91, null },
                    { new Guid("3127cde4-6fd0-4bf0-bfa9-20c2619fe7b0"), false, 90, null },
                    { new Guid("30dd4795-8efe-448e-9896-8e41fd21df0c"), false, 97, null },
                    { new Guid("de519c5d-0e3c-4168-b8b5-8ea98d71ca2e"), false, 89, null },
                    { new Guid("b244bacb-dd8c-46e3-9575-a15772deb0a8"), false, 87, null },
                    { new Guid("21efe5d7-71c8-4cb9-b857-d209d04375bf"), false, 86, null },
                    { new Guid("f6640656-a1cb-464e-9985-fe6dea9b21c7"), false, 85, null },
                    { new Guid("eebbe133-79ab-479b-9139-80348e5c1463"), false, 84, null },
                    { new Guid("6dfee453-980c-4f81-9aa2-e3a4c8ae7871"), false, 83, null },
                    { new Guid("04c76d61-a08a-4659-803a-707447e7a66d"), false, 82, null },
                    { new Guid("fd679c31-febe-4072-9b9e-20f70f5c608f"), false, 81, null },
                    { new Guid("82df12b1-932d-4158-8c63-9492afde0174"), false, 88, null },
                    { new Guid("5f3782e6-8878-4a0a-ab01-f6a407924c06"), false, 98, null },
                    { new Guid("0060f752-bda9-42a0-9229-ac4ce585d736"), false, 99, null },
                    { new Guid("0a8ccd9e-89cc-4617-80bd-63816e1bf77a"), false, 100, null },
                    { new Guid("5235e50f-799c-4dc1-aad4-bbe42045f82a"), false, 117, null },
                    { new Guid("7212cb82-886b-48e1-bf8c-c946529cf118"), false, 116, null },
                    { new Guid("5d20d84a-3953-4154-91c2-292655c14c61"), false, 115, null },
                    { new Guid("71eb3ded-4814-4381-bd53-ab5ae27bd6b1"), false, 114, null },
                    { new Guid("4dbc4221-4b60-4895-a644-299a3638b123"), false, 113, null },
                    { new Guid("465c6a42-192b-484f-8b49-008b938135d9"), false, 112, null },
                    { new Guid("a7bca2cc-02ce-4504-be46-ac40eff2d551"), false, 111, null },
                    { new Guid("3d76749b-4f2f-4fec-a34e-ba8f5952a1a0"), false, 110, null },
                    { new Guid("5f23fc30-fa9a-4c86-83b7-4294c4932741"), false, 109, null },
                    { new Guid("84a1130d-0859-477b-8ad3-22bd1d0a2185"), false, 108, null },
                    { new Guid("eb7a34dd-8457-42af-8ee2-2178180e24e5"), false, 107, null },
                    { new Guid("cf967941-a8b2-4862-b7e7-af71a3933b9b"), false, 106, null },
                    { new Guid("c607b8f4-162c-4d3c-b60f-da4323164afb"), false, 105, null },
                    { new Guid("95e58184-ba5f-4439-a41b-82f8a87d4d07"), false, 104, null },
                    { new Guid("83e7a346-4d17-4aa8-8f66-bb27abfb85f4"), false, 103, null },
                    { new Guid("f53ea01f-b140-46b7-aa59-66185d9580dd"), false, 102, null },
                    { new Guid("0375d028-97a8-48ba-b7ba-7d4d558db7b9"), false, 101, null },
                    { new Guid("1644b8d3-883c-4e38-9665-2c81fda46b62"), false, 318, null },
                    { new Guid("d831becb-7130-4e14-a296-8e199c438f96"), false, 319, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("003c343d-f005-4146-b9e1-3eede10367d5"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("0060f752-bda9-42a0-9229-ac4ce585d736"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("0375d028-97a8-48ba-b7ba-7d4d558db7b9"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("040b3814-d91a-4cb2-835f-07894f4819b9"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("04c76d61-a08a-4659-803a-707447e7a66d"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("05309995-ec05-4160-b136-6014539190be"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("06d5f6b9-aa97-4795-8b34-c93fe3b306ae"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("0823addc-bd64-4d42-8fd1-96ddaaff677a"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("092ec4f5-d214-41f9-b7d2-4f2bc65d1d1a"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("0a7e68d9-3104-43c7-b4c0-ad157eb26500"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("0a8ccd9e-89cc-4617-80bd-63816e1bf77a"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("0b3ee0e4-6cdb-4056-b37e-dd5191d94de0"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("0bebe0a6-b422-4d8b-a766-146f79fea397"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("0d68bf76-9287-4de0-a53d-59060adaa8eb"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("0dcb0d91-6952-4d51-85d0-b12272d5bfdd"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("0e5b24c0-d6de-4c12-b682-39f650938c07"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("100bf6c2-aef6-457f-944d-2450dd0ff568"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("10a3b585-5fbd-407d-a28d-9d29ed9b3ef7"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("11dff56a-141a-4e11-bd97-22d880a828d3"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("1210e1bc-058c-4c47-8697-34b0d77284f8"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("123a1b21-a5fe-4192-9f96-d862e8940d5e"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("12a4fb7d-af45-413d-8b60-dc4f32f23260"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("13a997e3-1dc7-46a6-ac19-b5e4902a2a35"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("13d12bfe-5633-440d-8d47-a7fec064b80a"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("144e68ad-f321-42b0-9977-20c4f3c5171e"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("151ac4e8-0425-4c59-81be-ab30729ab096"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("1644b8d3-883c-4e38-9665-2c81fda46b62"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("16d92d08-88b0-4b31-82b8-9456e9cda4d8"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("1724cf54-5134-4210-a20e-23b07b9bb5d1"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("1844c975-ba08-4bf9-85bb-0665521976d2"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("18ec54f9-90dd-46e2-94a3-642ad369a89a"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("1a960576-2f72-44b0-99f9-98a55dfdef74"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("1b9caa82-cef2-4da9-9656-3c9badda5ef6"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("1e2dd678-441b-471b-a988-d82c741edbfd"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("2072ba83-ee9d-409c-a51a-e65438e639d5"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("213eb937-9ec1-439b-958e-2419c388ccf3"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("216d3a71-bfd3-4083-be3d-4039dbb89684"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("21770242-3ba8-43c6-b420-5a6b1679b36e"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("21efe5d7-71c8-4cb9-b857-d209d04375bf"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("2229b384-2395-4ae4-8219-61a0ea555bef"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("2491e790-f170-4dba-89fc-f312e4509b9c"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("26a9be73-3878-42f9-8b1b-edc1d1139f66"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("27110072-9065-46af-b4c3-a0847f7cfa6d"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("2721bab0-0a35-4494-a82c-1b27678c7c38"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("27ee074c-915a-4fc0-a4e5-c0e523c20f72"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("28107bcb-65ff-4d75-bdb6-4ac68fb68e6d"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("291d3080-f5ec-4fe4-a4b5-0b2ead87e2e6"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("2be47ab1-16bb-4bdc-8b19-aa17e920798b"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("2c54cba2-69b2-4101-9130-ec91bbe4a8ca"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("2cc4ecd6-f069-49c8-bd9e-56f073197d49"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("2cd191e7-5d76-45e1-8979-87e7f9b60bf3"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("2dea9cf2-15e3-4eba-906f-7fb2bed6f2b3"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("2df77a5a-d944-4eb3-be32-8a23a1e4bb7e"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("2e4d2ed9-9f10-4427-94bc-3905dae9d242"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("2e624466-e7b1-4097-ae9f-d23609960fe9"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("2f5ba82a-565a-484f-b783-321ec30b67f7"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("30ab23fe-13b5-4dd2-bc25-e9ae9ea06633"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("30dd4795-8efe-448e-9896-8e41fd21df0c"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("3127cde4-6fd0-4bf0-bfa9-20c2619fe7b0"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("31499f96-ee95-4ffd-90bf-6bbede2d5a24"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("31f4005c-2347-4b78-bc81-4939e1d91d80"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("321a277c-c986-47fb-a0ba-5f62ca0f2467"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("3326e92a-4871-4d53-a8aa-3674cb236912"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("352d61cd-ce02-4845-af00-95bc9d85d7b6"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("38696b71-15ef-43fc-aee4-613a20ca4bcc"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("39d7ae66-af75-4857-8952-34bc3f56f96a"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("3af7b85a-110a-4f5c-b1d9-ce1d3f107e55"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("3c609127-e531-411a-b3ec-1b9cb0e4bb55"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("3cdeba34-b5f2-475b-8499-3ae3285f7d4f"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("3d76749b-4f2f-4fec-a34e-ba8f5952a1a0"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("3d9165c9-7b1f-4639-b6da-9a0efad9c682"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("3f5e9d16-335a-49cd-9232-bd93b290607b"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("3f9db785-9d60-4bc5-ad36-95f55ceb5f13"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("40c4f13c-88f9-453b-af1a-8aac176a6753"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("42a290ed-dd3f-4c05-82a1-67d2c9ab2feb"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("42d67c5f-e2d7-4d0e-b260-af46d778f50e"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("456f439b-7074-40e3-9246-bba2b4d2cdcb"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("461dec01-27f7-4a11-9675-dd42815fef45"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("465268b4-86b3-4da3-b070-8b88b1f2f2bb"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("4653df6c-338d-48c6-9cd3-a0c1da70752a"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("465c6a42-192b-484f-8b49-008b938135d9"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("4693b7ea-1409-4e68-bb73-44ae443fc131"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("47511e10-d729-4b51-8af5-8376640648e3"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("4a8cbb09-b3e3-4dda-9e82-20671d05d75a"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("4aafd4dd-ace2-4deb-a9e9-3c48bf9ac576"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("4ba02a79-f70d-4727-a80d-e9dfa6a1c029"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("4bfc1e94-e127-4db6-be1e-c0c47544652c"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("4cf91a88-5f38-4632-8220-6131ee15e1e2"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("4d0905da-ff72-4bee-be89-0f4b23f626cd"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("4dbc4221-4b60-4895-a644-299a3638b123"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("4e1a3e33-91a8-4c47-9f96-dae105f5d64b"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("507f0524-cc95-4a27-a155-ab5039523d58"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("50c571a7-c872-4f6e-b550-a179f6a00f36"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("51345bee-68d4-4af7-95a1-df8a1e05ab1f"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("51a7a24b-11d2-465a-9e56-de5639aa2907"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("5235e50f-799c-4dc1-aad4-bbe42045f82a"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("53134df4-f499-465b-982e-4c97c954738c"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("54eae395-0ba8-4fa0-b1c1-3709813513e4"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("54eb1b14-deaf-4cfa-a52b-1f9408da6dfa"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("55209bec-f37d-491b-8d7e-b3b64fcfaf16"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("56effdf7-069f-4d20-b6ed-5b23713e9012"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("59c334f1-a2f8-4184-841b-88f235cf01e8"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("59d9294b-4da8-46b7-ade8-7d911a70fbb5"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("5a5b0a6c-300b-43a2-bb42-ea83289571c7"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("5a76e755-0a46-451e-a183-f978c50ecf68"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("5b695226-7628-4e76-b861-191bf3e01462"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("5d20d84a-3953-4154-91c2-292655c14c61"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("5e07742b-03cc-4938-95f7-9952251a1836"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("5e5b796f-834d-45ba-a05c-716b43001630"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("5f23fc30-fa9a-4c86-83b7-4294c4932741"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("5f3782e6-8878-4a0a-ab01-f6a407924c06"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("5fed2a98-e12f-4ff9-9c93-8c56c1e0a77f"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("606515b7-e7e9-47b5-824f-05ab92f51394"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("624cf43c-9021-489b-a634-61f6ca731832"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("631112a8-09e9-4515-8238-184f88950bab"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("63187bf6-d789-4b2e-b97a-8676d2654949"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("63ab92c7-7587-4ac6-b226-c363cf0c7eae"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("63db17fa-2a85-45b7-91eb-e849ceb39406"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("64653a88-cc10-40fa-ad44-546298c925a3"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("65688c73-e36f-4fff-9332-d77083437954"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("6783e7c1-5a55-467b-bc5f-c6b1d74e68e3"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("680adf98-2a9a-4f43-a171-6acc994bc247"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("68800b48-c4bc-4be8-aecc-a71f0d30fa92"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("6af7102c-81a4-43df-adb3-e9bc1754e1fc"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("6b91fae1-a71b-4b8b-88c1-14e9641e3cee"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("6be51480-8cbc-4d2b-8604-4ad14aa0c73b"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("6d0b29f6-7b1a-4f04-b9dc-0033072165e7"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("6d63e97a-68d5-4e5d-bf95-7a7c0458df1f"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("6d8386cc-0ad1-429c-b85c-3bf37d0bfb54"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("6dfee453-980c-4f81-9aa2-e3a4c8ae7871"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("6e8dac9c-3fc8-46f5-a592-92e03a2b4eb8"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("6eca3803-5b59-472a-b98a-61a9544c36f5"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("6ed9d5a9-2a9e-426f-b857-d2b6ecfe2a21"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("7043308d-35f9-485d-9e7e-e58beefaf913"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("71c0fa99-181c-430e-b3bd-837fe57f2849"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("71eb3ded-4814-4381-bd53-ab5ae27bd6b1"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("7212cb82-886b-48e1-bf8c-c946529cf118"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("7267063f-e902-4d97-888d-08fb4bc7dad3"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("7288eb21-9e00-40e4-b5fe-0571397c63d2"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("72f904f3-cc91-4bb0-99d6-eeae0619f7de"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("75c59b31-30f8-4f33-949e-295725c2b453"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("76002ca2-412b-4f77-8906-79b15e607fc9"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("76129175-d891-47ee-95d7-f6ba5dfdd78a"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("7699449c-8967-4f32-9f22-766dda450cf3"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("76f9a776-4bb6-4c62-92d7-aca96e6d431e"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("76fd94b7-1338-49af-9c96-5cb35e4e0dbe"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("7732bdbd-3491-4064-8ffb-933dc688b344"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("773dc8bf-ff42-4ff8-a395-c2743d269590"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("77e6737f-4ca8-4f0a-a97f-01b038d6cf56"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("7918e89c-6430-4a38-8d48-f4b4574e3d2b"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("7b794d99-87b8-44ad-b027-9490a2d0d053"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("7bd8fe95-9d1a-4b5a-a79f-767a5e71e413"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("7c7772a1-c68a-4a4b-a2f6-ef659e1bfcee"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("7c9a52dd-b51d-4e5e-b703-8c5716787f8d"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("7e62eedc-ae61-4ce8-9250-0c60f683a4e2"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("7ed2a9a7-137a-4ac2-8112-c5706b1a2018"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("7f0ab849-ed42-4da5-b849-80ccb9b95cf6"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("82df12b1-932d-4158-8c63-9492afde0174"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("83e7a346-4d17-4aa8-8f66-bb27abfb85f4"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("84454959-928d-4413-b0b7-134282107bea"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("84556a79-65b3-4e3e-92ca-f103452400b5"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("84a1130d-0859-477b-8ad3-22bd1d0a2185"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("863b4fc1-2dcb-47f1-b081-267d42fae210"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("86f97ee8-0574-49c0-9a1a-3a7db0314c89"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("8a3563ba-3ecf-48a3-9bf7-e556c2a7d1bd"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("8a6bdc51-3459-49ec-98d2-23050998fb04"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("8b687635-f1f9-49af-b4aa-d7d043a1a7be"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("8b9886ee-881c-4566-91d8-18bdae5d6f0f"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("8ba05c88-05c6-4b65-8ee9-fd4eb985580d"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("8e35c869-f6d3-4abb-b549-3323e66430f3"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("8f0fc1ab-e10e-4f2e-9336-7c62bb383064"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("8f2a7173-ad59-4fe0-942e-d65ea7f40893"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("8ff9c32c-f112-48c1-9593-7451d78af591"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("90b9b2aa-33b8-4dda-820b-7192e3b0da6a"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("92192638-40e1-4ba8-9c17-fbfa00156845"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("93b4c06c-570f-4293-af65-71c8aeb36a4d"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("93bd3310-f4b0-410a-a64b-da3383e47484"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("94ac8e4d-6fdd-441f-a451-fc3c00999fe8"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("95614f93-2840-465a-9b5b-4a239a46464a"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("95e58184-ba5f-4439-a41b-82f8a87d4d07"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("96665f51-0339-4d39-8eb0-88e21b26de9c"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("96c12bed-cb7e-4ade-9eeb-b82b290317a9"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("976c157a-4589-4c16-8a92-00c94e1a620b"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("98d21c82-0df3-426f-9754-c2791e60b0bc"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("99a421d8-1c89-42ac-bce1-24baaf9d4a41"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("9b349299-4414-47b0-a695-929412b7a759"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("9c0cc85e-fad7-4951-b0d4-8e54e3308a7c"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("9c4b6ebc-1cc9-4d73-a9d5-20ae03102a60"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("9ce4e76b-c998-43d2-aa95-455d6360147a"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("9cf02303-5cfd-4e69-b18b-9bc4260f35f7"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("9da7219b-1855-4662-a63e-cb390a2e2087"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("9e356f1c-9432-4a34-a117-ec8bbee2d195"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("9f507dd6-b954-4b61-9b7c-ac7faa220aa8"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("9fc6d672-161f-4086-877a-c6d4b617626b"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("a24d41ca-4421-4126-8f12-b5e560c33267"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("a2975a59-be53-4d2d-99a6-b492b64badbe"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("a2c67e40-880d-4540-90b6-da4f8b7349b8"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("a49f53ff-c2a4-4c74-9c5d-0842c71d0744"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("a654022d-ad8e-40e4-a85f-4581e2cbadc5"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("a673ea77-adf0-4107-be57-b2dcfa8296d4"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("a7054d54-9aba-49eb-b62e-6756b9d4e299"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("a778d93b-7d0e-47cf-b4c7-62f63d4e91e8"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("a7bca2cc-02ce-4504-be46-ac40eff2d551"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("a7eac536-a844-40dd-8b49-b743224c0f06"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("a8e91189-e535-4534-a7b1-3ee9cc4d6953"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("a96ac3a2-2a75-4496-b046-1dc8a5031eeb"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("a9b84240-4d18-42ab-8577-9fd25af8d630"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("aa09e0bc-1070-485b-aed7-1e6563935bed"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("aa199bcb-a3e0-4ff3-adb1-cd2c3f14f533"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("aae0fce0-6c42-4355-87dd-9935d7aa1e53"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("aba73a63-dc3f-4826-a3d2-6b2042a5a962"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("ad04ca8b-1564-4844-b26c-be2a2e0e1412"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("ad4f5636-3164-48da-ab55-71aecd365ad6"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("ad8b1d8a-736b-4da4-985e-4be3e3bc4fa4"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("ae14de62-3578-4e82-afec-743164182f11"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("aea935e3-c65b-4ffb-ac0f-567378d88175"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("aecd3e64-15ce-488e-8811-edf166ee4aad"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("af7d407a-c70e-4702-bf3e-4e5739a31e89"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("b1958675-fb78-442f-8998-ef55b2477745"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("b244bacb-dd8c-46e3-9575-a15772deb0a8"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("b282e7bb-9b89-4b6f-aadf-319e693c4dc6"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("b2d0e857-0aef-4bc8-b2e7-e04b013404b9"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("b422bad4-cdab-43d8-96c9-60ade55fe7cd"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("b43add60-e34a-47d2-9e1a-620dd86251af"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("b4bffb5e-2089-4c53-8431-7188eacf0e97"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("b543ac02-8a2b-4628-9ae1-3b5fcfbec4e1"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("b9b14357-6f7d-44a2-a9e9-ab0d3988e616"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("b9e524e1-0c47-42c5-be8e-6288fc3a27f7"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("b9f27a1c-cf6d-4ebd-9387-8d56469d4755"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("bc8d24a9-022b-4902-88a6-1c0e92e16794"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("bca0b6aa-d36c-447a-a59b-4f733af57836"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("bcfbaa8f-7a7d-43c7-9cab-00446f740769"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("bf3574ff-e1b9-4d16-8981-2aec361d0272"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("c208386a-3541-4665-9299-456c6af2b991"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("c3811c1f-a149-455f-a3d0-6a649d09537b"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("c3bc3490-4856-40e7-88a4-aeb336f76ed4"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("c420119a-240e-4135-9c9b-81a6b411958c"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("c553d218-9c02-4cd2-95f4-17e0718ddbce"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("c5a1f299-558b-4d9d-935e-c29101c85b20"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("c607b8f4-162c-4d3c-b60f-da4323164afb"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("c9fa3893-003e-4fb5-8f3d-d24e90436530"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("ca1292f2-0f07-4a20-ae39-7dae7dce30c7"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("cb516b6d-2b55-4983-a2a6-6e66f354e5f7"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("cc666b36-e7db-4dc0-90e4-2936421cfb11"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("cc9c2fa9-eb9d-42c3-8e95-409e5ff6bf7c"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("cdc529aa-f35e-4ec8-901a-cf9ee10777e2"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("ce2f3c5e-c1b8-46e3-8f9e-9d5b97fb5240"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("cf913d0f-6f5f-449c-8231-358f9a9eb607"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("cf967941-a8b2-4862-b7e7-af71a3933b9b"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("d0d67377-506f-4b01-8cdf-0b0accaa1fc7"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("d1077ae6-965f-4cb3-9b06-c6e91cc1952d"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("d33871a1-fe8b-422b-9080-b559bb143ff1"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("d48264e8-565b-49ed-bcdb-7b06325fa20c"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("d523bb45-00b3-4836-a356-30d8a5cc646d"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("d6edcf5e-0cbb-48f4-acde-3dd62374a8ad"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("d82201c4-fcc1-4903-b7c9-ef6934b15554"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("d831becb-7130-4e14-a296-8e199c438f96"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("d916cd17-71be-4014-b1e8-3ccbdff954b1"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("d9be3c52-eb3a-4b5b-a924-d0e4cb6ddf50"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("dafe7386-fcae-4089-8939-797d3be170db"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("db050a84-18a0-4f03-b362-5b6154577b34"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("db291a39-3d07-4029-a840-14f8a1004bba"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("db903bbc-00b7-4e27-8c99-660e2af61f4e"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("dc08efdb-09c9-499d-bdcd-88e556e8a9be"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("dd490eb7-8042-41d6-85a7-3a80d6dbfb8d"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("de016bd1-6b67-4680-942e-1f318600e865"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("de0be467-005f-43e5-9728-eda34809ee65"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("de519c5d-0e3c-4168-b8b5-8ea98d71ca2e"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("deda8c4b-f5d3-46c5-8da3-bb015294daed"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("dff79e8c-960f-4c85-965f-c406e3ac043b"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("e0d25b72-7b73-47a1-b5a6-463ced0bccb0"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("e1c5e50d-c853-4248-9021-2337e4acd79f"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("e20416c0-7c37-4b24-b9e5-0f3fbfc8cf90"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("e22512fe-cc47-467e-8250-f545b0e68786"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("e2e62db0-8810-456d-9f26-947480408607"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("e44dbb19-1fbd-45ea-b6c4-b6d49a8d5114"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("e474e0f6-d416-4346-a0a8-0fed81b4a4bd"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("e488cc28-0d2e-474c-95d7-e644e2ea7185"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("e4cd457c-2f29-4783-852f-face0d71776e"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("e542a120-8f15-4267-b6a5-4bed92e977eb"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("e78271e4-4ae4-4a98-838a-84a71b307543"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("e9eb1306-55b2-468e-9c50-f4419fccaedd"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("ea8683ba-4043-4488-8fc8-4ba8f4f7a7b2"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("eb09211e-e582-455e-af29-ab028a428da4"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("eb1bb3d6-66c1-489e-9f6f-025023f5e4a8"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("eb5b6524-a7ce-4e64-8bf8-f81ed695dbc0"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("eb7a34dd-8457-42af-8ee2-2178180e24e5"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("edc5a54b-4d05-4cab-82d4-d828ce4d9a44"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("ee9f0d35-2f28-488b-9061-4aea6796bd98"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("eebbe133-79ab-479b-9139-80348e5c1463"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("ef27b446-7881-43df-b7c2-3a00e4ec83cf"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("f002b868-7d9f-4b80-b56a-58fce67324f8"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("f1a26e12-6365-448e-81f8-45515cb2f73f"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("f292b60a-2ac0-435d-9a4b-efab1db7979a"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("f2dd5422-1724-4030-8e32-987f645c06b3"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("f3835868-41c0-482f-ad1f-0760c856512a"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("f485f89c-a26f-485c-81f5-c4286a1fff13"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("f53ea01f-b140-46b7-aa59-66185d9580dd"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("f53f2917-dd4e-4b02-b0f2-09f72f129d17"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("f56a91ea-5ac9-4c45-8b13-4a1f4c590ee6"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("f593e7d2-c940-4987-a74b-9ca55dc5d6d9"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("f6218a18-0b44-4284-ac42-7b68ab2162bb"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("f6640656-a1cb-464e-9985-fe6dea9b21c7"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("f66a8c82-1a40-462d-be52-28cac60338f0"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("f8117f89-6a74-47db-8c1d-0bd1b58c7ffd"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("f83a91a7-da53-41e9-8faf-0d7b254c7b7f"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("f89eee4b-5cdf-414b-82c6-df013a825ccd"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("f95d1379-405a-4f99-bfa6-c9550640ba38"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("f98ffa0a-f21b-4187-b96d-97851457035f"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("fa2b0cac-035f-48de-9121-e2106b9bb8ce"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("fa8bdd99-22ec-4eda-b09d-339b7fe85929"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("fb01e187-3acb-41e0-b080-7e50c2912a98"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("fb8cf12e-91d3-4e15-a1e0-ecfde210591f"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("fb98c1f6-9357-43c8-a07f-8a40826b952f"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("fcfc1d0b-375e-4cb5-b148-2fe05af7107c"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("fd15e57f-0b82-41ce-91dc-2ed72664aeef"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("fd679c31-febe-4072-9b9e-20f70f5c608f"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("fd798780-9cc7-49c8-bd18-3c8a5a8e00f4"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("fe62e398-6723-4172-8bfe-d634030e018d"));

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: new Guid("feff9898-272e-4691-8e04-5248fd1c3055"));

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "IsCommunityMember",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "IsPrivate",
                table: "Land");

            migrationBuilder.AddColumn<Guid>(
                name: "LandId",
                table: "Person",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Person_LandId",
                table: "Person",
                column: "LandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Land_LandId",
                table: "Person",
                column: "LandId",
                principalTable: "Land",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
