// ctrl+ alt + v 
/* swagerden  geleni donustüryor ===  json2ts
{
  "name": "string",
  "description": "string",
  "publicationDate": "2024-04-19T08:00:10.494Z",
  "punishmentAmount": 0,
  "isBorrowable": true,
  "borrowDay": 0
} */
export interface AddMaterialRequest {
	name: string;
	description: string;
	publicationDate: string;
	punishmentAmount: number;
	isBorrowable: boolean;
	borrowDay: number;
}