import { IsEmpty, IsNotEmpty } from 'class-validator';

export class CreateUserDto {
  @IsEmpty({ message: 'name không được để trống' })
  name: string;

  email: string;
  password: string;
  phone: string;
  address: string;
  image: string;
}
